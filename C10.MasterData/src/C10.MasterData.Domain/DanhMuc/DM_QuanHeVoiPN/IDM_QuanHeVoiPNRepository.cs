using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_QuanHeVoiPN
{
    public interface IDM_QuanHeVoiPNRepository : IRepository<DM_QuanHeVoiPN, int>
    {
        Task<IEnumerable<DM_QuanHeVoiPN>> Getspecial(string[] pars);
    }
}
