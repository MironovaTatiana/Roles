using System;
using System.Collections.Generic;

namespace Roles
{
    /// <summary>
    /// Интерфейс для работника
    /// </summary>
    public interface IEmployee
    {
        #region Свойства

        public abstract string Fio { get; set; }

        public string Email { get; set; }

        #endregion 

        #region Методы

        public string GetEmail();
        public string GetRole();
        public string GetAccountId();
        public List<string> GetChats();

        #endregion
    }
}
