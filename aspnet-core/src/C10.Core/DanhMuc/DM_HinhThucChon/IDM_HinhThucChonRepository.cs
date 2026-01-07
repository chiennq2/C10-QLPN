using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_HinhThucChon
{
    public interface IDM_HinhThucChonRepository : IRepository<DM_HinhThucChon, int>
    {
        Task<IEnumerable<DM_HinhThucChon>> Getspecial(string[] pars);

    }
}
