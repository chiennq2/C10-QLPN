using Abp.Application.Services;
using C10.CapToaXu.Dto;
using C10.LyDoKhongXetGiam.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhongXetGiam
{
    public interface IDM_LyDoKhongXetGiamAppService : IAsyncCrudAppService<DM_LyDoKhongXetGiamDto, int, PageDM_LyDoKhongXetGiamResultDto, CreateDM_LyDoKhongXetGiamDto, DM_LyDoKhongXetGiamDto>
    {
    }
}
