using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Q = Queue;

namespace QueueWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
      public static Q.Queue D = new Q.Queue();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string Enqueue(string obj)
        {            
            List<string> list = D.enqueue(obj);
            return JsonConvert.SerializeObject(list);          
        }

        [WebMethod]
        public static void Dequeue()
        {
            List<string> list = D.dequeue();
        }


        [WebMethod]
        public static string GetQueue()
        {
            List<string> QueueItems = new List<string>();
            QueueItems = D.GetAll();
            //QueueItems.Reverse();
            return JsonConvert.SerializeObject(QueueItems);     
        }
    }
}