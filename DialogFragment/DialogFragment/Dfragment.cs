using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Test;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace DialogFragment
{
    public class Dfragment : Android.App.DialogFragment
    {
        private ListView lstView;
        private Button okbtButton;

        private string[] planes =
        {
            "Boeing 7x7 series", "Boeing 747", "Boeing 707", "Boeing 717", "Boeing 727", "Boeing 737", "Boeing 757"
        };

        private ArrayAdapter arrayAdapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            View v = inflater.Inflate(Resource.Layout.Fragment, container, false);

            this.Dialog.SetTitle("Boeing Series");

            lstView = v.FindViewById<ListView>(Resource.Id.lview);
            arrayAdapter=new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1,planes);

            lstView.Adapter = arrayAdapter;
            okbtButton = v.FindViewById<Button>(Resource.Id.Ok);
            okbtButton.Click += delegate
            {
                //stuff
                Dismiss();
            };
            lstView.ItemClick += LstView_ItemClick;
                return v;
        }

        private void LstView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity, planes[e.Position]+"Clicked", ToastLength.Short).Show();
        }
    }
}