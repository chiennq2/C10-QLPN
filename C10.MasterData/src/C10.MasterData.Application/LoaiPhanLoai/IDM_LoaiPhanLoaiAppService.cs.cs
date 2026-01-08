using Abp.Application.Services;
using C10.LoaiPhanLoai.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiPhanLoai
{
    public interface IDM_LoaiPhanLoaiAppService : IAsyncCrudAppService<DM_LoaiPhanLoaiDto, int, PageDM_LoaiPhanLoaiResultDto, CreateDM_LoaiPhanLoaiDto, DM_LoaiPhanLoaiDto>
    {
    }
}
