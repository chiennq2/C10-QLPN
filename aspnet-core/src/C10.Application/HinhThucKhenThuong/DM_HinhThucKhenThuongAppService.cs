using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_HinhThucKhenThuong;
using C10.HinhThucKhenThuong.Dto;

namespace C10.HinhThucKhenThuong
{
    public class DM_HinhThucKhenThuongAppService : AsyncCrudAppService<DM_HinhThucKhenThuong, DM_HinhThucKhenThuongDto, int, PageDM_HinhThucKhenThuongResultDto, CreateDM_HinhThucKhenThuongDto, DM_HinhThucKhenThuongDto>, IDM_HinhThucKhenThuongAppService
    {
        public DM_HinhThucKhenThuongAppService(IRepository<DM_HinhThucKhenThuong, int> repository) : base(repository)
        {
        }
    }
}
