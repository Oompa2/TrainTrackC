using Android.App;
using Android.Widget;
using Android.OS;
using TrainTrackC.Resources.Classes;
using Android.Support.V7.Widget;
using TrainTrackC.Resources.Helpers;

namespace TrainTrackC
{
    [Activity(Label = "Train TrackC", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        //create RecyclerView object
        RecyclerView recyclerView;
        //create a layout manager
        RecyclerView.LayoutManager layoutManager;
        //create an adapter object
        WorkoutListAdapter workoutListAdapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            App.fillAvailableWorkoutsTemp();

            // Instantiate the adapter and pass in its data source:
            workoutListAdapter = new WorkoutListAdapter(App.AvailableWorkouts);

            // Get our RecyclerView layout:
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // Plug the adapter into the RecyclerView:
            recyclerView.SetAdapter(workoutListAdapter);

            //instantiate the layout manager and plug it into the recyclerView object
            layoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutManager);


        }
    }
}

