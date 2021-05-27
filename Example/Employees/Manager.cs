
namespace Roles.Employees
{
    /// <summary>
    /// Менеджер
    /// </summary>
    public class Manager : EmployeeBase
    {
        #region Конструкторы

        public Manager() { }

        #endregion

        #region Методы

        public override string GetRole()
        {
            return "admin";
        }

        #endregion
    }
}
