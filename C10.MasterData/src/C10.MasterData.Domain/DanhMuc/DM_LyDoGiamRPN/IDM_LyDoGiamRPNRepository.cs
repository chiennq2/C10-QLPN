using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoGiamRPN
{
    public interface IDM_LyDoGiamRPNRepository : IRepository<DM_LyDoGiamRPN, int>
    {
        Task<IEnumerable<DM_LyDoGiamRPN>> Getspecial(string[] pars);
    }
}
