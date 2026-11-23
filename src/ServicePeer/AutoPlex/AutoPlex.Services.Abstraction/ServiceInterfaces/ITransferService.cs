using AutoPlex.Repository.Models.Dto;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface ITransferService
    {
        Task<TransferResponseDto> CreateTransfer(CreateTransferRequest request);
    }
}
