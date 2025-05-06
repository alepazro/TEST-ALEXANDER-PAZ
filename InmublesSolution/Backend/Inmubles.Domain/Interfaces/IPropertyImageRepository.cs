using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;

namespace Inmubles.Domain.Interfaces
{
    public interface IPropertyImageRepository
    {
        Task<List<PropertyImage>> GetAllPropertyImageAsync();
        Task<PropertyImage?> GetPropertyImageByIdAsync(int id);
    }
}
