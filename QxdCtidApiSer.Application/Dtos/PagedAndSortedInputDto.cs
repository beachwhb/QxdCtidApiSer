using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace QxdCtidApiSer.Dtos
{
    public class PagedAndSortedInputDto: PagedInputDto, ISortedResultRequest
    {
        public PagedAndSortedInputDto()
        {
            MaxResultCount = 20;
        }
        public string Sorting { get; set; }
    }
}
