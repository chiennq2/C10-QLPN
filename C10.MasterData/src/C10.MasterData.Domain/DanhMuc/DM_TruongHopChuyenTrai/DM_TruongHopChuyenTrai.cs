using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_TruongHopChuyenTrai
{
    [Table("DM_TRUONG_HOP_CHUYEN_TRAI")]

    public class DM_TruongHopChuyenTrai : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string THCT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string THCT_Ma { get; set; }
        public int THCT_Trang_Thai { get; set; }
    }
}
