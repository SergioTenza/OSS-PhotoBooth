using System.Threading.Tasks;

namespace PhotoBooth.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
