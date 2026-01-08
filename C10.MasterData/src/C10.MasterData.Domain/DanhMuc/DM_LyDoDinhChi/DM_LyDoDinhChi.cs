using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoDinhChi
{
    [Table("DM_LY_DO_DINH_CHI")]

    public class DM_LyDoDinhChi : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDDC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDDC_Ma { get; set; }
        public int LDDC_Trang_Thai { get; set; }
    }
}
