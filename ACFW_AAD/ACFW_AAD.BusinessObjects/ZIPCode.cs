using System;

namespace ACFW_AAD.BusinessObjects
{
    public class ZIPCode
    {
        private int zipCodeID;
        private string location;

        public int ZIPCodeID { get => zipCodeID; }
        public string Location { get => location; set => location = value; }
    }
}