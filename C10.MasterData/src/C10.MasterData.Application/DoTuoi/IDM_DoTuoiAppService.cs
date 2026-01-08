using Abp.Application.Services;
using C10.DoTuoi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DoTuoi
{
    public interface IDM_DoTuoiAppService : IAsyncCrudAppService<DM_DoTuoiDto, int, PageDM_DoTuoiResultDto, CreateDM_DoTuoiDto, DM_DoTuoiDto>
    {
    }
}
