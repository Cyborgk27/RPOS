﻿using Microsoft.EntityFrameworkCore;
using RPOS.Domain.Entities;
using RPOS.Infrastructure.Commons.Bases.Request;
using RPOS.Infrastructure.Helpers;
using RPOS.Infrastructure.Persistences.Contexts;
using RPOS.Infrastructure.Persistences.Interfaces;
using RPOS.Utilities.Static;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace RPOS.Infrastructure.Persistences.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly RPOSContext _context;
        private readonly DbSet<T> _entity;

        public GenericRepository(RPOSContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync() 
        {
            var getAll = await _entity
                .Where( x => 
                x.State.Equals((int)StateTypes.Active) &&
                x.AuditDeleteUser == null &&
                x.AuditDeleteDate == null)
                .AsNoTracking()
                .ToListAsync();

            return getAll;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var getById = await _entity!
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            return getById!;
        }

        public async Task<bool> RegisterAsync(T entity)
        {
            entity.AuditCreateUser = 1;
            entity.AuditCreateDate = DateTime.Now;

            await _context.AddAsync(entity);

            var recordAffected = await _context.SaveChangesAsync();
            return recordAffected > 0;
        }

        public async Task<bool> EditAsync(T entity)
        {
            entity.AuditUpdateUser = 1;
            entity.AuditUpdateDate = DateTime.Now;

            _context.Update(entity);
            _context.Entry(entity).Property(x 
                => x.AuditCreateUser).IsModified = false;
            _context.Entry(entity).Property(x 
                => x.AuditCreateDate).IsModified = false;

            var recordAffected = await _context.SaveChangesAsync();
            return recordAffected > 0;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            T entity = await GetByIdAsync(id);

            entity!.AuditDeleteUser = 1;
            entity.AuditDeleteDate = DateTime.Now;
            entity!.State = (int)StateTypes.Inactive;

            _context.Update(entity);

            var recordAffected = await _context.SaveChangesAsync();
            return recordAffected > 0;
        }
        public IQueryable<T> GetEntityQuery(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = _entity;

            if (filter != null) query = query.Where(filter);

            return query;
        }

        public IQueryable<TDTO> Ordering<TDTO>(BasePaginationRequest request,
            IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class
        {
            IQueryable<TDTO> queryDto = request.Order == "desc" ?
                queryable.OrderBy($"{request.Sort} descending") :
                queryable.OrderBy($"{request.Sort} ascending");

            if (pagination) queryDto = queryDto.Paginate(request);

            return queryDto;

        }
    }
}