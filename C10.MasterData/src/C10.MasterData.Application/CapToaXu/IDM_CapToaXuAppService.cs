using Abp.Application.Services;
using C10.CapToaXu.Dto;
using System;

namespace C10.CapToaXu
{
    public interface IDM_CapToaXuAppService : IAsyncCrudAppService<DM_CapToaXuDto, int, PageDM_CapToaXuResultDto, CreateDM_CapToaXuDto, DM_CapToaXuDto>
    {
    }
}
