using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_TinhTrangSucKhoePN
{
    [Table("DM_TINH_TRANG_SUC_KHOE_PHAM_NHAN")]

    public class DM_TinhTrangSucKhoePN : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string TTSKPN_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string TTSKPN_Ma { get; set; }
        public int TTSKPN_Trang_Thai { get; set; }
    }
}
