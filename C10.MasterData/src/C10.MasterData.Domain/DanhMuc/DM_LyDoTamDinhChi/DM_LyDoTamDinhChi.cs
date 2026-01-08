using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_LyDoTamDinhChi
{
    [Table("DM_LY_DO_TAM_DINH_CHI")]

    public class DM_LyDoTamDinhChi : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string LDTDC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string LDTDC_Ma { get; set; }
        public int LDTDC_Trang_Thai { get; set; }
    }
}
