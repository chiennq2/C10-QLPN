using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XuLyBat.Dto
{
    public class DM_XuLyBatDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string XLB_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string XLB_Ma { get; set; }
        public int XLB_Trang_Thai { get; set; }
    }
}
