using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentValidation.Results;
using MvcCoreDemo.Application;
using MvcCoreDemo.Application.Interfaces;
using MvcCoreDemo.Data.Context;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Service;
using MvcCoreDemo.Domain.Validation;

namespace MvcMusicStore.Application
{
    public class OrderDetailAppService : AppService<DemoContext>, IOrderDetailAppService
    {
        private readonly IOrderDetailService _service;

        public OrderDetailAppService(IOrderDetailService orderDetailService)
        {
            _service = orderDetailService;
        }

        public ValidationResult Create(OrderDetail orderDetail)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(orderDetail));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(OrderDetail orderDetail)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(orderDetail));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(OrderDetail orderDetail)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(orderDetail));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public OrderDetail Get(Guid id, bool @readonly = false)
        {
            return _service.Get(id);
        }

        public IEnumerable<OrderDetail> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<OrderDetail> Find(Expression<Func<OrderDetail, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}