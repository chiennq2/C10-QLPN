using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LyDoKhongXetGiam
{
    public interface IDM_LyDoKhongXetGiamRepository : IRepository<DM_LyDoKhongXetGiam, int>
    {
        Task<IEnumerable<DM_LyDoKhongXetGiam>> Getspecial(string[] pars);
    }
}
