using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentValidation.Results;
using MvcCoreDemo.Application.Interfaces;
using MvcCoreDemo.Data.Context;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Service;
using MvcCoreDemo.Domain.Validation;

namespace MvcCoreDemo.Application
{
    public class OrderAppService : AppService<DemoContext>, IOrderAppService
    {
        private readonly IOrderService _service;

        public OrderAppService(IOrderService orderService)
        {
            _service = orderService;
        }

        public ValidationResult Create(Order order)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(order));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Order order)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(order));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Order order)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(order));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Order Get(Guid id, bool @readonly = false)
        {
            return _service.Get(id);
        }


        public IEnumerable<Order> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Order> Find(Expression<Func<Order, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}