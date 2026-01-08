using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.Domain.DanhMuc.DM_NgheNghiep
{
    [Table("DM_NGHE_NGHIEP")]

    public class DM_NgheNghiep : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string NN_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string NN_Ma { get; set; }
        public int NN_Trang_Thai { get; set; }
    }
}
