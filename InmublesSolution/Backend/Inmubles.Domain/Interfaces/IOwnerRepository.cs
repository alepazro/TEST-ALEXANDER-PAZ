using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;

namespace Inmubles.Domain.Interfaces
{
    public interface IOwnerRepository
    {
        Task<List<Owner>> GetAllOwnersAsync();
        Task<Owner?> GetOwnerByIdAsync(int id);
    }
}
