using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emBLL;
using emModel;
using System.Text;

namespace emMamage
{
    /// <summary>
    /// EmShowInfo 的摘要说明
    /// </summary>
    public class EmShowInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(Getemshow());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public static string Getemshow()
        {
            StringBuilder sb = new StringBuilder();
            List<em> list = EmLogic.GetShow();

            foreach (em e in list)
            {
                sb.Append("<tr>");
                sb.Append("<td><input type='checkbox' name='check' /></td>");
                sb.Append("<td>" + e.Name + "</td>");
                sb.Append("<td>" + e.Age + "</td>");
                sb.Append("<td>" + e.EmType + "</td>");
                sb.Append("<td><input type='button' name='del' value='删除' id='btndel'/></td>");
                sb.Append("</tr>");
            }
            return sb.ToString();
        }
    }
}