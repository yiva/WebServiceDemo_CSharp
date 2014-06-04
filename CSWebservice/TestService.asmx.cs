using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CSWebservice
{
    /// <summary>
    /// TestService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class TestService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Call(string name)
        {
            return "Hello "+name;
        }

        [WebMethod(Description="求和")]
        public double add(double n1, double n2) {
            return n1 + n2;
        }

        [WebMethod(Description = "求差")]
        public double sub(double n1, double n2)
        {
            return n1 - n2;
        }

        [WebMethod(Description = "求积")]
        public double multi(double n1, double n2)
        {
            return n1 * n2;
        }

        [WebMethod(Description = "求商")]
        public double div(double n1, double n2)
        {
            if(n2!=0){
                return n1 / n2;
            }
            return 0;
        }
    }
}
