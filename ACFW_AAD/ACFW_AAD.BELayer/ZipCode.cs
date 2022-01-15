namespace ACFW_AAD.BELayer
{
    public class ZipCode
    {
        private string zipID;
        private string locality;

        public string Locality
        {
            get { return locality; }
            set { locality = value; }
        }

        public string ZIPCode
        {
            get { return zipID; }
            set { zipID = value; }
        }

    }
}