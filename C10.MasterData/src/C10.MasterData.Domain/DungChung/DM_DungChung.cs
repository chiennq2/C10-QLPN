using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.DungChung
{
    [Table("DM_DungChung")]
    public class DM_DungChung : AuditedEntity<Guid>, ISoftDelete
    {        
        public string Title { get; set; }
        public Guid DanToc { get; set; }
        public Guid GioiTinh { get; set; }
        public int? StatusId { get; set; }        
        public bool IsDeleted { get; set; }
    }
}
