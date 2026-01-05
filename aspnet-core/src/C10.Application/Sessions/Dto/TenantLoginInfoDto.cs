using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using C10.MultiTenancy;

namespace C10.Sessions.Dto;

[AutoMapFrom(typeof(Tenant))]
public class TenantLoginInfoDto : EntityDto
{
    public string TenancyName { get; set; }

    public string Name { get; set; }
}
