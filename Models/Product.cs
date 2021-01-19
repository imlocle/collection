using System;

namespace collection.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public float PurchasePrice {get;set;}
        public string ManufacturerId {get;set;}
        public int ProductCategoryId{get;set;}
        public DateTime PurchaseDate {get;set;}
        public DateTime CreatedDate {get;set;}
        public DateTime ModifiedDate {get;set;}
    }

    public class ProductView
    {
        public string Id {get;set;}
        public string Name {get;set;}
        public string PurchasePrice {get;set;}
        public string PurchaseDate {get;set;}
        public string Manufacture {get;set;}
        public string ProductCategoryName {get;set;}

    }
}