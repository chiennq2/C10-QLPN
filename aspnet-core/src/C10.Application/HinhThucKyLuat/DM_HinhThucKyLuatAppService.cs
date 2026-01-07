using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_HinhThucKyLuat;
using C10.HinhThucKyLuat.Dto;

namespace C10.HinhThucKyLuat
{
    public class DM_HinhThucKyLuatAppService : AsyncCrudAppService<DM_HinhThucKyLuat, DM_HinhThucKyLuatDto, int, PageDM_HinhThucKyLuatResultDto, CreateDM_HinhThucKyLuatDto, DM_HinhThucKyLuatDto>, IDM_HinhThucKyLuatAppService
    {
        public DM_HinhThucKyLuatAppService(IRepository<DM_HinhThucKyLuat, int> repository) : base(repository)
        {
        }
    }
}
