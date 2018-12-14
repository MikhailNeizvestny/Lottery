using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lottery
{
    public class Person
    {
        public int id;
        public string name;
        public bool winner;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
            DefineWinner();
        }

        public void DefineWinner()
        {
            Random rnd = new Random();
            this.winner = Convert.ToBoolean(rnd.Next(0, 2));
        }
    }

    public partial class Default : System.Web.UI.Page
    {
        public List<Person> members = new List<Person>();

        Person member_1 = new Person(1, "Иванов Иван Иванович");
        Person member_2 = new Person(2, "Петров Петр Петрович");
        Person member_3 = new Person(3, "Петренко Татьяна Ивановна");
        Person member_4 = new Person(4, "Красильников Лазарь Николаевич");
        Person member_5 = new Person(5, "Ершов Евгений Федосеевич");
        Person member_6 = new Person(6, "Савин Олег Лукьевич");

        void AddMembersToList()
        {
            members.Add(member_1);
            members.Add(member_2);
            members.Add(member_3);
            members.Add(member_4);
            members.Add(member_5);
            members.Add(member_6);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            AddMembersToList();
            foreach (Person member in members)
                member.DefineWinner();

        }
    }
}