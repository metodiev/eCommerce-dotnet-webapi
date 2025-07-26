using System;
using System.Collections.Generic;
using System.Text;

namespace SearchService.Services.Interfaces
{
    public interface ISearchService
    {
        Task<IList<object>> GetFilteredProductsAsync(IList<string> keywords, IList<string> filters);
        Task HealthCheckAsync();
    }
}
