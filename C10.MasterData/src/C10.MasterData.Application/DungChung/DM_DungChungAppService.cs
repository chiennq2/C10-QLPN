using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.DungChung.Dto;
using System;

namespace C10.MasterData.DungChung
{
    public class DM_DungChungAppService : AsyncCrudAppService<DM_DungChung, DM_DungChungDto, Guid, PagedDM_DungChungResultDto, CreateDM_DungChungDto, DM_DungChungDto>, IDM_DungChungAppService
    {
        public DM_DungChungAppService(IRepository<DM_DungChung, Guid> repository) : base(repository)
        {
        }
    }
}
