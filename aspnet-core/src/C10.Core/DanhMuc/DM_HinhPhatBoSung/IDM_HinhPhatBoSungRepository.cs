using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_HinhPhatBoSung
{
    public interface IDM_HinhPhatBoSungRepository : IRepository<DM_HinhPhatBoSung, int>
    {
        Task<IEnumerable<DM_HinhPhatBoSung>> Getspecial(string[] pars);
    }
}
