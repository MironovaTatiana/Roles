
namespace Roles.Employees
{
    /// <summary>
    /// Программист
    /// </summary>
    public class Programmer : EmployeeBase
    {
        #region Конструкторы

        public Programmer() { }

        #endregion

        #region Методы

        public override string GetRole()
        {
            return "user";
        }

        #endregion
    }
}
