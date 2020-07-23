using Abp.Application.Services.Dto;

namespace ABP_VUE.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

