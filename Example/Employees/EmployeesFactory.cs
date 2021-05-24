
using System;

namespace Roles.Employees
{
    /// <summary>
    /// Аналитик
    /// </summary>
    public class EmployeesFactory
    {
        #region Конструкторы

        public EmployeesFactory() { }

        #endregion

        #region Методы
        public EmployeeBase GetType(string name)
        {
            switch (name)
            {
                case nameof(Programmer):
                    return new Programmer();
                case nameof(Manager):
                    return new Manager();
                case nameof(Analyst):
                    return new Analyst();
                default:
                    throw new Exception();
            }
        }

        #endregion
    }
}
