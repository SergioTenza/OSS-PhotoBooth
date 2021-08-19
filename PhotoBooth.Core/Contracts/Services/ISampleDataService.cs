using System.Collections.Generic;
using System.Threading.Tasks;

using PhotoBooth.Core.Models;

namespace PhotoBooth.Core.Contracts.Services
{
    // Remove this class once your pages/features are using your data.
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();

        Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
    }
}
