using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.GhiChuRieng.Dto
{
    public class DM_GhiChuRiengDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string GCR_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string GCR_Ma { get; set; }
        public int GCR_Trang_Thai { get; set; }
    }
}
