using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Repository.Interface
{
    public interface IPartRepository
    {
        Task<PagedList<PartResponseDto>> GetAllParts(PartParameters parameters);
        Task<PartResponseDto?> GetPartById(long id);
        Task<PartResponseDto> AddPart(PartCreateDto part);
        Task<PartResponseDto?> UpdatePart(long id, PartUpdateDto part);
    }
}
