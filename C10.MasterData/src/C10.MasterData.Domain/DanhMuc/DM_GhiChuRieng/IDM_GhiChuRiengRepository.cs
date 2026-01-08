using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_GhiChuRieng
{
    public interface IDM_GhiChuRiengRepository : IRepository<DM_GhiChuRieng, int>
    {
        Task<IEnumerable<DM_GhiChuRieng>> Getspecial(string[] pars);

    }
}
