using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using MoneyFox.Business.ViewModels.Statistic;
using MoneyFox.Business.Views;
using MoneyFox.Droid.Dialogs;
using MoneyFox.Foundation.Resources;
using MvvmCross.Droid.Support.V7.AppCompat;
using Xamarin.Forms.Platform.Android;

namespace MoneyFox.Droid.Activities
{
    [Activity(Label = "ModifyAccountActivity",
        Name = "moneyfox.droid.activities.StatisticCategorySpreadingActivity",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop)]
    public class StatisticCategorySpreadingActivity : MvxAppCompatActivity<StatisticCategorySpreadingViewModel>
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_frame);
            Title = Strings.CategorySpreadingLabel;

            SetSupportActionBar(FindViewById<Toolbar>(Resource.Id.toolbar));
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            var fragment = new StatisticCategorySpreadingPage { BindingContext = ViewModel }.CreateFragment(this);
            FragmentManager.BeginTransaction()
                           .Replace(Resource.Id.content_frame, fragment)
                           .Commit();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_select, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        /// <summary>
        ///     This hook is called whenever an item in your options menu is selected.
        /// </summary>
        /// <param name="item">The menu item that was selected.</param>
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;

                case Resource.Id.action_select:
                    var dialog = new SelectDateRangeDialog();
                    dialog.Show(SupportFragmentManager.BeginTransaction(), Strings.SelectDateTitle);
                    return true;

                default:
                    return false;
            }
        }
    }
}