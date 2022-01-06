using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BusinessObjects
{
    public interface IContact
    {
         int ContactID { get; set; }
         string Desc { get; set; }

         ContactType CType { get; set; }
    }
}
