
namespace Roles.Employees
{
    /// <summary>
    /// Аналитик
    /// </summary>
    public class Analyst : EmployeeBase
    {
        #region Конструкторы

        public Analyst() { }

        #endregion

        #region Методы

        public override string GetRole()
        {
            return "user";
        }

        #endregion
    }
}
