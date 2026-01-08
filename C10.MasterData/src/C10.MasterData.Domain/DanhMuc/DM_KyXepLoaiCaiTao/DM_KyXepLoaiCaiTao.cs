using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_KyXepLoaiCaiTao
{
    [Table("DM_KY_XEP_LOAI_CAI_TAO")]
    public class DM_KyXepLoaiCaiTao : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string KXLCT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string KXLCT_Ma { get; set; }
        [Required]
        public int KXLCT_Year { get; set; }
        public DateTime? KXLCT_FromDate { get; set; }
        public DateTime? KXLCT_ToDate { get; set; }
        public int KXLCT_Trang_Thai { get; set; }
    } 
}
