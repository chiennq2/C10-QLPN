using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoTrichXuat
{
    public interface IDM_LyDoTrichXuatRepository : IRepository<DM_LyDoTrichXuat, int>
    {
        Task<IEnumerable<DM_LyDoTrichXuat>> Getspecial(string[] pars);
    }
}
