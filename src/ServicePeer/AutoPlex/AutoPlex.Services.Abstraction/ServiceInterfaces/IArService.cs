using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface IArService
    {
        Task<PagedList<ArAgingDto>> GetAllAr(ArAgingParameters parameters);
        Task<ArDetailDto?> GetArById(long id);
    }
}
