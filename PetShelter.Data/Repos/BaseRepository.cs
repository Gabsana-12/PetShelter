using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    public abstract class BaseRepository<T, TModel> : IBaseRepository<TModel>, IDisposable
        where T : BaseEntity
        where TModel : BaseModel
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        protected readonly IMapper mapper;
        private bool disposedValue;

        public virtual TModel MapToModel(T entity)
        {
            return mapper.Map<TModel>(entity);
        }

        public virtual T MapToEntity(TModel model)
        {
            return mapper.Map<T>(model);
        }

        public virtual IEnumerable<TModel> MapToEnumerableOfModel(IEnumerable<T> entities)
        {
            return mapper.Map<IEnumerable<TModel>>(entities);
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return this.MapToEnumerableOfModel(await _dbSet.ToListAsync());
        }
        
        public async Task<TModel> GetByAsync(int id)
        {
            var user = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            return this.MapToModel(user);
        }

        public async Task CreateAsync(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            try
            {
                var entity = this.MapToEntity(model);
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch(SqlException ex)
            {
                await Console.Out.WriteLineAsync($"The system threw new an sql exception trying to create {nameof(model)} : {ex.Message}");
            }
            catch(Exception ex)
            {
                await Console.Out.WriteLineAsync($"The system thew a non-sql exception trying to create {nameof(model)} : {ex.Message}");
            }
        }

        public async Task UpdateAsync(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            try
            {
                var entity = this._dbSet.FindAsync(model.Id);
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                _context.Entry(entity).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
            }
            catch(SqlException ex)
            {
                await Console.Out.WriteLineAsync($"The system threw new an sql exception trying to update {nameof(model)} : {ex.Message}");
            }
            catch(Exception ex)
            {
                await Console.Out.WriteLineAsync($"The system threw new a non-sql exception trying to update {nameof(model)} : {ex.Message}");
            }
            
        }

        public async Task TaskAsync(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            if (model.Id != 0)
                await UpdateAsync(model);
            else
                await CreateAsync(model);
        }
    }
}
