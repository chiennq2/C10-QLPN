using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_GioiTinh;
using C10.GioiTinh.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GioiTinh
{
    public class DM_GioiTinhAppService : AsyncCrudAppService<DM_GioiTinh, DM_GioiTinhDto, int, PageDM_GioiTinhResultDto, CreateDM_GioiTinhDto, DM_GioiTinhDto>, IDM_GioiTinhAppService
    {
        public DM_GioiTinhAppService(IRepository<DM_GioiTinh, int> repository) : base(repository) { }
    }
}
