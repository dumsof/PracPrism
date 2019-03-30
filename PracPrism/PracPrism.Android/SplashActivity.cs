namespace PracPrism.Droid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
    using Android.Widget;

    /// <summary>
    /// DUM: inicio con el splash que se deberia mostrar al inicio de la aplicacion.
    /// MainLauncher: esta propiedad se coloca en false en MainActivity y true en esta clase para que
    /// el sistema inicie con el splash que se acaba de programar por nosotros.
    /// </summary>
    //[Activity(Theme = "@style/theme.splash", MainLauncher = false, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Tabbar);
            System.Threading.ThreadPool.QueueUserWorkItem(o => LoadActivity());

        }

        private void LoadActivity()
        {
            System.Threading.Thread.Sleep(3000); // Simulate a long pause    
            RunOnUiThread(() => StartActivity(typeof(MainActivity)));
        }
    }
}