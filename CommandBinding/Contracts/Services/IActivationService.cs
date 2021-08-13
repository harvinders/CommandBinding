using System.Threading.Tasks;

namespace CommandBinding.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
