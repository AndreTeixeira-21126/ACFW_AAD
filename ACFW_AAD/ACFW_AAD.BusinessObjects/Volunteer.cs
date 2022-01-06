using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BusinessObjects
{
    public class Volunteer : IContactOwner
    {

        private int volunteerID;
        private string names;
        public List<IContact> Contacts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VolunteerID { get => volunteerID; }
    }
}
