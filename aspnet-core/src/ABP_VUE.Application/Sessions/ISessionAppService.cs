using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_VUE.Sessions.Dto;

namespace ABP_VUE.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
