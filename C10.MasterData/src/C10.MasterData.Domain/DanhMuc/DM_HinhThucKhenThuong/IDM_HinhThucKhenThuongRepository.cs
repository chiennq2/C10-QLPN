using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_HinhThucKhenThuong
{
    public interface IDM_HinhThucKhenThuongRepository : IRepository<DM_HinhThucKhenThuong, int>
    {
        Task<IEnumerable<DM_HinhThucKhenThuong>> Getspecial(string[] pars);
    }
}
