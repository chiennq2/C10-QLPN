using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiTangGiamHinhPhat.Dto
{
    public class DM_LoaiTangGiamHinhPhatDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LTGHP_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LTGHP_Ma { get; set; }
        public int LTGHP_Trang_Thai { get; set; }
    }
}
