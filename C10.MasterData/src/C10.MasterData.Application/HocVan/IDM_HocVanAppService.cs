using Abp.Application.Services;
using C10.HocVan.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HocVan
{
    public interface IDM_HocVanAppService : IAsyncCrudAppService<DM_HocVanDto, int, PageDM_HocVanResultDto, CreateDM_HocVanDto, DM_HocVanDto>
    {
    }
}
