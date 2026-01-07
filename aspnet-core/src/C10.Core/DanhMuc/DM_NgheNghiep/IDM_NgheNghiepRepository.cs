using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.Core.DanhMuc.DM_NgheNghiep
{
    public interface IDM_NgheNghiepRepository : IRepository<DM_NgheNghiep, int>
    {
        Task<IEnumerable<DM_NgheNghiep>> Getspecial(string[] pars);
    }
}
