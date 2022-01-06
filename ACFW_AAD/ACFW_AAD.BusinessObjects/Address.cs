using System;

namespace ACFW_AAD.BusinessObjects
{
    public class Address
    {
        #region Fields
        private int addressID;
        private string addressName;
        private int addressNumber;
        private ZIPCode zipCode;
        #endregion

        public int AddressID { get => addressID; }
        public string AddressName { get => addressName; set => addressName = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }

        private ZIPCode ZipCode { get => zipCode; set => zipCode = value; }
    }
}