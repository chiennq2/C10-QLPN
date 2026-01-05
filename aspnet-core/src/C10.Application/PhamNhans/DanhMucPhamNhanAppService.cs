using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using C10.Authorization;
using C10.PhamNhans.Dto;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace C10.PhamNhans;

[AbpAuthorize(PermissionNames.Pages_DanhMucPhamNhan)]
public class DanhMucPhamNhanAppService : AsyncCrudAppService<
    DanhMucPhamNhan,
    DanhMucPhamNhanDto,
    int,
    PagedDanhMucPhamNhanResultRequestDto,
    CreateDanhMucPhamNhanDto,
    DanhMucPhamNhanDto>,
    IDanhMucPhamNhanAppService
{
    public DanhMucPhamNhanAppService(IRepository<DanhMucPhamNhan, int> repository)
        : base(repository)
    {
    }

    protected override IQueryable<DanhMucPhamNhan> CreateFilteredQuery(PagedDanhMucPhamNhanResultRequestDto input)
    {
        return Repository.GetAll()
            .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword),
                x => x.Code.Contains(input.Keyword) || x.NoiDung.Contains(input.Keyword))
            .WhereIf(input.IsActive.HasValue, x => x.IsActive == input.IsActive);
    }

    protected override IQueryable<DanhMucPhamNhan> ApplySorting(
        IQueryable<DanhMucPhamNhan> query,
        PagedDanhMucPhamNhanResultRequestDto input)
    {
        return query.OrderBy(input.Sorting);
    }

    protected override void MapToEntity(DanhMucPhamNhanDto updateInput, DanhMucPhamNhan entity)
    {
        entity.Code = updateInput.Code;
        entity.NoiDung = updateInput.NoiDung;
        entity.IsActive = updateInput.IsActive;
    }
}
