using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Interfaces.Validation;
using MvcCoreDemo.Domain.Validation;

namespace MvcCoreDemo.Domain.Entities.Model
{
    public class Order : AggregateRoot, ISelfValidation
    {
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public ValidationResult ValidationResult { get; }
        public bool IsValid { get; }
    }
}
