using Abp.Application.Services.Dto;
using C10.MasterData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.QuanHeVoiPhamNhan.Dto
{
    public class DM_QuanHeVoiPNDto : EntityDto<int>
    {
        [Required]
        [StringLength(MasterDataConsts.MaxTenLength)]
        public string QHVPN_Ten { get; set; }
        [Required]
        [StringLength(MasterDataConsts.MaxMaLength)]
        public string QHVPN_Ma { get; set; }
        public int QHVPN_Trang_Thai { get; set; }
    }
}
