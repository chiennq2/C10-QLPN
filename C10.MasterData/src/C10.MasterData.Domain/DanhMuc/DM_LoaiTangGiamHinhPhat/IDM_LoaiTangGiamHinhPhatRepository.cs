using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiTangGiamHinhPhat
{
    public interface IDM_LoaiTangGiamHinhPhatRepository : IRepository<DM_LoaiTangGiamHinhPhat, int>
    {
        Task<IEnumerable<DM_LoaiTangGiamHinhPhat>> Getspecial(string[] pars);
    }
}
