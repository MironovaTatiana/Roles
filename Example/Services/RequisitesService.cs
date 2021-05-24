using System;
using Roles.Employees;

namespace Roles.Services
{
    /// <summary>
    /// Сервис для получения реквизитов
    /// </summary>
    class RequisitesService
    {
        #region Конструктор

        public RequisitesService() { }

        #endregion

        #region Методы

        public void ParseString(string s)
        {
            try
            {
                var requisites = s.Split(",");

                if (requisites.Length == 3)
                {
                    var post = requisites[2]?.Trim();

                    if (!string.IsNullOrEmpty(post))
                    {
                        var factory = new EmployeesFactory();
                        var parser = factory.GetType(post);

                        parser.Fio = requisites[0]?.Trim();
                        parser.Phone = requisites[1]?.Trim();
                        parser.Post = post;

                        var account = new AccountService();
                        var chat = new ChatService();

                        var granter = new AccessGranterService(parser, account, chat);

                        granter.GrantAll();
                    }
                    else
                    {
                        Console.WriteLine("Введены некорректные реквизиты");
                    }
                }
                else
                {
                    Console.WriteLine("Введены некорректные реквизиты");
                }
            }
            catch
            {
                Console.WriteLine("Во время добавления сотрудника произошла ошибка");
            }
        }    

        #endregion
    }
}
