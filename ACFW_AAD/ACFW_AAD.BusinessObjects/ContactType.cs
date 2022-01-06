using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BusinessObjects
{
    public class ContactType
    {
        private int ctId;
        private string desc;

        public int CTId { set => ctId = value; get => ctId; }
        public string Desc { set => desc = value; get { return desc; } }
    }
}
