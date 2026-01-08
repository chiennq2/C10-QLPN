using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhamNhan;
using C10.PhamNhans.Dto;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace C10.PhamNhans;

public class DM_LoaiPhamNhanAppService : AsyncCrudAppService<
    DM_LoaiPhamNhan,
    DM_LoaiPhamNhanDto,
    int,
    PagedDM_LoaiPhamNhanResultRequestDto,
    CreateDM_LoaiPhamNhanDto,
    DM_LoaiPhamNhanDto>,
    IDM_LoaiPhamNhanAppService
{
    public DM_LoaiPhamNhanAppService(IRepository<DM_LoaiPhamNhan, int> repository)
        : base(repository)
    {
    }

    protected override IQueryable<DM_LoaiPhamNhan> CreateFilteredQuery(PagedDM_LoaiPhamNhanResultRequestDto input)
    {
        return Repository.GetAll()
            .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword),
                x => x.LPN_Ma.Contains(input.Keyword) || x.LPN_Ten.Contains(input.Keyword))
            .WhereIf(input.LPN_Trang_Thai.HasValue, x => x.LPN_Trang_Thai == input.LPN_Trang_Thai);
    }

    protected override IQueryable<DM_LoaiPhamNhan> ApplySorting(
        IQueryable<DM_LoaiPhamNhan> query,
        PagedDM_LoaiPhamNhanResultRequestDto input)
    {
        return query.OrderBy(input.Sorting);
    }

    protected override void MapToEntity(DM_LoaiPhamNhanDto updateInput, DM_LoaiPhamNhan entity)
    {
        entity.LPN_Ma = updateInput.LPN_Ma;
        entity.LPN_Ten = updateInput.LPN_Ten;
        entity.LPN_Trang_Thai = updateInput.LPN_Trang_Thai;
    }
}
