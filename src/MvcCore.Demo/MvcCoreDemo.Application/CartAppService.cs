using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentValidation.Results;
using MvcCoreDemo.Application.Interfaces;
using MvcCoreDemo.Data.Context;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Service;
using MvcCoreDemo.Domain.Validation;
using MvcCoreDemo.Domain.Services.Helpers;

namespace MvcCoreDemo.Application
{
    public class CartAppService : AppService<DemoContext>, ICartAppService
    {
        private readonly ICartService _service;

        public CartAppService(ICartService cartService)
        {
            _service = cartService;
        }

        public ValidationResult Create(Cart cart)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(cart));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Cart cart)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(cart));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(IEnumerable<Cart> carts)
        {
            BeginTransaction();
            carts.ForEach(cart => ValidationResult.Add(_service.Update(cart)));
            if(ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Cart cart)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(cart));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(IEnumerable<Cart> carts)
        {
            BeginTransaction();
            carts.ForEach(cart => ValidationResult.Add(_service.Delete(cart)));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Cart Get(Guid id, bool @readonly = false)
        {
            return _service.Get(id);
        }

        public IEnumerable<Cart> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Cart> Find(Expression<Func<Cart, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}