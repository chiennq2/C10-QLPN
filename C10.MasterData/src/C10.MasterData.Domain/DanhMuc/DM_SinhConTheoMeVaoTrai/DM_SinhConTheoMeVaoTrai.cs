using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_SinhConTheoMeVaoTrai
{
    [Table("DM_SINH_CON_THEO_ME_VAO_TRAI")]

    public class DM_SinhConTheoMeVaoTrai : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string SCTMVT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string SCTMVT_Ma { get; set; }
        public int SCTMVT_Trang_Thai { get; set; }
    }
}
