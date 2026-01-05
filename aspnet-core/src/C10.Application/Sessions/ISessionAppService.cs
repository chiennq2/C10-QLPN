using Abp.Application.Services;
using C10.Sessions.Dto;
using System.Threading.Tasks;

namespace C10.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
