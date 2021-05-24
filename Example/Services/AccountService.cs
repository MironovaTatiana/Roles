using System;


namespace Roles.Services
{
    /// <summary>
    /// Сервис выдачи учетных записей
    /// </summary>
    class AccountService : IAccountSystem
    {
        #region Конструктор

        public AccountService() { }

        #endregion

        #region Методы

        public int GetAccountId(string fio, string phone, string post)
        {
            var random = new Random();
            var id = random.Next(10000000, 99999999);

            return id;
        }

        #endregion
    }
}
