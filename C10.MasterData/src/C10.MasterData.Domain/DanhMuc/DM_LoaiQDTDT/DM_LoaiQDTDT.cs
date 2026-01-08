using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDT
{
    [Table("DM_LOAI_QUYET_DINH_TAM_DINH_TRI")]

    public class DM_LoaiQDTDT : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDTDT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDTDT_Ma { get; set; }
        public int LQDTDT_Trang_Thai { get; set; }
    }
}
