using System;
using System.Collections.Generic;

namespace Roles
{
    /// <summary>
    /// Аналитик
    /// </summary>
    public class Analyst : Employee
    {
        #region Конструкторы

        public Analyst() { }

        #endregion

        #region Методы

        public override string GetRole()
        {
            return "user";
        }

        public override List<string> GetChats()
        {
            return new List<string>() { "AnalystsChat", "SpeakingChat" };
        }

        #endregion
    }
}
