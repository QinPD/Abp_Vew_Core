using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABP_VUE.MultiTenancy;

namespace ABP_VUE.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
