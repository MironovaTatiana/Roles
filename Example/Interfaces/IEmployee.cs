
namespace Roles
{
    /// <summary>
    /// Интерфейс для работника
    /// </summary>
    public interface IEmployee
    {
        #region Свойства

        abstract string Fio { get; }
        abstract string Phone { get; }
        abstract string Post { get; }

        string Email { get; }

        #endregion 

        #region Методы

        string GetEmail();
        string GetRole();
        string GetAccountId(IAccountSystem account);
        string GetChats(IChat chat);

        #endregion
    }
}
