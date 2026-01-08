using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDC
{
    [Table("DM_LOAI_QUYET_DINH_TAM_DINH_CHI")]

    public class DM_LoaiQDTDC : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDTDC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDTDC_Ma { get; set; }
        public int LQDTDC_Trang_Thai { get; set; }
    }
}
