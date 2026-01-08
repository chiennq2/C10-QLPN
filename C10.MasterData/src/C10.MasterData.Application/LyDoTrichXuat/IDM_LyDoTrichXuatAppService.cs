using Abp.Application.Services;
using C10.LyDoKyLuat.Dto;
using C10.LyDoTrichXuat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoTrichXuat
{
    public interface IDM_LyDoTrichXuatAppService : IAsyncCrudAppService<DM_LyDoTrichXuatDto, int, PageDM_LyDoTrichXuatResultDto, CreateDM_LyDoTrichXuatDto, DM_LyDoTrichXuatDto>
    {
    }
}
