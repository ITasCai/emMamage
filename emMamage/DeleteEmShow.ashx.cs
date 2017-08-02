
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emBLL;
using emModel;

namespace emMamage
{
    /// <summary>
    /// DeleteEmShow 的摘要说明
    /// </summary>
    public class DeleteEmShow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            em e = new em();
            e.Name = context.Request["name"];
            EmLogic.DeleteEm(e);
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