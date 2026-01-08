using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_MucAnPhat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MucAnPhat.Dto
{
    [AutoMapTo(typeof(DM_MucAnPhat))]
    public class CreateDM_MucAnPhatDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string MAP_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MAP_Ma { get; set; }
        public int? MAP_Tu_Muc_An { get; set; }
        public int? MAP_Den_Muc_An { get; set; }
        public int MAP_Trang_Thai { get; set; }
    }
}
