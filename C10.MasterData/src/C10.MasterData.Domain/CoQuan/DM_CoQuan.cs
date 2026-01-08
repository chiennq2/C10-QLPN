using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace C10.MasterData.CoQuan
{
    [Table("DM_CoQuan")]
    public class DM_CoQuan : AuditedEntity<Guid>, ISoftDelete
    {       
        public Guid? LoaiCoQuan { get; set; }
        public string GiaiDoanToTung { get; set; }
        public string MaCoQuan { get; set; }
        public string TenCoQuan { get; set; }
        public int? DMCu { get; set; }
        public int? StatusId { get; set; }
        public int? IsAction { get; set; }
        public DateTime? DateSys { get; set; }
        public bool IsDeleted { get; set; }
    }
}
