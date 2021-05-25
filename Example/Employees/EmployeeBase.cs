
namespace Roles.Employees
{
    /// <summary>
    /// Работник
    /// </summary>
    public abstract class EmployeeBase : IEmployee
    {
        #region Свойства

        public string Fio { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Post { get; set; }

        #endregion

        #region Конструктор

        public EmployeeBase() { }

        #endregion

        #region Методы

        public abstract string GetRole();

        public string GetEmail()
        {
            return $"{Fio?.Replace(" ", "_")}@mail.ru";
        }

        #endregion
    }
}
