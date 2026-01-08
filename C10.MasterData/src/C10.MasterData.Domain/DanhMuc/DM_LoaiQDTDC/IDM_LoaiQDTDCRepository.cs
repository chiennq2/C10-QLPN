using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDC
{
    public interface IDM_LoaiQDTDCRepository : IRepository<DM_LoaiQDTDC, int>
    {
        Task<IEnumerable<DM_LoaiQDTDC>> Getspecial(string[] pars);
    }
}
