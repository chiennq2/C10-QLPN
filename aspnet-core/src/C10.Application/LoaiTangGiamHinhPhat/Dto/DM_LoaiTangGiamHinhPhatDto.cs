using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.LoaiTangGiamHinhPhat.Dto
{
    public class DM_LoaiTangGiamHinhPhatDto : EntityDto<int>
    {
        public string LTGHP_NoiDung { get; set; }
        public string LTGHP_Code { get; set; }
        public bool LTGHP_IsActive { get; set; }
    }
}
