using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.EmployeesService.Domain.Models;
using CSharpCourse.EmployeesService.Domain.Root;

namespace CSharpCourse.EmployeesService.Domain.Contracts
{
    public interface IRepository<TEntity, TKey>
        where TEntity : Entity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Create new entry in store
        /// </summary>
        /// <param name="entity">Entry to add</param>
        /// <param name="cancellationToken">Token for cancellation operation.</param>
        /// <returns>New identifier of entry</returns>
        Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity to Update</param>
        /// <param name="cancellationToken">Token for cancellation operation.</param>
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity">Entity to Delete</param>
        /// <param name="cancellationToken">Token for cancellation operation.</param>
        /// <returns></returns>
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <param name="cancellationToken">Token for cancellation operation.</param>
        /// <returns>Collection of entities</returns>
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id">Identifier of entity</param>
        /// <param name="cancellationToken">Token for cancellation operation.</param>
        /// <returns>Information about entity</returns>
        Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken);

        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="ids">Identifier of entity</param>
        /// <param name="cancellationToken">Token for cancellation operation.</param>
        /// <returns>Information about entity</returns>
        Task<List<TEntity>> GetByIdsAsync(IReadOnlyCollection<TKey> ids, CancellationToken cancellationToken);
    }
}
