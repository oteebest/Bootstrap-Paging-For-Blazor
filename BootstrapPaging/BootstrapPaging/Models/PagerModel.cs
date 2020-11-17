using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapPaging.Models
{
    public class PagerModel
    {
        public int PagerStartIndex { get; set; }
        public int PagerEndIndex { get; set; }

        public int CurrentIndex { get; set; }

        public bool NextEnabled { get; set; }
        public bool PreviousEnabled { get; set; }

        public bool RefreshPager { get; set; } = true;
    }

}
