using Abp.Application.Services;
using ABP_VUE.MultiTenancy.Dto;

namespace ABP_VUE.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

