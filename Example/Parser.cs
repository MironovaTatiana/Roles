using System;
using System.Linq;

namespace Roles
{
    /// <summary>
    /// Парсер
    /// </summary>
    class Parser
    {
        #region Перечисления

        /// <summary>
        /// Список должностей
        /// </summary>
        private static readonly Type[] _posts =
        {
            typeof(Programmer),
            typeof(Manager),
            typeof(Analyst)
        };

        #endregion

        #region Конструктор

        public Parser() { }

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
                    var postForUsing = _posts.FirstOrDefault(p => p.Name == post);

                    if (postForUsing != null)
                    {
                        var parser = (Employee)Activator.CreateInstance(postForUsing);

                        if (parser != null)
                        {
                            var granter = new AccessGranterService();

                            parser.Fio = requisites[0]?.Trim();
                            granter.GrantAll(parser);
                        }
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
