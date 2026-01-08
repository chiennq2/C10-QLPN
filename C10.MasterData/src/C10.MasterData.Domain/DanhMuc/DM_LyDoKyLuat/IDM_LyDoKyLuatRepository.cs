using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoKyLuat
{
    public interface IDM_LyDoKyLuatRepository : IRepository<DM_LyDoKyLuat, int>
    {
        Task<IEnumerable<DM_LyDoKyLuat>> Getspecial(string[] pars);
    }
}
