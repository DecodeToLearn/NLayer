using System;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Repository.UnitOfWork
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWorks(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

