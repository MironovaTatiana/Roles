
namespace Roles.Models
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

        #endregion
    }
}
