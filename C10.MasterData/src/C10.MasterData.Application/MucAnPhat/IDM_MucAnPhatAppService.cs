using Abp.Application.Services;
using C10.MucAnPhat.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MucAnPhat
{
    public interface IDM_MucAnPhatAppService : IAsyncCrudAppService<DM_MucAnPhatDto, int, PageDM_MucAnPhatResultDto, CreateDM_MucAnPhatDto, DM_MucAnPhatDto>
    {
    }
}
