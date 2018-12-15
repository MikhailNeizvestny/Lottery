using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace Lottery
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public void ChangeWinner(int memberId)
        {
            List<Person> members = Players.members;
            Person member = null;
            foreach (Person prs in Players.members)
            {
                if (prs.id == memberId)
                {
                    prs.ChangeWinner();
                    member = prs;
                    break;
                }
            }
            if (member != null)
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(member));
            }
        }
    }
}
