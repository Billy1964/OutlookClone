using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClone.ViewModels
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
                
        }

        private bool loadingIndicatorVisible;
        public bool LoadingIndicatorVisible
        {
            get { return loadingIndicatorVisible; }
            set { loadingIndicatorVisible = value; }
        }

    }
}
