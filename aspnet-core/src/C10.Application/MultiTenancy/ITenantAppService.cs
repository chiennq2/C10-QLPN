using Abp.Application.Services;
using C10.MultiTenancy.Dto;

namespace C10.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

