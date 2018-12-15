using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lottery
{
    public partial class Default : System.Web.UI.Page
    {

        Random rnd = new Random();

        public bool DefineWinner()
        {
            return Convert.ToBoolean(rnd.Next(0, 2));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Players.FillList();
            foreach (Person member in Players.members)
                member.winner = DefineWinner();
            repMembers.DataSource = Players.members; 
            repMembers.DataBind();//отправляем данные для заполнения таблицы

        }
    }
}