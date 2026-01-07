using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_DoTuoi;
using C10.DoTuoi.Dto;

namespace C10.DoTuoi
{
    public class DM_DoTuoiAppService : AsyncCrudAppService<DM_DoTuoi, DM_DoTuoiDto, int, PageDM_DoTuoiResultDto, CreateDM_DoTuoiDto, DM_DoTuoiDto>, IDM_DoTuoiAppService
    {
        public DM_DoTuoiAppService(IRepository<DM_DoTuoi, int> repository) : base(repository) { }
    }
}
