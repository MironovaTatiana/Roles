using System;
using System.Collections.Generic;

namespace Roles
{
    /// <summary>
    /// Работник
    /// </summary>
    public abstract class Employee : IEmployee
    {
        #region Свойства

        public string Fio { get; set; }

        public string Email { get; set; }

        #endregion

        #region Конструктор

        public Employee() {}

        #endregion

        #region Методы

        public abstract string GetRole();

        public abstract List<string> GetChats();

        public string GetEmail()
        {
            return $"{Fio?.Replace(" ", "_")}@mail.ru";
        }

        public string GetAccountId()
        {
            var random = new Random();
            var id = random.Next(10000000, 99999999);

            return id.ToString();
        }

        #endregion
    }
}
