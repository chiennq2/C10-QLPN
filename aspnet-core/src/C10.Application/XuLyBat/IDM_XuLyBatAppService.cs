using Abp.Application.Services;
using C10.XuLyBat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XuLyBat
{
    public interface IDM_XuLyBatAppService : IAsyncCrudAppService<DM_XuLyBatDto, int, PageDM_XuLyBatResultDto, CreateDM_XuLyBatDto, DM_XuLyBatDto>
    {
    }
}
