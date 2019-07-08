using System;

namespace test2
{
    class ConvertUrl
    {
        /// <summary>
        /// Получение сокращенного URL
        /// </summary>
        /// <param name="A"></param>
        /// <returns>string</returns>
        public string newUrl(ConvertUrl A)
        {
            string newStr = string.Empty;                   // Короткий URL
            string strTime = string.Empty;                  // Временная строка
            Random rand = new Random();
            
            for (int i = 0; i < 3; i++)
            {
                char tmp = (char)rand.Next('A', 'Z' + 1);
                string number = rand.Next(0, 10).ToString();
                strTime += tmp.ToString()+number;          
            }
            newStr = "https://localhost/" + strTime ;
            return newStr;
        }
    }
}
