using ReturnService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ReturnService.Repositories
{
    public class ReturnRepositories : IReturnRepository
    {
        public Task<bool> ApproveReturnRequestAsync(string returnId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelReturnRequestAsync(string returnId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateReturnRequestAsync(object returnRequest)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAllUserReturnRequestsByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetReturnRequestByIdAsync(string returnId)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetReturnRequestReasonsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetReturnRequestStatusAsync(string returnId)
        {
            throw new NotImplementedException();
        }

        public Task<string> HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RejectReturnRequestAsync(string returnId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UploadReturnRequestEvidenceAsync(string returnId, List<Blob> requestEvidence)
        {
            throw new NotImplementedException();
        }
    }
}
