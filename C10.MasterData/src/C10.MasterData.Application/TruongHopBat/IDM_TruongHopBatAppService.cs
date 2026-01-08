using Abp.Application.Services;
using C10.TruongHopBat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.TruongHopBat
{
    public interface IDM_TruongHopBatAppService : IAsyncCrudAppService<DM_TruongHopBatDto, int, PageDM_TruongHopBatResultDto, CreateDM_TruongHopBatDto, DM_TruongHopBatDto>
    {
    }
}
