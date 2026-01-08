using Abp.Application.Services;
using C10.HinhThucChon.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucChon
{
    public interface IDM_HinhThucChonAppService : IAsyncCrudAppService<DM_HinhThucChonDto, int, PageDM_HinhThucChonResultDto, CreateDM_HinhThucChonDto, DM_HinhThucChonDto>
    {
    }
}
