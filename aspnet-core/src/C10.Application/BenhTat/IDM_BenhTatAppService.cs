using Abp.Application.Services;
using C10.BenhTat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.BenhTat
{
    public interface IDM_BenhTatAppService : IAsyncCrudAppService<DM_BenhTatDto, int, PagedDM_BenhTatResultDto, CreateDM_BenhTatDto, DM_BenhTatDto>
    {
    }
}
