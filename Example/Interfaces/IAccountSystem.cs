
namespace Roles
{
    /// <summary>
    /// Интерфейс для учетной системы
    /// </summary>
    public interface IAccountSystem
    {
        #region Методы

        int GetAccountId(string fio, string phone, string post);

        #endregion
    }
}
