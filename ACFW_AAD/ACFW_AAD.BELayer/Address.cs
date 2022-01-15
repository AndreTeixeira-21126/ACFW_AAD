namespace ACFW_AAD.BELayer
{
    public class Address
    {
        private int id;
        private string street;
        
        private ZipCode zipCode;

        private int number;

        private static int nextID = 1;

        public static int NextID { set => Address.nextID += value; get { return nextID; } }
 
        public int Number
        {
            get { return number; }
            set { number = value; }
        }


        public ZipCode ZIPCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }



        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}