using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.BenhTat.Dto;
using C10.Core.DanhMuc.DM_BenhTat;

namespace C10.BenhTat
{
    public class DM_BenhTatAppService : AsyncCrudAppService<DM_BenhTat, DM_BenhTatDto, int, PagedDM_BenhTatResultDto, CreateDM_BenhTatDto, DM_BenhTatDto>, IDM_BenhTatAppService
    {
        public DM_BenhTatAppService(IRepository<DM_BenhTat, int> repository) : base(repository)
        {
        }
    }
}
