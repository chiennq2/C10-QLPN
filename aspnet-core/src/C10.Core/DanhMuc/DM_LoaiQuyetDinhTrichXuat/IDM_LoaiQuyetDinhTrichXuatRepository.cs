using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LoaiQuyetDinhTrichXuat
{
    public interface IDM_LoaiQuyetDinhTrichXuatRepository : IRepository<DM_LoaiQuyetDinhTrichXuat, int>
    {
        Task<IEnumerable<DM_LoaiQuyetDinhTrichXuat>> Getspecial(string[] pars);
    }
}
