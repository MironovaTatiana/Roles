using System;

namespace Roles.Services
{
    /// <summary>
    /// Класс, отвечающий за вывод на консоль
    /// </summary>
    public class PrintService
    {
        #region Конструктор

        /// <summary>
        /// Класс, отвечающий за вывод на консоль
        /// </summary>
        public PrintService() {}

        #endregion

        #region Методы

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        #endregion
    }
}
