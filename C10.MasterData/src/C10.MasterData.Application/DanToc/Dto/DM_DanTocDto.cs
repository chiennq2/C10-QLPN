using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.DanToc.Dto
{
    public class DM_DanTocDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string DT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string DT_Ma { get; set; }
        public int DT_Trang_Thai { get; set; }
    }
    
}
