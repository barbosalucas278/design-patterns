using ProxyPattern.Core;
using System;
using System.Collections.Generic;

namespace ProxyPattern.Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository _realContext;
        public IList<Customer> GetAll()
        {
            if (_realContext is null) _realContext = new CustomerRepository(); // proxy virtual
            if (Session.CanGetAll) //proxy de seguridad
            {
                return _realContext.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void Save(Customer customer)
        {
            if (_realContext is null) _realContext = new CustomerRepository();
            if (Session.CanSave)
            {
                _realContext.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
