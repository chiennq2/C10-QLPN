using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.CapToaXu;
using C10.CapToaXu.Dto;
using C10.Domain.DanhMuc.DM_CapToaXu;
using C10.Core.DanhMuc.DM_LyDoKhongXetGiam;
using C10.LyDoKhongXetGiam.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhongXetGiam
{
    public class DM_LyDoKhongXetGiamAppService : AsyncCrudAppService<DM_LyDoKhongXetGiam, DM_LyDoKhongXetGiamDto, int, PageDM_LyDoKhongXetGiamResultDto, CreateDM_LyDoKhongXetGiamDto, DM_LyDoKhongXetGiamDto>, IDM_LyDoKhongXetGiamAppService
    {
        public DM_LyDoKhongXetGiamAppService(IRepository<DM_LyDoKhongXetGiam, int> repository) : base(repository)
        {
        }
    }
}
