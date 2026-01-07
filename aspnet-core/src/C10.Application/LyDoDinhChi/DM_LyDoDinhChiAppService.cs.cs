using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_LyDoDinhChi;
using C10.LyDoDinhChi.Dto;

namespace C10.LyDoDinhChi
{
    public class DM_LyDoDinhChiAppService : AsyncCrudAppService<DM_LyDoDinhChi, DM_LyDoDinhChiDto, int, PageDM_LyDoDinhChiResultDto, CreateDM_LyDoDinhChiDto, DM_LyDoDinhChiDto>, IDM_LyDoDinhChiAppService
    {
        public DM_LyDoDinhChiAppService(IRepository<DM_LyDoDinhChi, int> repository) : base(repository)
        {
        }
    }
}
