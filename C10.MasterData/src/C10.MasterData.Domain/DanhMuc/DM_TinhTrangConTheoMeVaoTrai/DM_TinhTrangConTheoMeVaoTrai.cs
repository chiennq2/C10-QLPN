using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_TinhTrangConTheoMeVaoTrai
{
    [Table("DM_TINH_TRANG_CON_THEO_ME_VAO_TRAI")]

    public class DM_TinhTrangConTheoMeVaoTrai : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string TTCTMVT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string TTCTMVT_Ma { get; set; }
        public int TTCTMVT_Trang_Thai { get; set; }
    }
}
