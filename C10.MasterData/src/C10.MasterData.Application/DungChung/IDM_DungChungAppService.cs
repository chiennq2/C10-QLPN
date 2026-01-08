using Abp.Application.Services;
using C10.MasterData.DungChung.Dto;
using System;

namespace C10.MasterData.DungChung
{
    public interface IDM_DungChungAppService : IAsyncCrudAppService<DM_DungChungDto, Guid, PagedDM_DungChungResultDto, CreateDM_DungChungDto, DM_DungChungDto>
    {
    }
}
