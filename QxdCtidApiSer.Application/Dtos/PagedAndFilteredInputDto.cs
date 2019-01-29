using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace QxdCtidApiSer.Dtos
{
    public class PagedAndFilteredInputDto : IPagedResultRequest
    {
        public PagedAndFilteredInputDto()
        {
            MaxResultCount = 20;
        }

        [Range(1, 100)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public string Filter { get; set; }
    }
}
