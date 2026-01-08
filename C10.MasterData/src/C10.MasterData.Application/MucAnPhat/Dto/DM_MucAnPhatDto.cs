using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MucAnPhat.Dto
{
    public class DM_MucAnPhatDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string MAP_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MAP_Ma { get; set; }
        public int MAP_Tu_Muc_An { get; set; }
        public int MAP_Den_Muc_An { get; set; }
        public int MAP_Trang_Thai { get; set; }
    }
}
