using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.Core.DanhMuc.DM_LoaiQuyetDinhTrichXuat;
using C10.LoaiQuyetDinhTrichXuat.Dto;

namespace C10.LoaiQuyetDinhTrichXuat
{
    public class DM_LoaiQuyetDinhTrichXuatAppService : AsyncCrudAppService<DM_LoaiQuyetDinhTrichXuat, DM_LoaiQuyetDinhTrichXuatDto, int, PageDM_LoaiQuyetDinhTrichXuatResultDto, CreateDM_LoaiQuyetDinhTrichXuatDto, DM_LoaiQuyetDinhTrichXuatDto>, IDM_LoaiQuyetDinhTrichXuatAppService
    {
        public DM_LoaiQuyetDinhTrichXuatAppService(IRepository<DM_LoaiQuyetDinhTrichXuat, int> repository) : base(repository)
        {
        }
    }
}
