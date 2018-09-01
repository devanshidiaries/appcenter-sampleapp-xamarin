using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace sampleAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            AppCenter.Start("android=839ec90c-02a5-425f-adde-aec2cc5e7836;" +
                   "ios=b21e0878-63f9-4fd0-bcbf-94d1760c7f91;",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new ButtonPage();
        }
    }
}
