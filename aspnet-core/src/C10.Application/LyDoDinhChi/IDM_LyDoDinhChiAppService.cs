using Abp.Application.Services;
using C10.LyDoDinhChi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoDinhChi
{
    public interface IDM_LyDoDinhChiAppService : IAsyncCrudAppService<DM_LyDoDinhChiDto, int, PageDM_LyDoDinhChiResultDto, CreateDM_LyDoDinhChiDto, DM_LyDoDinhChiDto>
    {
    }
}
