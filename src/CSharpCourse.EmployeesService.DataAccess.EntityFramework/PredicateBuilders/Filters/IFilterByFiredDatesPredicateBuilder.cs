﻿using System;
using System.Linq.Expressions;
using CSharpCourse.EmployeesService.DataAccess.PredicateBuilders.Base;

namespace CSharpCourse.EmployeesService.DataAccess.PredicateBuilders.Filters
{
    public interface IFilterByFiredDatesPredicateBuilder<TEntity, in TFilterRequest> :
        IPredicateBuilder<TEntity>
        where TEntity : class
        where TFilterRequest : class
    {
        Expression<Func<TEntity, bool>> FilterByFiredDates(TFilterRequest filterRequest);
    }
}
