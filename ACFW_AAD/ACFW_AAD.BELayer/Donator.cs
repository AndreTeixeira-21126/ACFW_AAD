using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFW_AAD.BELayer
{
    public class Donator
    {
        private int id;
        private string name;
        private Address address;
        private LoginData loginData;

        private static int nextID = 1;

        public static int NextID { set { nextID = value; } get => nextID; }

        static Donator()
        {
            

        }
        public Address Adr
        {
            get { return address; }
            set { address = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return  id; }
            set {  id = value; }
        }

        public LoginData LData { get => loginData; set => loginData = value; }
    }
}
