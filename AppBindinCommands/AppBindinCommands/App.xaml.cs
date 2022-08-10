using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBindinCommands
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DateTime data = DateTime.Now;
            Application.Current.Properties["dAtual"] = data;
            Application.Current.Properties["AcaoInicial"] = string.Format(" *App executado ás {0}.  \n", data);



            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Application.Current.Properties["AcaoStart"] = string.Format(" * App iniciado ás {0}. /n", DateTime.Now);
        }

        protected override void OnSleep()
        {
            Application.Current.Properties["AcaoSleep"] = string.Format(" * App em segundo plano ás {0}. \n",  DateTime.Now);
        }

        protected override void OnResume()
        {
            Application.Current.Properties["AcaoResume"] = string.Format(" * App relativo ás {0}. \n", DateTime.Now);
        }
    }
}
