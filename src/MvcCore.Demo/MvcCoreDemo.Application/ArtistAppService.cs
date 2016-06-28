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
    public class ArtistAppService : AppService<DemoContext>, IArtistAppService
    {
        private readonly IArtistService _service;

        public ArtistAppService(IArtistService artistService)
        {
            _service = artistService;
        }

        public ValidationResult Create(Artist artist)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Add(artist));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Update(Artist artist)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Update(artist));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public ValidationResult Remove(Artist artist)
        {
            BeginTransaction();
            ValidationResult.Add(_service.Delete(artist));
            if (ValidationResult.IsValid) Commit();

            return ValidationResult;
        }

        public Artist Get(Guid id, bool @readonly = false)
        {
            return _service.Get(id);
        }

        public IEnumerable<Artist> All(bool @readonly = false)
        {
            return _service.All(@readonly);
        }

        public IEnumerable<Artist> Find(Expression<Func<Artist, bool>> predicate, bool @readonly = false)
        {
            return _service.Find(predicate, @readonly);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}