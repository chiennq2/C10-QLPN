using Abp.Application.Services;
using C10.LoaiQDTDT.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiQDTDT
{
    public interface IDM_LoaiQDTDTAppService : IAsyncCrudAppService<DM_LoaiQDTDTDto, int, PageDM_LoaiQDTDTResultDto, CreateDM_LoaiQDTDTDto, DM_LoaiQDTDTDto>
    {
    }
}
