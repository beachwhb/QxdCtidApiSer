using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services.Dto;

namespace QxdCtidApiSer.Dtos
{
    public class PagedInputDto : IPagedResultRequest
    {
        public PagedInputDto()
        {
            MaxResultCount = 20;
        }

        /// <summary>
        /// 每页显示的行数
        /// </summary>
        [Range(1, 100)]
        public int MaxResultCount { get; set; }

        /// <summary>
        /// 跳过数量=MaxResultCount*页数
        /// </summary>
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
    }
}
