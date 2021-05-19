using System;
using System.Collections.Generic;

namespace Roles
{
    /// <summary>
    /// Программист
    /// </summary>
    public class Programmer : Employee
    {
        #region Конструкторы

        public Programmer() { }

        #endregion

        #region Методы

        public override string GetRole()
        {
            return "user";
        }

        public override List<string> GetChats()
        {
            return new List<string>() { "ProgrammersChat", "GitLabChat", "SpeakingChat" };
        }

        #endregion
    }
}
