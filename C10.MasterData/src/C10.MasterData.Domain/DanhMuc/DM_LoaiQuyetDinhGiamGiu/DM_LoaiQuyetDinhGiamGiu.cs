using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LoaiQuyetDinhGiamGiu
{
    [Table("DM_LOAI_QUYET_DINH_GIAM_GIU")]

    public class DM_LoaiQuyetDinhGiamGiu : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LQDGG_Ten { get; set; }

        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LQDGG_Ma { get; set; }
        public int LQDGG_Trang_Thai { get; set; }
    }
}
