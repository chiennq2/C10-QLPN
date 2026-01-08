using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuocTich.Dto
{
    public class DM_QuocTichDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string QT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string QT_Ma { get; set; }
        public int QT_Trang_Thai { get; set; }
    }
}
