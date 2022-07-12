using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnCodeFirstApproach.Models;
using LearnCodeFirstApproach.Data;
using Microsoft.EntityFrameworkCore;


namespace LearnCodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAllBookDetails();
            ////AddBook();
            ////DeleteBook();
            ////UpdateBook();
            //AddCustomerAndOrder();
            //GetAllCustomerAndOrder_EagleLoading();
            //GetAllCustomerAndOrder_ExplicitLoading();
            //AddCustomerandOrder();
            //jointables();
            //dISCONNECTEDaRCHITECTURE();
            //jointables_sp();
            GetOrderDetails();

        }
    //    public static void AddBook()
    //    {
    //        var ctx = new BookContext();
    //        var b1 = new Book { BookID = 1, BookName = "Harry Potter", author = "JK Rowling", price =2000, BookAge = 5 };
    //        var b2 = new Book { BookID = 2, BookName = "Mahabhrata", author = "Vedavyasa", price = 20000, BookAge = 10000};
    //        var b3 = new Book { BookID = 3, BookName = "Ramayana", author = "Valmiki", price = 15000, BookAge = 15000 };
    //        var b4 = new Book { BookID = 4, BookName = "Ramacharita Manasa", author = "Kalidasa", price = 5000, BookAge = 1000 }; 
            
    //        ctx.Books.Add(b2); ctx.SaveChanges();
    //        ctx.Books.Add(b3); ctx.SaveChanges();
    //        ctx.Books.Add(b4);
    //        ctx.SaveChanges();
    //        var BookDetails = ctx.Books;
    //        foreach (var bk in BookDetails)
    //        {
    //            Console.WriteLine(bk.BookName + " " + bk.author + " " + bk.price);
    //        }
    //    }
    //    public static void DeleteBook()
    //    {
    //        var ctx = new BookContext();
    //        var deleteBook = ctx.Books.Where(x => x.BookName == "Harry Potter").SingleOrDefault();
    //        ctx.Remove(deleteBook);
    //        Console.WriteLine("Deleted");
    //        ctx.SaveChanges();
    //        var empDetails = ctx.Books;
    //        var BookDetails = ctx.Books;
    //        foreach (var bk in BookDetails)
    //        {
    //            Console.WriteLine(bk.BookName + " " + bk.author + " " + bk.price);
    //        }
    //    }
    //    public static void UpdateBook()
    //    {
    //        var ctx = new BookContext();
    //        var updateBook = ctx.Books.Where(x => x.BookID == 2).SingleOrDefault();
    //        updateBook.BookName = "Vyasa Mahabharata";
    //        ctx.Books.Update(updateBook);
    //        Console.WriteLine("Updated");
    //        ctx.SaveChanges();
    //        var BookDetails = ctx.Books;
    //        foreach (var bk in BookDetails)
    //        {
    //            Console.WriteLine(bk.BookName + " " + bk.author + " " + bk.price);
    //        }

    //    }

    //    public static void GetAllBookDetails()
    //    {
    //        var ctx = new BookContext();
    //        var BookDetails = ctx.Books;
    //        foreach (var bk in BookDetails)
    //        {
    //            Console.WriteLine(bk.BookName + " " + bk.author + " " + bk.price);
    //        }

    //    }
    //    //public static void AddCustomerAndOrder()
    //    //{
    //    //    var ctx = new BookContext();
    //    //    //Customer customer = new Customer();
    //    //    //customer.ID = 101;
    //    //    //customer.Name = "Akshay U";
    //    //    //customer.Age = 23;

    //    //    Order order=new Order();
    //    //    order.Order_ID = 1001;
    //    //    order.Amount = 4000;
    //    //    order.OrderDate = DateTime.Now;

    //    //    //List<Order> myorder = new List<Order>();
    //    //    //myorder.Add(order);
    //    //    //customer.Orders = myorder;

    //    //    //order.cust = customer;

    //    //    //order.cust = ctx.Customers.Where(x=>x.ID==1);
    //    //    try
    //    //    {
    //    //        //ctx.Customers.Add(customer);
    //    //        ctx.Orders.Add(order);
    //    //        ctx.SaveChanges();
    //    //        Console.WriteLine("Customer and order is added");

    //    //    }
    //    //    catch(Exception ex)
    //    //    {
    //    //        Console.WriteLine(ex.InnerException.ToString());
    //    //    }

    //    //}
    //    public static void AddCustomerandOrder()
    //    {
    //        var ctx = new BookContext();
    //        //var Customer = new Customer();
    //        //Customer.ID = 4;
    //        //Customer.Name = "sreedhar";
    //        //Customer.Age = 22;

    //        var order = new Order();
    //        order.Order_ID = 1110;
    //        order.OrderDate = DateTime.Now;
    //        order.Amount = 1000;

    //        //List<Order> myorders =new List<Order>();
    //        //myorders.Add(order);
    //        //Customer.Orders = myorders;

    //        //order.cust = Customer;

    //        order.cust = ctx.Customers.Where(a => a.ID == 1).SingleOrDefault();


    //        try
    //        {
    //            //ctx.Customers.Add(Customer);

    //            ctx.Orders.Add(order);
    //            ctx.SaveChanges();
    //            Console.WriteLine("Customer and order is created");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.InnerException.ToString());
    //        }
    //    }
    //    private static void GetAllCustomerAndOrder_EagleLoading()
    //    {
    //        var ctx =new BookContext();
    //        try
    //        {
    //            var customers = ctx.Customers.Include("Orders");
    //            foreach (var customer in customers)
    //            {
    //                Console.WriteLine(customer.Name);
    //                Console.WriteLine( "------>");
    //                foreach (var order in customer.Orders)
    //                {
    //                    Console.WriteLine(order.Amount.ToString() + " "+ order.Order_ID);
    //                }
    //                Console.WriteLine("----");
    //            }
    //        }
    //        catch(Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //    private static void GetAllCustomerAndOrder_ExplicitLoading()
    //    {
    //        var ctx = new BookContext();
    //        try
    //        {
    //            var customers = ctx.Customers;
    //            foreach (var customer in customers)
    //            {
    //                Console.WriteLine(customer.Name);
    //                Console.WriteLine("------>");
    //                ctx.Entry(customer).Collection(o => o.Orders).Load();
    //                foreach (var order in customer.Orders)
    //                {
    //                    Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
    //                }
    //                Console.WriteLine("----");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //    public static void jointables()
    //    {
    //        var ctx = new BookContext();
    //        ctx.Orders.Join(ctx.Customers, (o => o.cust.ID), (p => p.ID), (o, p) => new
    //        {
    //            CustomerID = p.ID,
    //            CustomerName=p.Name,
    //            CustomerAge=p.Age,
    //            OrderID = o.Order_ID,
    //            OrderPrice = o.Amount,
    //        }).ToList().ForEach(r =>
    //        {
    //            Console.WriteLine(r.CustomerID);
    //            Console.WriteLine(r.CustomerName);
    //            Console.WriteLine(r.CustomerAge);
    //            Console.WriteLine(r.OrderID);
    //            Console.WriteLine(r.OrderPrice);
    //        });
            

    ////        var joinedT = ctx.Customers.GroupJoin(ctx.Orders, u => u.ID, f => f.cust.ID, (u, f) =>
    ////         new
    ////{
    ////    Customer = u,
    ////    Order = f.Join(ctx.Customers, f1 => f1.Amount, u1 => u1.ID,
    ////        (f1, u1) => u1)
    ////         })
    ////.ToList();
    ////        foreach (var item in joinedT)
    ////        {
    ////            Console.WriteLine(item.Customer+" "+item.Order);
    ////        }
   


                
    //            //ctx.Customers.Add();

    //            //ctx.Orders.Add(order);
    //            //ctx.SaveChanges();
    //            Console.WriteLine("Customer and order is created");
            
    //    }
    //    public static void dISCONNECTEDaRCHITECTURE()
    //    {
    //        var ctx = new BookContext();
    //        var customer = ctx.Customers.Where(c => c.ID == 4).SingleOrDefault();
    //        ctx.Dispose();
    //        UpdateCustomerName(customer);
    //    }
    //    private static void UpdateCustomerName(Customer customer)
    //    {
    //        var ctx = new BookContext();
    //        customer.Name = "John";
    //        ctx.Update(customer);
    //        Console.WriteLine(ctx.Entry(customer).State.ToString());

    //        ////ctx.Attach(customer).State=EntityState.Modified;
    //        ctx.SaveChanges();
    //        Console.WriteLine("Console name is updated via disconnected architecture");
    //    }
    //    public static void jointables_sp()
    //    {
    //        var ctx = new BookContext();
    //        var Jcustomer = ctx.Customers.FromSqlRaw("OrderDetails");
    //        Console.WriteLine("Joined Successfully");
    //        ctx.SaveChanges();
    //    }
        public static void GetOrderDetails()
        {
                var ctx=new BookContext();

            try
            {
                List<JoinedTable> jointable = ctx.Set<JoinedTable>().FromSqlRaw("OrderDetails").ToList();
                foreach (var cust in jointable)
                {
                    Console.WriteLine(cust.Id + "  " + cust.Name + " " + cust.Order_Id);
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
            


