
namespace Roles
{
    /// <summary>
    /// Интерфейс для учетной системы
    /// </summary>
    public interface IAccountSystem
    {
        #region Методы

        int GetId(string fio, string phone, string post);

        #endregion
    }
}
