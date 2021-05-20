
namespace Roles.Models
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

        #endregion
    }
}
