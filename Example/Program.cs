using System;
using Roles.Services;

namespace Roles
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Необходимо добавить нового сотрудника. Укажите ФИО, телефон, должность через запятую:");

            var input = Console.ReadLine();
            var parser = new RequisitesService();

            parser.ParseString(input);
        }
    }
}
