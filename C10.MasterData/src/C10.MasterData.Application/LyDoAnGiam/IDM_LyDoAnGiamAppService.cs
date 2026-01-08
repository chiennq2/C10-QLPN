using Abp.Application.Services;
using C10.LyDoAnGiam.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoAnGiam
{
    public interface IDM_LyDoAnGiamAppService : IAsyncCrudAppService<DM_LyDoAnGiamDto, int, PageDM_LyDoAnGiamResultDto, CreateDM_LyDoAnGiamDto, DM_LyDoAnGiamDto>
    {
    }
}
