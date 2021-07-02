using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class mdlPersonalDesc
    {
        public int PDId { get; private set; }
        public string PDHun { get; private set; }
        public string PDEng { get; private set; }
        public int PDUId { get; private set; }

        public mdlPersonalDesc(int pdid, string pdhun, string pdeng, int pduid)
        {
            PDId = pdid;
            PDHun = pdhun;
            PDEng = pdeng;
            PDUId = pduid;
        }
    }
}
