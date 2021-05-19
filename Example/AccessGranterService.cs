using System;
using System.Collections.Generic;

namespace Roles
{
    /// <summary>
    /// Сервис выдачи доступа для сотрудника
    /// </summary>
    class AccessGranterService
    {
        #region Поля

        private Printer _printer = new Printer();

        #endregion 

        #region Конструктор

        public AccessGranterService() { }

        #endregion

        #region Методы

        public void GrantAll(IEmployee emp)
        {
            RegisterEmail(emp.GetEmail());
            SetPortalAccess(emp.GetRole());
            AddToTelegrammChats(emp.GetChats());
            RegisterAccountId(emp.GetAccountId());
        }

        public void SetPortalAccess(string role)
        {
            _printer.Print($"Роль - {role}");
        }

        public void RegisterEmail(string email)
        {
            _printer.Print(email);
        }

        public void AddToTelegrammChats(List<string> chats)
        {
            if (chats.Count > 0)
            {
                _printer.Print("Список чатов:");

                foreach (var chat in chats)
                {
                    _printer.Print(chat);
                }
            }
        }
        public void RegisterAccountId(string id)
        {
            _printer.Print(id);
        }

        #endregion
    }
}
