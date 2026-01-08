using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiPhamNhan
{
    [Table("DM_LOAI_PHAM_NHAN")]

    public class DM_LoaiPhamNhan : FullAuditedEntity<int>
    {

        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LPN_Ma { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LPN_Ten { get; set; }

        public int LPN_Trang_Thai { get; set; }
    }
}
