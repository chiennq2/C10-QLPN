using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_XepLoaiCaiTao
{
    [Table("DM_XEP_LOAI_CAI_TAO")]

    public class DM_XepLoaiCaiTao : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string XLCT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string XLCT_Ma { get; set; }
        public int XLCT_Trang_Thai { get; set; }
    }
}
