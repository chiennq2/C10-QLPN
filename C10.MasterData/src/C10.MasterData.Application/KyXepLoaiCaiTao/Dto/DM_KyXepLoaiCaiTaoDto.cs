using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XepLoaiCaiTao.Dto
{
    public class DM_KyXepLoaiCaiTaoDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string KXLCT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string KXLCT_Ma { get; set; }
        public int KXLCT_Year { get; set; }
        public DateTime? KKXLCT_Tu_Ngay { get; set; }
        public DateTime? KKXLCT_Den_Ngay { get; set; }
        public int KXLCT_Trang_Thai { get; set; }
    }
}
