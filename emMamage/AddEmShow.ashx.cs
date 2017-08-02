using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emBLL;
using emModel;

namespace emMamage
{
    /// <summary>
    /// AddEmShow 的摘要说明
    /// </summary>
    public class AddEmShow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            em e = new em();
            e.Name = context.Request["Name"];
            e.Age = Convert.ToInt32( context.Request["Age"]);
            e.EmType = context.Request["EmType"];
            EmLogic.AddEm(e);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
}