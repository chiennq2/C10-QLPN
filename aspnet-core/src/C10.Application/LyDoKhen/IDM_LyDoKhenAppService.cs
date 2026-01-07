using Abp.Application.Services;
using C10.CapToaXu.Dto;
using C10.LyDoKhen.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhen
{
    public interface IDM_LyDoKhenAppService : IAsyncCrudAppService<DM_LyDoKhenDto, int, PageDM_LyDoKhenResultDto, CreateDM_LyDoKhenDto, DM_LyDoKhenDto>
    {
    }
}
