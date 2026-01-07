using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LyDoTrichXuat
{
    public interface IDM_LyDoTrichXuatRepository : IRepository<DM_LyDoTrichXuat, int>
    {
        Task<IEnumerable<DM_LyDoTrichXuat>> Getspecial(string[] pars);
    }
}
