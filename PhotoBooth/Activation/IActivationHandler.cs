using System.Threading.Tasks;

namespace PhotoBooth.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
