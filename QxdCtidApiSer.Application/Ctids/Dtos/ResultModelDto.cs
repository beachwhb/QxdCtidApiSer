using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Qxd.Sdk.Ctid2;

namespace QxdCtidApiSer.Ctids.Dtos
{
    /// <summary>
    /// 认证结果对象CtidRecogModel
    /// </summary>
   
    public class ResultModelDto
    {
        public string Content { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }

        /*
         {
                "Content": null
                "ResultCode": 66
                "ResultMessage": "缺少： 数据包中，缺少输入项  人脸头像"
         }
         {
             "Content": null
             "ResultCode": 0
             "ResultMessage": "成功：在线认证成功00XX"
         }
         */
    }

}
