using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataDB();                                               // Загрузка таблицы url при открытии формы
        }

        MySQL DB = new MySQL();                                         // База данных                                  
        private void LoadDataDB()
        {
            MySqlDataReader reader = DB.LoadData();                     // Загрузка таблицы url
            List<string[]> data = new List<string[]>();                 // Список строк таблицы url
            while (reader.Read())                                       // Чтение таблицы url
            {
                data.Add(new string[4]);                                
                data[data.Count - 1][0] = reader[0].ToString();     
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();                                             // Закрытие чтения
            DB.conn.Close();                                            // Закрытие соединения

            foreach (string[] s in data)                                // Заполнение dataGridView1
            {
                dataGridView1.Rows.Add(s);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConvertUrl urlNew = new ConvertUrl();                       // Объект для конвертирования URL в коротикий URL
            dataGridView1.Rows.Clear();                                 // Отчистка dataGridView1 для обновления таблицы
            DB.URLLONG = txtUrlLong.Text;                               // Длинная ссылка
            DB.URLSHORT = urlNew.newUrl(urlNew);                        // Получение короткой ссылки
            DB.DATE = DateTime.Now.ToString();
            DB.COUNTPASSING = 0;                                        // Количество переходов
            DB.AddUrl(DB);                                              // Добовление в БД строки
            LoadDataDB();                                               // Обновление таблицы
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null || dataGridView1.CurrentCell!=null)    // Проверка на выделение всей строки и выделения ячейки
            {
                DB.URLLONG = dataGridView1.CurrentCell.Value.ToString();                
            }
            dataGridView1.Rows.Clear();                                 // Отчистка dataGridView1 для обновления таблицы
            DB.DeleteUrl(DB);                                           // Удаление строеки из БД
            LoadDataDB();                                               // Обновление таблицы
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DB.URLSHORT = txtUrlShort.Text;                             // Короткий URL
            string resultLong = DB.resultURL(DB);                       // Получение ссылки
            System.Diagnostics.Process.Start(resultLong);               // Открытие URL
            wbShortUrl.Navigate(resultLong);                            // Открытие URL в элементе webBrowser
            dataGridView1.Rows.Clear();                                 // Отчистка dataGridView1 для обновления таблицы
            LoadDataDB();                                               // Обновление таблицы
        }

       
    }
}
