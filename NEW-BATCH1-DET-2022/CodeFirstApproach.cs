using NEW_BATCH1_DET_2022.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW_BATCH1_DET_2022.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace NEW_BATCH1_DET_2022
{
    internal class CodeFirstApproach
    {
        static void Main(string[] args)
        {
            //AddNewBook();
            //DeleteBook();
            //Updatebook();
            //GetBookDetails();
            //AddnewCustomerAndOrder();
           // neworder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnarch();
            Console.ReadLine();
        }

        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 4;
            book.BookName = "jenkins";
            book.author = "roja";
            book.price = 1500;


            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("New book added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void DeleteBook()
        {
            var ctx = new BookContext();
            var books = ctx.Books.Where(x => x.BookID == 1).SingleOrDefault();

            try
            {
                ctx.Remove(books);
                ctx.SaveChanges();
                Console.WriteLine("Deleted succesfully");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void Updatebook()
        {

            var ctx = new BookContext();

            var Books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();
            
            try
            {
                Books.BookName = "rojaa0";
                Books.price = 2500;
                ctx.Update(Books);

                ctx.SaveChanges();

                Console.WriteLine("New book updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void GetBookDetails()
        {
            try
            {
                var ctx = new BookContext();
                var books = ctx.Books;

                foreach (var book in books)
                {
                    Console.WriteLine(book.BookID + "  " + book.BookName + "  " + book.author + "  " + book.price);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void AddnewCustomerAndOrder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "sheela";
            customer.Age = 45;

            Order ord = new Order();
            ord.Order_ID= 100;
            ord.Amount = 2500;
            ord.OrderDate=DateTime.Now;


            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();  
                Console.WriteLine("Customer and order is created");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
           
        }

        private static void neworder()
        {
            var ctx = new BookContext();
            Order ord = new Order();
            ord.Order_ID = 100;
            ord.Amount = 4500;
            ord.OrderDate = DateTime.Now;



            var neword = ctx.Customers.Where(o => o.ID == 1).SingleOrDefault();

            ord.cust = neword;

            try
            {
                ctx.Orders.Add(ord);


                ctx.SaveChanges();
                Console.WriteLine("New order added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
            private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);                   

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Disconnarch()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);
        }
        private static void UpdateCustomerName(Customer customer)
        {
                var ctx = new BookContext();
            customer.Name = "Mike";
                Console.WriteLine(ctx.Entry(customer).State.ToString());
                //ctx.Update<Customer>(customer);
                //OR
                ctx.Update(customer);
                //OR
                //ctx.Customers.Update(customer);
                //OR

                //  ctx.Attach(customer).State = EntityState.Modified;
                ctx.SaveChanges();
                Console.WriteLine("customer name is updated via disconnected mode");

        }

        
    }
}
