using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ReturnService.Repositories.Interfaces
{
    public interface IReturnRepository
    {
        Task<bool> CreateReturnRequestAsync(object returnRequest);
        Task<object> GetReturnRequestByIdAsync(string returnId);
        Task<List<object>> GetAllUserReturnRequestsByUserIdAsync(string userId);
        Task<bool> CancelReturnRequestAsync(string returnId);
        Task<bool> ApproveReturnRequestAsync(string returnId);
        Task<bool> RejectReturnRequestAsync(string returnId);
        Task<string> GetReturnRequestStatusAsync(string returnId);
        Task<bool> UploadReturnRequestEvidenceAsync(string returnId, List<Blob> requestEvidence);
        Task<List<string>> GetReturnRequestReasonsAsync();
        Task<string> HealthCheckAsync();
    }
}
