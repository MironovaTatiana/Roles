
namespace Roles.Services
{
    /// <summary>
    /// Сервис выдачи доступа для сотрудника
    /// </summary>
    class AccessGranterService
    {
        #region Поля

        private PrintService _printer = new PrintService();

        #endregion 

        #region Конструктор

        public AccessGranterService() { }

        #endregion

        #region Методы

        public void GrantAll(IEmployee emp, IAccountSystem account, IChat chat)
        {
            RegisterEmail(emp.GetEmail());
            SetPortalAccess(emp.GetRole());
            AddToTelegrammChats(emp.GetChats(chat));
            RegisterAccountId(emp.GetAccountId(account));
        }

        public void SetPortalAccess(string role)
        {
            _printer.Print($"Роль - {role}");
        }

        public void RegisterEmail(string email)
        {
            _printer.Print(email);
        }

        public void AddToTelegrammChats(string chats)
        {
            _printer.Print($"Список чатов - {chats}");
        }

        public void RegisterAccountId(string id)
        {
            _printer.Print(id);
        }

        #endregion
    }
}
