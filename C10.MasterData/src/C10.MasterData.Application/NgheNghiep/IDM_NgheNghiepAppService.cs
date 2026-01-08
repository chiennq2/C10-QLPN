using Abp.Application.Services;
using C10.NgheNghiep.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.NgheNghiep
{
    public interface IDM_NgheNghiepAppService : IAsyncCrudAppService<DM_NgheNghiepDto, int, PageDM_NgheNghiepResultDto, CreateDM_NgheNghiepDto, DM_NgheNghiepDto>
    {
    }
}
