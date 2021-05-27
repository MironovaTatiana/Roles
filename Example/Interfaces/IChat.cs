
namespace Roles
{
    /// <summary>
    /// Чаты
    /// </summary>
    public interface IChat
    {
        #region Методы

        string GetChats(string phone, string post);

        #endregion
    }
}
