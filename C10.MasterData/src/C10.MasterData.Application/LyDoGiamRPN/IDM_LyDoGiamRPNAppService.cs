using Abp.Application.Services;
using C10.LyDoGiamRPN.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoGiamRPN
{
    public interface IDM_LyDoGiamRPNAppService : IAsyncCrudAppService<DM_LyDoGiamRPNDto, int, PageDM_LyDoGiamRPNResultDto, CreateDM_LyDoGiamRPNDto, DM_LyDoGiamRPNDto>
    {
    }
}
