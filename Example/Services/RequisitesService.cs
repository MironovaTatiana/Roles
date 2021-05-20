using System;
using Roles.Models;

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
                        var parser = GetType(post);
                        var granter = new AccessGranterService();

                        parser.Fio = requisites[0]?.Trim();
                        parser.Phone = requisites[1]?.Trim();
                        parser.Post = post;

                        var account = new AccountService();
                        var chat = new ChatService();

                        granter.GrantAll(parser, account.GetAccountId(parser), chat.GetChats(parser));
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

        private Employee GetType(string name)
        {
            switch (name)
            {
                case nameof(Programmer):
                    return new Programmer();
                case nameof(Manager):
                    return new Manager();
                case nameof(Analyst):
                    return new Analyst();
                default:
                    throw new Exception();
            }
        }

        #endregion
    }
}
