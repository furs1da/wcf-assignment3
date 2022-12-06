namespace WCF3_Client.Models
{
    public class Computer
    {
        string uuid = "";
        string name = "";
        string imageUrl = "";
        int quantity = 0;
        double price = 0;
        int os = 0;
        string hardDrive = "";
        string screenSize = "";
        int brand = 0;
        string displayResolution = "";
        string ram = "";

        public string Uuid
        {
            get { return uuid; }
            set { uuid = value; }
        }
        public string HardDrive
        {
            get { return hardDrive; }
            set { hardDrive = value; }
        }

        public string ScreenSize
        {
            get { return screenSize; }
            set { screenSize = value; }
        }

        public string DisplayResolution
        {
            get { return displayResolution; }
            set { displayResolution = value; }
        }

        public string Ram
        {
            get { return ram; }
            set { ram = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Os
        {
            get { return os; }
            set { os = value; }
        }

        public int Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }
}
