using ReturnService.Repositories.Interfaces;
using ReturnService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ReturnService.Services
{
    public class ReturnService : IReturnService
    {
        private readonly IReturnRepository _returnRepository;
        public ReturnService(IReturnRepository returnRepository)
        {
            _returnRepository = returnRepository;
        }
        public async Task<bool> ApproveReturnRequestAsync(string returnId)
        {
            return await _returnRepository.ApproveReturnRequestAsync(returnId);
        }

        public async Task<bool> CancelReturnRequestAsync(string returnId)
        {
           return await _returnRepository.CancelReturnRequestAsync(returnId);
        }

        public async Task<bool> CreateReturnRequestAsync(object returnRequest)
        {
            return await _returnRepository.CreateReturnRequestAsync(returnRequest);
        }

        public async Task<List<object>> GetAllUserReturnRequestsByUserIdAsync(string userId)
        {
            return await _returnRepository.GetAllUserReturnRequestsByUserIdAsync(userId);
        }

        public async Task<object> GetReturnRequestByIdAsync(string returnId)
        {
            return await _returnRepository.GetReturnRequestByIdAsync(returnId);
        }

        public async Task<List<string>> GetReturnRequestReasonsAsync()
        {
            return await _returnRepository.GetReturnRequestReasonsAsync();
        }

        public async Task<string> GetReturnRequestStatusAsync(string returnId)
        {
            return await _returnRepository.GetReturnRequestStatusAsync(returnId);
        }

        public async Task<string> HealthCheckAsync()
        {
            return await _returnRepository.HealthCheckAsync();
        }

        public async Task<bool> RejectReturnRequestAsync(string returnId)
        {
            return await _returnRepository.RejectReturnRequestAsync(returnId);
        }

        public async Task<bool> UploadReturnRequestEvidenceAsync(string returnId, List<Blob> requestEvidence)
        {
            return await _returnRepository.UploadReturnRequestEvidenceAsync(returnId, requestEvidence);
        }
    }
}
