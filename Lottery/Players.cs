using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lottery
{
    public static class Players
    {
        private static List<Person> members = null;
        public static List<Person> Members
        {
            get
            {
                members = new List<Person>();
                Person person = new Person(1, "Иванов Иван Иванович");
                members.Add(person);
                person = new Person(2, "Петров Петр Петрович");
                members.Add(person);
                person = new Person(3, "Петренко Татьяна Ивановна");
                members.Add(person);
                person = new Person(4, "Красильников Лазарь Николаевич");
                members.Add(person);
                person = new Person(5, "Ершов Евгений Федосеевич");
                members.Add(person);
                person = new Person(6, "Савин Олег Лукьевич");
                members.Add(person);
                return members;
            }
        }
    }
}