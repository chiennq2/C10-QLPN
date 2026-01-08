using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_BenhTat
{
    public interface IDM_BenhTatRepository : IRepository<DM_BenhTat, int>
    {
        Task<IEnumerable<DM_BenhTat>> Getspecial(string[] pars);
    }
}
