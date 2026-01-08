using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_HinhThucKyLuat
{
    public interface IDM_HinhThucKyLuatRepository : IRepository<DM_HinhThucKyLuat, int>
    {
        Task<IEnumerable<DM_HinhThucKyLuat>> Getspecial(string[] pars);

    }
}
