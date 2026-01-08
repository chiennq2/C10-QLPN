using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.MasterData.Domain.DanhMuc.DM_TinhTrangTamDinhChi
{
    [Table("DM_TINH_TRANG_TAM_DINH_CHI")]

    public class DM_TinhTrangTamDinhChi : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string TTTDC_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string TTTDC_Ma { get; set; }
        public int TTTDC_Trang_Thai { get; set; }
    }
}
