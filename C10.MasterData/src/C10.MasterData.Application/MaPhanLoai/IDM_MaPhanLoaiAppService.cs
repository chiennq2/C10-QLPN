using Abp.Application.Services;
using C10.MaPhanLoai.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MaPhanLoai
{
    public interface IDM_MaPhanLoaiAppService : IAsyncCrudAppService<DM_MaPhanLoaiDto, int, PageDM_MaPhanLoaiResultDto, CreateDM_MaPhanLoaiDto, DM_MaPhanLoaiDto>
    {
    }
}
