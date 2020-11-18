using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapPaging.Models
{
    public class PagerModel
    {
        public int PagerStartIndex { get; set; }
        public int PagerEndIndex { get; set; }

        public int CurrentPagerIndex { get; set; }

        public bool NextEnabled { get; set; }
        public bool PreviousEnabled { get; set; }


    }

}
