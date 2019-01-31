using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QxdCtidApiSer.Ctids.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class GetFourAndFaceInput
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string IdCardNo { get; set; }
        [Required]
        public DataType UserLifeBegin { get; set; }
        [Required]
        public DataType UserLifeEnd { get; set; }
        [Required]
        public string PhotoBuffer { get; set; }
    }
}
