using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emDAL;
using emModel;

namespace emBLL
{
    public class EmLogic
    {
        public static List<em> GetShow()
        {
            return EmService.GetShow();
        }

        public static int AddEm(em e)
        {
            return EmService.AddEm(e);
        }

        public static int DeleteEm(em e)
        {
            return EmService.DeleteEm(e);
        }

        }
}
