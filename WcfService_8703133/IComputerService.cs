using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_8703133
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IComputerService
    {
        [OperationContract]
        string AddComputer(Computer computer);

        [OperationContract]
        string UpdateComputer(Computer computer);

        [OperationContract]
        string DeleteComputer(string uuid);

        [OperationContract]
        Computer GetComputer(string uuid);

        [OperationContract]
        List<Computer> GetAllComputers();
        [OperationContract]
        List<Brand> GetAllBrands();
        [OperationContract]
        List<OS> GetAllOses();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class OS
    {
        int id = 0;
        string name = "OS ";

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    [DataContract]
    public class Brand
    {
        int id = 0;
        string name = "Brand ";

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    [DataContract]
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

        [DataMember]
        public string Uuid
        {
            get { return uuid; }
            set { uuid = value; }
        }
        [DataMember]
        public string HardDrive
        {
            get { return hardDrive; }
            set { hardDrive = value; }
        }
        [DataMember]
        public string ScreenSize
        {
            get { return screenSize; }
            set { screenSize = value; }
        }
        [DataMember]
        public string DisplayResolution
        {
            get { return displayResolution; }
            set { displayResolution = value; }
        }
        [DataMember]
        public string Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        [DataMember]
        public int Os
        {
            get { return os; }
            set { os = value; }
        }
        [DataMember]
        public int Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    [DataContract]
    public class Customer
    {
        string uuid = "";
        string name = "";
        string email = "";
        string password = "";

        [DataMember]
        public string Uuid
        {
            get { return uuid; }
            set { uuid = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

    [DataContract]
    public class Order
    {
        string orderNo = "";
        string customerId = "";

        [DataMember]
        public string OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        [DataMember]
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }

    [DataContract]
    public class OrderItem
    {
        int itemId = 0;
        string orderNo = "";
        string customerId = "";
        int quantity = 0;

        [DataMember]
        public string OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        [DataMember]
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }
}
