using System;
using System.Collections.Generic;

namespace Roles
{
    /// <summary>
    /// Менеджер
    /// </summary>
    public class Manager : Employee
    {
        #region Конструкторы

        public Manager() { }

        #endregion

        #region Методы

        public override string GetRole()
        {
            return "admin";
        }

        public override List<string> GetChats()
        {
            return new List<string>() { "ManagersChat", "SpeakingChat" };
        }

        #endregion
    }
}
