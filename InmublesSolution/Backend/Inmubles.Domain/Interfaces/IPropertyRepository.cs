using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;
using Inmubles.Domain.ModelsResult;

namespace Inmubles.Domain.Interfaces
{   
    public interface IPropertyRepository
    {
        Task<List<Property>> GetAllPropertysAsync();
        Task<Property?> GetPropertyByIdAsync(int id);
        Task<List<PropertyWithImagesResult?>> GetAllPropertiesWithImagesAsync();
    }
}
