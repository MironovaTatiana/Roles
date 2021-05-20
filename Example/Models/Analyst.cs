
namespace Roles.Models
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

        #endregion
    }
}
