using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BusinessObjects
{
    public class Donation
    {

        private int donationID;
        private string des;
        public int DonationID { get => donationID; }
        public string Desc { set => des = value; get => des; }
    }
}
