using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_MaPhanLoai
{
    [Table("DM_MA_PHAN_LOAI")]

    public class DM_MaPhanLoai : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MPL_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string MPL_Ma { get; set; }
        public int MPL_Trang_Thai { get; set; }
    }
}
