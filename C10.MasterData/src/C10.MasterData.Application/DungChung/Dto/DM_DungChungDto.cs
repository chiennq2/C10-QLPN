using Abp.Application.Services.Dto;
using System;

namespace C10.MasterData.DungChung.Dto
{
    public class DM_DungChungDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public Guid DanToc { get; set; }
        public Guid GioiTinh { get; set; }
        public int? StatusId { get; set; }
    }
}
