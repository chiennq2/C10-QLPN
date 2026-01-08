using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_XuLyBat
{
    public interface IDM_XuLyBatRepository : IRepository<DM_XuLyBat, int>
    {
        Task<IEnumerable<DM_XuLyBat>> Getspecial(string[] pars);
    }
    
}
