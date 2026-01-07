using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Domain.DanhMuc.DM_CapToaXu;
using C10.Core.DanhMuc.DM_LyDoAnGiam;
using C10.LyDoAnGiam.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoAnGiam
{
    public class DM_LyDoAnGiamAppService : AsyncCrudAppService<DM_LyDoAnGiam, DM_LyDoAnGiamDto, int, PageDM_LyDoAnGiamResultDto, CreateDM_LyDoAnGiamDto, DM_LyDoAnGiamDto>, IDM_LyDoAnGiamAppService
    {
        public DM_LyDoAnGiamAppService(IRepository<DM_LyDoAnGiam, int> repository) : base(repository)
        {
        }
    }
}
