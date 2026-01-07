using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_LoaiPhanLoai
{
    public interface IDM_LoaiPhanLoaiRepository : IRepository<DM_LoaiPhanLoai, int>
    {
        Task<IEnumerable<DM_LoaiPhanLoai>> Getspecial(string[] pars);
    }
}
