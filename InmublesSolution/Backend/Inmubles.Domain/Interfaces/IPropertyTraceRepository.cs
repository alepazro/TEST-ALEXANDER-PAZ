using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;

namespace Inmubles.Domain.Interfaces
{
    public interface IPropertyTraceRepository
    {
        Task<List<PropertyTrace>> GetAllAsync();
        Task<PropertyTrace?> GetByIdAsync(int id);
        Task AddAsync(PropertyTrace trace);
        Task UpdateAsync(PropertyTrace trace);
        Task DeleteAsync(int id);
    }
}
