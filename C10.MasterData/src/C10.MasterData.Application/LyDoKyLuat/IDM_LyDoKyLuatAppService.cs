using Abp.Application.Services;
using C10.CapToaXu.Dto;
using C10.LyDoKyLuat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKyLuat
{
    public interface IDM_LyDoKyLuatAppService : IAsyncCrudAppService<DM_LyDoKyLuatDto, int, PageDM_LyDoKyLuatResultDto, CreateDM_LyDoKyLuatDto, DM_LyDoKyLuatDto>
    {

    }
}
