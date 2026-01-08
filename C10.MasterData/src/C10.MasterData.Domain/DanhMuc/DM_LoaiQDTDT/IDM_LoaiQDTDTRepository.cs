using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDT
{
    public interface IDM_LoaiQDTDTRepository : IRepository<DM_LoaiQDTDT, int>
    {
        Task<IEnumerable<DM_LoaiQDTDT>> Getspecial(string[] pars);
    }
}
