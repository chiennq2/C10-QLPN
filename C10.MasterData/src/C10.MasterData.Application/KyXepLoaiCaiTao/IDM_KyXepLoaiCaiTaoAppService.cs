using Abp.Application.Services;
using C10.CapToaXu.Dto;
using C10.XepLoaiCaiTao.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XepLoaiCaiTao
{
    public interface IDM_KyXepLoaiCaiTaoAppService : IAsyncCrudAppService<DM_KyXepLoaiCaiTaoDto, int, PageDM_KyXepLoaiCaiTaoResultDto, CreateDM_KyXepLoaiCaiTaoDto, DM_KyXepLoaiCaiTaoDto>
    {
    }
}
