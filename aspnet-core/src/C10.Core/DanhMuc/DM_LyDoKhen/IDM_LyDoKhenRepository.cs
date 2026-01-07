using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LyDoKhen
{
    public interface IDM_LyDoKhenRepository : IRepository<DM_LyDoKhen, int>
    {
        Task<IEnumerable<DM_LyDoKhen>> Getspecial(string[] pars);
    }
}
