using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BusinessObjects
{
    public class Donator:IContactOwner
    {
        #region Fields

        private int donatorID;
        private string donatorName;
        private Address address;
        private List<IContact> contacts;

        #endregion
        public int DonatorID { get => donatorID; }
        public string DonatorName { get => donatorName; set => donatorName = value; }
        
        public List<IContact> Contacts { get => contacts; set => contacts = value; }
    }
    
}
