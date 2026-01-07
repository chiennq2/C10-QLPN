using Abp.Application.Services;
using C10.HinhThucKyLuat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucKyLuat
{
    public interface IDM_HinhThucKyLuatAppService : IAsyncCrudAppService<DM_HinhThucKyLuatDto, int, PageDM_HinhThucKyLuatResultDto, CreateDM_HinhThucKyLuatDto, DM_HinhThucKyLuatDto>
    {
    }
}
