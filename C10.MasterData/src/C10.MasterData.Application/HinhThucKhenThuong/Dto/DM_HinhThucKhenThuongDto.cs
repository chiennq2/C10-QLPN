using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.HinhThucKhenThuong.Dto
{
    public class DM_HinhThucKhenThuongDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTKT_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string HTKT_Ma { get; set; }
        public int HTKT_Trang_Thai { get; set; }
    }
}
