using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiPhanLoai
{
    [Table("DM_LOAI_PHAN_LOAI")]

    public class DM_LoaiPhanLoai : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LPL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LPL_Ma { get; set; }
        public int LPL_Trang_Thai { get; set; }
    }
}
