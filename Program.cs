using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Dealeron_Interview
{
    class Program
    {
        static void Main(string[] args)
        {

            //  The Approach that I used for this Sales Tax application is that I have a Interface called Shopping cart which has an 2 abstract functions 
            //called Calculate_Amount and SalesTax. The way i do this is that I have a multiple items lets say Books, Music, Imported Items and Choclate. 
            //Let say customer come ab=nd buy all the items my pogramm will just initialize an object of that specific items by using classes and heriting with the interface which can calculate sales tax and amount of that specific items
            // After calling the objects of the items I just simply add the items and display on the screen. This is an Console application. My another approac will be 
            // to use the List<> and for loops to display all the items. I hope you guys like that approach


            Shopping_Cart cart;
            // Books
            Console.WriteLine("Enter Book Price");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            decimal Tax_Rate = Convert.ToDecimal(Console.ReadLine());
            decimal Price = Convert.ToDecimal(Console.ReadLine());


            cart = new book(Price, Quantity, Tax_Rate);
            decimal Sum = cart.Calculate_Amount();
            decimal SalesTax = cart.SalesTax();

            //  Music CD
            Console.WriteLine("Enter Music CD Price");
            int Quantity1 = Convert.ToInt32(Console.ReadLine());
            decimal Tax_Rate1 = Convert.ToDecimal(Console.ReadLine());
            decimal Price1 = Convert.ToDecimal(Console.ReadLine());

            cart = new MusicCD(Price1, Quantity1, Tax_Rate1);
            decimal Sum2 = cart.Calculate_Amount();
            decimal SalesTax2 = cart.SalesTax();

            // Choclate
            Console.WriteLine("Enter Locally Manufactured Choclate Price");
            int Quantity2 = Convert.ToInt32(Console.ReadLine());
            decimal Tax_Rate2 = Convert.ToDecimal(Console.ReadLine());
            decimal Price2 = Convert.ToDecimal(Console.ReadLine());

            cart = new Choclate(Price2, Quantity2, Tax_Rate2);
            decimal Sum3 = cart.Calculate_Amount();
            decimal SalesTax3 = cart.SalesTax();

            //Imported Choclate

            Console.WriteLine("Enter Imported Choclate Price");
            int Quantity3 = Convert.ToInt32(Console.ReadLine());
            decimal Tax_Rate3 = Convert.ToDecimal(Console.ReadLine());
            decimal Price3 = Convert.ToDecimal(Console.ReadLine());

            cart = new importedChoclate(Price3, Quantity3, Tax_Rate3);
            decimal Sum4 = cart.Calculate_Amount();
            decimal SalesTax4 = cart.SalesTax();



            Console.WriteLine("Book Amount: {0}", Sum);
            Console.WriteLine("Music Amount: {0}", Sum2);
            Console.WriteLine("Choclate Amount: {0}", Sum3);
            Console.WriteLine("Imported Choclate Amount: {0}", Sum4);
            Console.WriteLine("Total Sales Tax is {0}", SalesTax + SalesTax2 + SalesTax3 + SalesTax4);
            Console.WriteLine("Total Amount is {0}", Sum + Sum2 + Sum3 + Sum4);


        }
    }
    interface Shopping_Cart
    {
        decimal Calculate_Amount(

        );
        decimal SalesTax();
    }
    class book : Shopping_Cart
    {
        decimal Price { get; set; }
        int Quantity { get; set; }
        decimal Tax_Rate { get; set; }
        decimal Total_Price { get; set; }
        decimal Net_Price { get; set; }
        public book(decimal Price,
         int Quantity,
         decimal Tax_Rate
       )
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.Tax_Rate = Tax_Rate;
        }
        public decimal Calculate_Amount()
        {
            Net_Price = Tax_Rate == 0 ? 0 : (Price * Quantity) * (Tax_Rate / 100);
            decimal sub_price = Price * Quantity;
            Total_Price = sub_price + Net_Price;
            return Total_Price;
        }
        public decimal SalesTax()
        {
            return Net_Price;
        }
    }
    class MusicCD : Shopping_Cart
    {
        decimal Price { get; set; }
        int Quantity { get; set; }
        decimal Tax_Rate { get; set; }
        decimal Total_Price { get; set; }
        public decimal Net_Price { get; set; }
        public MusicCD(decimal Price,
         int Quantity,
         decimal Tax_Rate
       )
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.Tax_Rate = Tax_Rate;
        }
        public decimal Calculate_Amount()
        {
            Net_Price = Tax_Rate == 0 ? Price * Quantity : (Price * Quantity) * (Tax_Rate / 100);
            decimal sub_price = Price * Quantity;
            Total_Price = sub_price + Net_Price;
            return Total_Price;
        }
        public decimal SalesTax()
        {
            return Net_Price;
        }
    }
    class Choclate : Shopping_Cart
    {
        decimal Price { get; set; }
        int Quantity { get; set; }
        decimal Tax_Rate { get; set; }
        decimal Total_Price { get; set; }
        public decimal Net_Price { get; set; }

        public Choclate(decimal Price,
         int Quantity,
         decimal Tax_Rate
       )
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.Tax_Rate = Tax_Rate;
        }
        public decimal Calculate_Amount()
        {
            Net_Price = Tax_Rate == 0 ? Price * Quantity : (Price * Quantity) * (Tax_Rate / 100);
            decimal sub_price = Price * Quantity;
            Total_Price = sub_price + Net_Price;
            return Total_Price;
        }
        public decimal SalesTax()
        {
            return Net_Price;
        }
    }
    class importedChoclate : Shopping_Cart
    {
        decimal Price { get; set; }
        int Quantity { get; set; }
        decimal Tax_Rate { get; set; }
        decimal Total_Price { get; set; }
        public decimal Net_Price { get; set; }
        //     public decimal importduty { get; set; }

        public importedChoclate(decimal Price,
         int Quantity,
         decimal Tax_Rate  //, decimal importedduty
       )
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.Tax_Rate = Tax_Rate;
            //        this.importduty = importedduty;
        }
        public decimal Calculate_Amount()
        {
            Net_Price = Tax_Rate == 0 ? Price * Quantity : (Price * Quantity) * ((Tax_Rate) / 100);
            decimal sub_price = Price * Quantity;
            Total_Price = sub_price + Net_Price;
            return Total_Price;
        }
        public decimal SalesTax()
        {
            return Net_Price;
        }
    }
}

