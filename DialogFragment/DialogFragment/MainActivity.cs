using Android.App;
using Android.Widget;
using Android.OS;

namespace DialogFragment
{
    [Activity(Label = "DialogFragment", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private FragmentManager fm;
        private Dfragment planes;
        private Button show;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            show = FindViewById<Button>(Resource.Id.btnShow);
            show.Click += Show_Click;

            fm = this.FragmentManager;
            planes=new Dfragment();
        }

        private void Show_Click(object sender, System.EventArgs e)
        {
            planes.Show(fm, "plane_TAG");
        }
    }
}

