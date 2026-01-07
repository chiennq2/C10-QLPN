using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_QuanHeVoiPN;
using C10.QuanHeVoiPhamNhan.Dto;

namespace C10.QuanHeVoiPhamNhan
{
    public class DM_QuanHeVoiPNAppService : AsyncCrudAppService<DM_QuanHeVoiPN, DM_QuanHeVoiPNDto, int, PageDM_QuanHeVoiPNResultDto, CreateDM_QuanHeVoiPNDto, DM_QuanHeVoiPNDto>, IDM_QuanHeVoiPNAppService
    {
        public DM_QuanHeVoiPNAppService(IRepository<DM_QuanHeVoiPN, int> repository) : base(repository)
        {
        }
    }
}
