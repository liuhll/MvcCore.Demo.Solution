﻿using FluentValidation.Results;

namespace MvcCoreDemo.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}
