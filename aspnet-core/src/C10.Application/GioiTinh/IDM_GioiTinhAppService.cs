using Abp.Application.Services;
using C10.GioiTinh.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GioiTinh
{
    public interface IDM_GioiTinhAppService : IAsyncCrudAppService<DM_GioiTinhDto, int, PageDM_GioiTinhResultDto, CreateDM_GioiTinhDto, DM_GioiTinhDto>
    {
    }
}
