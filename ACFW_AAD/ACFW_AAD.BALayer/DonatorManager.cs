using ACFW_AAD.DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BALayer
{
    public class DonatorManager
    {
        public int GetNumberDonators()
        {
            return DataAcess.GetNumberDonators();
        }
    }
}
