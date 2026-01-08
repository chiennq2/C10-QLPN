using Abp.Application.Services;
using C10.HinhThucKhenThuong.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucKhenThuong
{
    public interface IDM_HinhThucKhenThuongAppService : IAsyncCrudAppService<DM_HinhThucKhenThuongDto, int, PageDM_HinhThucKhenThuongResultDto, CreateDM_HinhThucKhenThuongDto, DM_HinhThucKhenThuongDto>
    {
    }
}
