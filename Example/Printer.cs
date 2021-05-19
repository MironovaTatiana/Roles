using System;

namespace Roles
{
    /// <summary>
    /// Класс, отвечающий за вывод на консоль
    /// </summary>
    public class Printer
    {
        #region Конструктор

        /// <summary>
        /// Класс, отвечающий за вывод на консоль
        /// </summary>
        public Printer() {}

        #endregion

        #region Методы

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        #endregion
    }
}
