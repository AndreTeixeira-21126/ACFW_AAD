using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BusinessObjects
{
    public interface IContactOwner
    {
        List<IContact> Contacts { set; get; }
    }
}
