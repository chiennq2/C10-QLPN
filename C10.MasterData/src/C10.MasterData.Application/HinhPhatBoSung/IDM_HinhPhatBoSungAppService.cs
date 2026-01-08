using Abp.Application.Services;
using C10.HinhPhatBoSung.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhPhatBoSung
{
    internal interface IDM_HinhPhatBoSungAppService : IAsyncCrudAppService<DM_HinhPhatBoSungDto, int, PageDM_HinhPhatBoSungResultDto, CreateDM_HinhPhatBoSungDto, DM_HinhPhatBoSungDto>
    {
    }
}
