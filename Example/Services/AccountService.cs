using System;
using Moq;
using Roles.Models;

namespace Roles.Services
{
    /// <summary>
    /// Сервис выдачи учетных записей
    /// </summary>
    class AccountService
    {
        #region Конструктор

        public AccountService() { }

        #endregion

        #region Методы

        public IAccountSystem GetAccountId(Employee emp)
        {
            var random = new Random();
            var id = random.Next(10000000, 99999999);
            var mockService = new Mock<IAccountSystem>();

            mockService
                    .Setup(r => r.GetId(emp.Fio, emp.Phone, emp.Post))
                    .Returns(id);

            return mockService.Object;
        }

        #endregion
    }
}
