
namespace Roles
{
    /// <summary>
    /// Интерфейс для работника
    /// </summary>
    public interface IEmployee
    {
        #region Свойства

        string Fio { get; }
        string Phone { get; }
        string Post { get; }
        string Email { get; }

        #endregion 

        #region Методы

        string GetEmail();
        string GetRole();

        #endregion
    }
}
