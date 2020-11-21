using BootstrapPaging.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapPaging
{
    public partial class PagerComponent
    {
        [Parameter]
        public int TotalSizeParam { get; set; }

        [Parameter]
        public int PageNumberParam { get; set; }

        [Parameter]
        public int PageSizeParam { get; set; }
        [Parameter]
        public bool PagerEnableNext { get; set; }
        [Parameter]
        public int PagerEndIndex { get; set; }
        [Parameter]
        public int PagerStartIndex { get; set; }
        [Parameter]
        public bool PagerEnablePrevious { get; set; }

        [Parameter]
        public int CurrentIndex { get; set; }


        [Parameter]
        public EventCallback<PageClickModel> OnPageCallBack { get; set; }



        protected override async Task OnInitializedAsync()
        {

        }


        private async Task LoadData(int pageNumber, bool updatePager)
        {

            await OnPageCallBack.InvokeAsync(new PageClickModel
            {
                PageNumber = pageNumber,
                UpdatePager = updatePager
            });
        }


    }
}
