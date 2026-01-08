using Abp.Application.Services;
using C10.LoaiQDTDC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiQDTDC
{
    public interface IDM_LoaiQDTDCAppService : IAsyncCrudAppService<DM_LoaiQDTDCDto, int, PageDM_LoaiQDTDCResultDto, CreateDM_LoaiQDTDCDto, DM_LoaiQDTDCDto>
    {
    }
}
