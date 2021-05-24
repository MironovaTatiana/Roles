
namespace Roles.Services
{
    /// <summary>
    /// Сервис выдачи доступа для сотрудника
    /// </summary>
    class AccessGranterService
    {
        #region Поля

        private PrintService _printer = new PrintService();

        public IAccountSystem _account { get; set; }
        public IChat _chat { get; set; }

        public IEmployee _emp { get; set; }

        #endregion 

        #region Конструктор

        public AccessGranterService(IEmployee emp, IAccountSystem account, IChat chat) 
        {
            _emp = emp;
            _account = account;
            _chat = chat;      
        }

        #endregion

        #region Методы

        public void GrantAll()
        {
            RegisterEmail(_emp.GetEmail());
            SetPortalAccess(_emp.GetRole());
            AddToTelegrammChats(_chat.GetChats(_emp.Phone, _emp.Post));
            RegisterAccountId(_account.GetAccountId(_emp.Fio, _emp.Phone, _emp.Post));
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

        public void RegisterAccountId(int id)
        {
            _printer.Print(id.ToString());
        }

        #endregion
    }
}
