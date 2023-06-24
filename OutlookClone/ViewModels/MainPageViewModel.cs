using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClone.ViewModels
{
   public class MainPageViewModel: ViewModelBase
    {
        public MainPageViewModel()
        {
                 LoadingIndicatorVisible = true;


        //var httpClient = new HttpClient();

        //var jsonResponse = await httpClient.GetFromJsonAsync<List<Simpson>>(contentUri);

        //jsonResponse.ForEach(s => Simpsons.Add(s));

        LoadingIndicatorVisible = false;
        }

       
    }
}
