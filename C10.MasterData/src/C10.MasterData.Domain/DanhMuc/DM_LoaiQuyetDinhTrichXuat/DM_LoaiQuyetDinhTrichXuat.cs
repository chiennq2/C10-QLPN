using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiQuyetDinhTrichXuat
{
    [Table("DM_LOAI_QUYET_DINH_TRICH_XUAT")]

    public class DM_LoaiQuyetDinhTrichXuat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDTX_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDTX_Ma { get; set; }
        public int LQDTX_Trang_Thai { get; set; }
    }
}
