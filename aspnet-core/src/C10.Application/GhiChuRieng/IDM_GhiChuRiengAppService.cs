using Abp.Application.Services;
using C10.GhiChuRieng.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GhiChuRieng
{
    internal interface IDM_GhiChuRiengAppService : IAsyncCrudAppService<DM_GhiChuRiengDto, int, PageDM_GhiChuRiengResultDto, CreateDM_GhiChuRiengDto, DM_GhiChuRiengDto>
    {
    }
}
