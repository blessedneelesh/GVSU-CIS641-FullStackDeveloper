using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.Models.Enums;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Repository.Interface
{
    public interface IVendorRepository
    {
        Task<PagedList<VendorResponseDto>> GetAllVendors(VendorParameters vendorParameters);
        Task<VendorResponseDto?> GetVendorById(long id);
        Task<IEnumerable<VendorResponseDto>> GetActiveVendors(VendorType? type = null);
        Task<VendorResponseDto> AddVendor(VendorCreateDto vendor);
        Task<VendorResponseDto?> UpdateVendor(long id, VendorUpdateDto vendor);
        Task<bool> DeleteVendor(long id);
        Task<bool> IsVendorReferenced(long id);
    }
}
