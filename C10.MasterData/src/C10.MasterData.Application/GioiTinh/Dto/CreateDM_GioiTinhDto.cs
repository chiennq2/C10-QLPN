using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_GioiTinh;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GioiTinh.Dto
{
    [AutoMapTo(typeof(DM_GioiTinh))]
    public class CreateDM_GioiTinhDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string GT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string GT_Ma { get; set; }
        public int GT_Trang_Thai { get; set; }
    }
}
