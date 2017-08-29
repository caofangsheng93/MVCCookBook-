using MustacheWebForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MustacheWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GetAllStudent()
        {
          
            List<Student> lstStuModel = new List<Student>();
            lstStuModel.Add(new Student() { StudentId = 1, Name = "曹方胜", Registered = false });
            lstStuModel.Add(new Student() { StudentId = 2, Name = "CFS", Registered = true });
            lstStuModel.Add(new Student() { StudentId = 3, Name = "caofangsheng", Registered = false });

            string str= JsonConvert.SerializeObject(lstStuModel);
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //string str = js.Serialize(lstStuModel);
            return str;
            
        }
    }
}