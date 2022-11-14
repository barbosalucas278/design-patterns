using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Core
{
    public interface IRepository
    {
        IList<Customer> GetAll();
        void Save(Customer customer);
    }
}
