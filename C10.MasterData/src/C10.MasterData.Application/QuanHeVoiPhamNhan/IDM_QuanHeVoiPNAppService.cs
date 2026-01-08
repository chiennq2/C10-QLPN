using Abp.Application.Services;
using C10.MasterData.Domain.DanhMuc.DM_QuanHeVoiPN;
using C10.QuanHeVoiPhamNhan.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuanHeVoiPhamNhan
{
    public interface IDM_QuanHeVoiPNAppService : IAsyncCrudAppService<DM_QuanHeVoiPNDto, int, PageDM_QuanHeVoiPNResultDto, CreateDM_QuanHeVoiPNDto, DM_QuanHeVoiPNDto>
    {
    }
}
