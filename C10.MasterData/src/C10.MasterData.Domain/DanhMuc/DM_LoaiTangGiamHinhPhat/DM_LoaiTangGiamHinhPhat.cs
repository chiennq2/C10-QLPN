using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiTangGiamHinhPhat
{
    [Table("DM_LOAI_TANG_GIAM_HINH_PHAT")]

    public class DM_LoaiTangGiamHinhPhat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LTGHP_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LTGHP_Ma { get; set; }
        public int LTGHP_Trang_Thai { get; set; }
    }
}
