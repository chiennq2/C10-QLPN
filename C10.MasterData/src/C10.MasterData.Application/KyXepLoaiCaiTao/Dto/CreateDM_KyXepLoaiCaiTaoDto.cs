using Abp.AutoMapper;
using C10.MasterData;
using C10.MasterData.Domain.DanhMuc.DM_KyXepLoaiCaiTao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.XepLoaiCaiTao.Dto
{
    [AutoMapTo(typeof(DM_KyXepLoaiCaiTao))]

    public class CreateDM_KyXepLoaiCaiTaoDto
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string KXLCT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string KXLCT_Ma { get; set; }
        public int KXLCT_Year { get; set; }
        public DateTime? KXLCT_Tu_Ngay { get; set; }
        public DateTime? KXLCT_Den_Ngay { get;set; }
        public int KXLCT_Trang_Thai { get; set; }
    }
}
