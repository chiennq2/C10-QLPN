using Abp.Application.Services;
using C10.LoaiQuyetDinhTrichXuat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiQuyetDinhTrichXuat
{
    public interface IDM_LoaiQuyetDinhTrichXuatAppService : IAsyncCrudAppService<DM_LoaiQuyetDinhTrichXuatDto, int, PageDM_LoaiQuyetDinhTrichXuatResultDto, CreateDM_LoaiQuyetDinhTrichXuatDto, DM_LoaiQuyetDinhTrichXuatDto>
    {
    }
}
