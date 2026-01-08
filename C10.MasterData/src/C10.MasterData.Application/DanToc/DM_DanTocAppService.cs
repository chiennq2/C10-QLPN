using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.DanToc.Dto;
using C10.MasterData.Domain.DanhMuc.DM_DanToc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanToc
{
    public class DM_DanTocAppService : AsyncCrudAppService<DM_DanToc, DM_DanTocDto, int, PageDM_DanTocResultDto, CreateDM_DanTocDto, DM_DanTocDto>, IDM_DanTocAppService
    {
        public DM_DanTocAppService(IRepository<DM_DanToc, int> repository) : base(repository) { }   
    }
}
