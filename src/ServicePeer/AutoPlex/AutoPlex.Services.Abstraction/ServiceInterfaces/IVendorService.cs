using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.Models.Enums;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public enum DeleteVendorResult
    {
        Deleted,
        NotFound,
        Referenced
    }

    public interface IVendorService
    {
        Task<PagedList<VendorResponseDto>> GetAllVendors(VendorParameters vendorParameters);
        Task<VendorResponseDto?> GetVendorById(long id);
        Task<IEnumerable<VendorResponseDto>> GetActiveVendors(VendorType? type = null);
        Task<VendorResponseDto> AddVendor(VendorCreateDto vendor);
        Task<VendorResponseDto?> UpdateVendor(long id, VendorUpdateDto vendor);
        Task<DeleteVendorResult> DeleteVendor(long id);
    }
}
