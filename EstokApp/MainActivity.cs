using Android.Content;
using EstokApp.Activities;

namespace EstokApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Intent intent = new Intent(this, typeof(CadastroNovoUsuarioActivity));
            StartActivity(intent);
        }
    }
}