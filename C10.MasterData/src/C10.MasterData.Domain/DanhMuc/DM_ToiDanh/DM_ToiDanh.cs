using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_ToiDanh
{
    [Table("DM_TOI_DANH")]

    public class DM_ToiDanh : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string TD_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string TD_Ma { get; set; }
        public int TD_Trang_Thai { get; set; }

        [StringLength(50)]
        public string? TD_Chuong { get; set; }
        [StringLength(255)]
        public string? TD_Can_Cu { get; set; }
    }
}
