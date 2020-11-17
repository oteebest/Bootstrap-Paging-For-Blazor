using BootstrapPaging.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapPaging.Util
{
    public class PagerUtil
    {
        public static PagerModel GetPagerParams(int TotalSize, int PageSize, int PageNumber, int MaximumPages)
        {
            int startIndex = 0;

            int endIndex = 0;

            int totalPages = 0;

            int currentIndex = PageNumber - 1;

            if (TotalSize > 0)
            {
                totalPages = (TotalSize / PageSize) + ((TotalSize % PageSize) > 1 ? 1 : 0);

                if (totalPages <= MaximumPages)
                {
                    startIndex = 0;
                    endIndex = totalPages - 1;
                }
                else
                {
                    //  XXX + YYY = MaximumPages;
                    if (PageNumber > MaximumPages)
                    {
                        startIndex = currentIndex - MaximumPages + 1;

                        endIndex = currentIndex;
                    }
                    else
                    {
                        startIndex = 0;

                        endIndex = MaximumPages - 1;
                    }


                }

            }


            return new PagerModel
            {
                CurrentIndex = currentIndex,
                PagerStartIndex = startIndex,
                PagerEndIndex = endIndex,
                NextEnabled = endIndex + 1 < totalPages,
                PreviousEnabled = startIndex > 0,

            };

        }

    }
}
