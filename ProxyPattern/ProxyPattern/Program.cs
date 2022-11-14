using ProxyPattern.Core;
using ProxyPattern.Proxy;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Session.CanSave = true;
                Session.CanGetAll = true;
                IRepository repository = new CustomerRepositoryProxy();

                Customer c1 = new Customer("Customer 1");
                Customer c2 = new Customer("Customer 2");

                repository.Save(c1);
                repository.Save(c2);
                foreach (Customer customer in repository.GetAll())
                {
                    Console.WriteLine($"{customer.Nombre}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
