using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DoTuoi.Dto
{
    public class DM_DoTuoiDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string DTU_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string DTU_Ma { get; set; }
        [MaxLength(10)]
        public int? DTU_Tu_Tuoi { get; set; }
        [MaxLength(10)]
        public int? DTU_Den_Tuoi { get; set; }
        public int DTU_Trang_Thai { get; set; }
    }
}
