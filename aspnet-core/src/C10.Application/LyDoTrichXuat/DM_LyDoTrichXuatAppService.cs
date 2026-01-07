using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Domain.DanhMuc.DM_LyDoKyLuat;
using C10.Core.DanhMuc.DM_LyDoTrichXuat;
using C10.LyDoTrichXuat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoTrichXuat
{
    public class DM_LyDoTrichXuatAppService : AsyncCrudAppService<DM_LyDoTrichXuat, DM_LyDoTrichXuatDto, int, PageDM_LyDoTrichXuatResultDto, CreateDM_LyDoTrichXuatDto, DM_LyDoTrichXuatDto>, IDM_LyDoTrichXuatAppService
    {
        public DM_LyDoTrichXuatAppService(IRepository<DM_LyDoTrichXuat, int> repository) : base(repository)
        {
        }
    }
}
