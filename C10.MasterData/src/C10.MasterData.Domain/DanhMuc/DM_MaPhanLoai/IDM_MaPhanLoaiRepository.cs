using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_MaPhanLoai
{
    public interface IDM_MaPhanLoaiRepository : IRepository<DM_MaPhanLoai, int>
    {
        Task<IEnumerable<DM_MaPhanLoai>> Getspecial(string[] pars);
    }
}
