// SGetee https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
jaypal j = new jaypal();
Console.WriteLine("Hello,welcome to shoping app");

//testin puss
j.name();
j.mobileno();
j.productname();
j.quantity();
j.Getprice();
j.discount();
j.bill();

class jaypal
{


    public void name()
    {
        Console.WriteLine("enter your name");
         customername = Console.ReadLine();
       
 

    }
    public void productname()
    {
        Console.WriteLine("enter your product");
         productnamee = Console.ReadLine();
       // Console.WriteLine(productnamee);

    }

    public void mobileno()
    {
        Console.WriteLine("enter your mobile nember");
        mobilenumbar = Console.ReadLine();
     
    }
    public int Getprice()
    {
       
        Console.WriteLine(" enter product price");
        return
        Convert.ToInt32(Console.ReadLine());            
        

    }

    public void quantity()
    {
        Console.WriteLine("enter product quantity ");
        qty = Convert.ToInt16( Console.ReadLine());  
    }

    public int discount()
    {
      
       pricediscount = 10;
        return pricediscount;

    }

    public void bill()
    {

        Console.WriteLine("***********your bill and product detials");
        Console.WriteLine("your name : "+customername);
        Console.WriteLine("your mobilenumbar: "  + mobilenumbar);
        Console.WriteLine("your productname: " +productnamee);
        Console.WriteLine("cuantity :" +qty);
        Console.WriteLine("prices:" +GetPrice);
        Console.WriteLine( "discount:" +pricediscount);
        Console.WriteLine( "thakyou for shopping");
        
    }


    public string customername { get; set; }
    
    public string mobilenumbar { get; set; }

    public string productnamee {  get; set; }    
    public int GetPrice {  get; set; }    
    public int qty { get; set; }

    public int pricediscount { get; set; }   


}




























