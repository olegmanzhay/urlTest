using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace test2
{
    class MySQL
    {
        private string urlLong;                                                                  // Длинный URL
        private string urlShort;                                                                 // Короткий URL
        private string date;                                                                     // Дата
        private int countPassing;                                                                // Количество пепреходов

        public string URLLONG
        {
            get
            {
                return urlLong;
            }
            set
            {
                urlLong = value;
            }
        }
        public string URLSHORT
        {
            get
            {
                return urlShort;
            }
            set
            {
                urlShort = value;
            }
        }
        public string DATE
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int COUNTPASSING
        {
            get
            {
                return countPassing;
            }
            set
            {
                countPassing = value;
            }
        }

        public MySqlConnection conn = new MySqlConnection();                                    // Соединение с БД
        /// <summary>
        /// Чтение БД
        /// </summary>
        /// <returns></returns>
        public MySqlDataReader LoadData()
        {
            MySqlConnectionStringBuilder MysqlConnection = new MySqlConnectionStringBuilder();  //Данные о сервере
            MysqlConnection.Server = "localhost";
            MysqlConnection.Database = "url";
            MysqlConnection.UserID = "root";
            MysqlConnection.Password = "1234567890";

            conn.ConnectionString = MysqlConnection.ConnectionString;                           // Подключние к localhost
            conn.Open();                                                                        // Открытие соединения
            string query = "SELECT * FROM urlDB ORDER BY urlLong";                              // Получение данных из ДБ
            MySqlCommand command = new MySqlCommand(query, conn);                               // Выполнение запроса
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// Добавление данных в БД
        /// </summary>
        /// <param name="A"></param>
        public void AddUrl(MySQL A)
        {
            string sql = $"INSERT INTO `urldb` (`urlLong`, `urlShort`, `date`, `countPassing`) VALUES ('{A.URLLONG}', '{A.URLSHORT}', '{A.DATE}', '{A.COUNTPASSING}');";
            conn.Open();                                                                        // Открытие соединения
            MySqlCommand command = new MySqlCommand(sql, conn);                                 // ВЫполнение запроса
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();                                                                       // Закрытие соединения 
        }
        /// <summary>
        /// Удаление из БД
        /// </summary>
        /// <param name="A">База данных</param>
        public void DeleteUrl(MySQL A)
        {
            string sql = $"DELETE FROM `urldb` WHERE (`urlLong` = '{A.URLLONG}');";
            conn.Open();                                                                        // Открытие соединения
            MySqlCommand command = new MySqlCommand(sql, conn);                                 // ВЫполнение запроса
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();                                                                       // Закрытие соединения 
        }

        /// <summary>
        /// Получение необходимой ссылки для перехода
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public string resultURL(MySQL A)
        {
            string sql = $"SELECT urlLong FROM `urldb` WHERE (`urlShort` = '{A.URLSHORT}');";   // Получение длинного URL для перехода
            conn.Open();                                                                        // Открытие соединения
            MySqlCommand command = new MySqlCommand(sql, conn);                                 // ВЫполнение запроса
            MySqlDataReader reader = command.ExecuteReader();

            string result = string.Empty;                                                       // Необ[одимый URL для перехода
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = reader.GetString(0);                                               // Получаем необходимый URL
                }
            }
            else
            {
                MessageBox.Show("No such URL found");                                           // Если нет URL - ошибка
            }
            conn.Close();                                                                       // Закрытие соединения

            sql = $"SELECT countPassing FROM `urldb` WHERE (`urlShort` = '{A.URLSHORT}');";     // ЗАпрос на количество переходов
            conn.Open();                                                                        // Открытие соединения
            command = new MySqlCommand(sql, conn);                                              // ВЫполнение запроса
            reader = command.ExecuteReader();

            int counter = 0;                                                                    // Количество переходов
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    counter = reader.GetInt32(0);                                               //Получеине количества переходов
                    counter++;                                                                  // Увеличиваем количество переходов
                }
            }
            else
            {
                MessageBox.Show("Error reading counter");                                       // Ошибка при не нахождении
            }
            conn.Close();                                                                       // Закрытие соединения

            sql = $"UPDATE `urldb` SET `countPassing` = '{counter}' WHERE (`urlShort` = '{A.URLSHORT}');";  // Запрос на обновление БД
            conn.Open();                                                                        // Открытие соединения
            command = new MySqlCommand(sql, conn);                                              // Выполнеине запроса
            reader = command.ExecuteReader();
            conn.Close();                                                                       // Закрытие соединения
            return result;                                                                      // Необходимая ссылка для перехода 
        }
    }

}

