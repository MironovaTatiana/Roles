
namespace Roles.Models
{
    /// <summary>
    /// Работник
    /// </summary>
    public abstract class Employee : IEmployee
    {
        #region Поля

        /// <summary>
        /// Учетная система
        /// </summary>
        public static IAccountSystem _accountSystem;

        /// <summary>
        /// Учетная система
        /// </summary>
        public static IChat _chatService;

        #endregion

        #region Свойства

        public string Fio { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Post { get; set; }

        #endregion

        #region Конструктор

        public Employee() { }

        #endregion

        #region Методы

        public abstract string GetRole();

        public string GetChats(IChat chat)
        {
            _chatService = chat;

            return _chatService.GetChats(Phone, Post);
        }

        public string GetEmail()
        {
            return $"{Fio?.Replace(" ", "_")}@mail.ru";
        }

        public string GetAccountId(IAccountSystem accountSystem)
        {
            _accountSystem = accountSystem;

            var id = _accountSystem.GetId(Fio, Phone, Post);

            return id.ToString();
        }

        #endregion
    }
}
