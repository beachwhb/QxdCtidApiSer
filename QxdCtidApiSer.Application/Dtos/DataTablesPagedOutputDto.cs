using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace QxdCtidApiSer.Dtos
{
    [Serializable]
    public class DataTablesPagedOutputDto<T> : PagedResultDto<T>
    {
        public DataTablesPagedOutputDto(int totalCount, IReadOnlyList<T> items) : base(totalCount, items)
        {
            this.RecordsFiltered = totalCount;
        }

        public int Draw { get; set; }
        public int RecordsFiltered { get; set; }
        public int RecordsTotal => this.TotalCount;
    }
}
