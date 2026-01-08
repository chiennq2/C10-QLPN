using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_DoTuoi
{
    [Table("DM_DO_TUOI")]
    public class DM_DoTuoi : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string DTU_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string DTU_Ma { get; set; }

        [MaxLength(10)]
        public int? DTU_Tu_Tuoi { get; set; }

        [MaxLength(10)]
        public int? DTU_Den_Tuoi { get; set; }

        public int DTU_Trang_Thai { get; set; }

    }
}
