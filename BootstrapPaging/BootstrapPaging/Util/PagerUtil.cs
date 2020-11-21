using BootstrapPaging.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapPaging.Util
{
    public class PagerUtil
    {
        public static PagerModel GetPagerParams(int totalSize, int pageSize, 
            int pageNumber, int maximuimPagerCountForDisplay,bool updatePager,
            int currentPagerStartIndex, int currentPagerEndIndex,bool currentNextEnabled,bool currentPreviousEnabled)
        {
            int currentIndex = pageNumber - 1;

            if (updatePager)
            {
                int startIndex = 0;

                int endIndex = 0;

                int totalPages = 0;
               
                if (totalSize > 0)
                {
                    totalPages = (totalSize / pageSize) + ((totalSize % pageSize) > 0 ? 1 : 0);

                    if (totalPages <= maximuimPagerCountForDisplay)
                    {
                        startIndex = 0;
                        endIndex = totalPages - 1;
                    }
                    else
                    {
                        //  XXX + YYY = MaximumPages;
                        if (pageNumber > maximuimPagerCountForDisplay)
                        {
                            startIndex = currentIndex - maximuimPagerCountForDisplay + 1;

                            endIndex = currentIndex;
                        }
                        else
                        {
                            startIndex = 0;

                            endIndex = maximuimPagerCountForDisplay - 1;
                        }


                    }

                }

                return new PagerModel
                {
                    CurrentPagerIndex = currentIndex,
                    PagerStartIndex = startIndex,
                    PagerEndIndex = endIndex,
                    NextEnabled = endIndex + 1 < totalPages,
                    PreviousEnabled = startIndex > 0,

                };
            }
            else
            {
                return new PagerModel
                {
                    CurrentPagerIndex = currentIndex,
                    PagerStartIndex = currentPagerStartIndex,
                    PagerEndIndex = currentPagerEndIndex,
                    NextEnabled = currentNextEnabled,
                    PreviousEnabled = currentPreviousEnabled,

                };
            }
            

        }

    }
}
