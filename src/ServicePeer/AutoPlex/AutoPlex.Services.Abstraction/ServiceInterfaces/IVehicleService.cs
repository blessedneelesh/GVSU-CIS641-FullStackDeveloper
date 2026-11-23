using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface IVehicleService
    {
        Task<VehicleResponseDto> AddVehicle(VehicleCreateDto vehicle);
        Task<PagedList<VehicleResponseDto>> GetAllVehicles(VehicleParameters parameters);
        Task<VehicleResponseDto?> GetVehicleById(long id);
    }
}
