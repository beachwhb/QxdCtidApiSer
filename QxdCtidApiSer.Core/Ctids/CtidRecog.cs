using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace QxdCtidApiSer.Ctids
{
    public class CtidRecog:Entity<long>,IFullAudited
    {
        public string CustomerNo { get; set; }
        public string AppName { get; set; }
        public string TerminalNo { get; set; }
        public string TimeStamp { get; set; }
        public string BusinessSerialNumber { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string AuthResult { get; set; }
        public decimal Similarity { get; set; }
        public string ReservedData { get; set; }


        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }
    }
}
