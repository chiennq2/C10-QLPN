using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.BenhTat.Dto;
using C10.Core.DanhMuc.DM_XuLyBat;
using C10.XuLyBat.Dto;

namespace C10.XuLyBat
{
    public class DM_XuLyBatAppService : AsyncCrudAppService<DM_XuLyBat, DM_XuLyBatDto, int, PageDM_XuLyBatResultDto, CreateDM_XuLyBatDto, DM_XuLyBatDto>, IDM_XuLyBatAppService
    {
        public DM_XuLyBatAppService(IRepository<DM_XuLyBat, int> repository) : base(repository)
        {
        }
    }
}
