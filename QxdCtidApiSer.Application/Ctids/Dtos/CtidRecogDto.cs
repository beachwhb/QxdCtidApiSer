using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Qxd.Sdk.Ctid2;

namespace QxdCtidApiSer.Ctids.Dtos
{

    [AutoMapFrom(typeof(CtidRecog), typeof(CtidRecogModel)), AutoMapTo(typeof(CtidRecog))]
    public class CtidRecogDto : EntityDto, IFullAudited
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

        #region 系统字段

        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

        #endregion

    }
}
