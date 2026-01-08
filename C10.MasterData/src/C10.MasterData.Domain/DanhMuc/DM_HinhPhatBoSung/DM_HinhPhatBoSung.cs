using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_HinhPhatBoSung
{
    [Table("DM_HINH_PHAT_BO_SUNG")]

    public class DM_HinhPhatBoSung : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HPBS_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string HPBS_Ma { get; set; }
        public int HPBS_Trang_Thai { get; set; }
    }
}
