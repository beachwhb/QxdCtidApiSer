using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QxdCtidApiSer.Ctids.Dtos
{
    /// <summary>
    /// 2项信息+人像
    /// </summary>
    public class GetTwoAndFaceInput
    {
        /// <summary>
        /// 身份证姓名
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [Required]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 头像，Base64格式
        /// </summary>
        [Required]
        public string PhotoBuffer { get; set; }  
    }
}
