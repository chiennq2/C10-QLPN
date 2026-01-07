using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_GioiTinh
{
    public interface IDM_GioiTinhRepository : IRepository<DM_GioiTinh, int>
    {
        Task<IEnumerable<DM_GioiTinh>> Getspecial(string[] pars);
    }
}
