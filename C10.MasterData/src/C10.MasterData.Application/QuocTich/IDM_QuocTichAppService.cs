using Abp.Application.Services;
using C10.QuocTich.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuocTich
{
    public interface IDM_QuocTichAppService : IAsyncCrudAppService<DM_QuocTichDto, int, PageDM_QuocTichResultDto, CreateDM_QuocTichDto, DM_QuocTichDto>
    {
    }
}
