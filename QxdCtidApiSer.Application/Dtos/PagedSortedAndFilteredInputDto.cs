﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QxdCtidApiSer.Dtos
{
    public class PagedSortedAndFilteredInputDto: PagedAndSortedInputDto
    {
        public string Filter { get; set; }

        public int Draw { get; set; }

        public int Length
        {
            get{return this.MaxResultCount;}
            set { this.MaxResultCount = value; }
        }

        public int Start
        {
            get { return this.SkipCount; }
            set { this.SkipCount = value; }
        }
       
    }

   
}
