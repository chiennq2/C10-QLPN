using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LyDoKhongXetGiam.Dto
{
    public class DM_LyDoKhongXetGiamDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDKXG_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDKXG_Ma { get; set; }
        public int LDKXG_Trang_Thai { get; set; }
    }
}
