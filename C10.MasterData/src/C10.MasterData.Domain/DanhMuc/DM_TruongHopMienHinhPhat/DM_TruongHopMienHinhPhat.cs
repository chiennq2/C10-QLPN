using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_TruongHopMienHinhPhat
{
    [Table("DM_TRUONG_HOP_MIEN_HINH_PHAT")]

    public class DM_TruongHopMienHinhPhat : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string THMHP_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string THMHP_Ma { get; set; }
        public int THMHP_Trang_Thai { get; set; }
    }
}
