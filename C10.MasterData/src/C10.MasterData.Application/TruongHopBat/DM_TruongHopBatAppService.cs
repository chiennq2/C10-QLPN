using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopBat;
using C10.TruongHopBat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.TruongHopBat
{
    public class DM_TruongHopBatAppService : AsyncCrudAppService<DM_TruongHopBat, DM_TruongHopBatDto, int, PageDM_TruongHopBatResultDto, CreateDM_TruongHopBatDto, DM_TruongHopBatDto>, IDM_TruongHopBatAppService
    {
        public DM_TruongHopBatAppService(IRepository<DM_TruongHopBat, int> repository) : base(repository)
        {
        }
    }
}
