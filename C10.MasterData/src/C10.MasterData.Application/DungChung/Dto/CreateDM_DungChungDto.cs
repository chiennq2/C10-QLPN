using Abp.AutoMapper;
using System;

namespace C10.MasterData.DungChung.Dto
{
    [AutoMapTo(typeof(DM_DungChung))]
    public class CreateDM_DungChungDto
    {
        public string Title { get; set; }
        public Guid DanToc { get; set; }
        public Guid GioiTinh { get; set; }
        public int? StatusId { get; set; }
    }
}
