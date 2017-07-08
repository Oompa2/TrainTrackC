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
using Android.Support.V7.Widget;
using TrainTrackC.Resources.Classes;

namespace TrainTrackC.Resources.Helpers
{
    //The adapter extracts information from the data source and loads it into each item in the RecyclerView collection
    class WorkoutListAdapter : RecyclerView.Adapter
    {
        public List<Workout> mWorkouts;

        public override int ItemCount
        {
            get { return mWorkouts.Count; }
        }

        //copies data from the data source into the two TextViews of this layout
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            WorkoutListViewHolder vh = holder as WorkoutListViewHolder;

            // Load the name resource from the workout list
            vh.WorkoutName.Text = mWorkouts[position].Name;

            // Load the workout detail from the workout list
            vh.WorkoutDetail.Text = mWorkouts[position].Detail;
        }

        // inflates this layout for a given workout name and description in the RecyclerView and instantiates a new WorkoutListViewHolder instance (which locates and caches references to the TextViews child views in the associated CardView layout)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            // Inflate the CardView for the workout name
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.WorkoutCardView, parent, false);

            // Create a ViewHolder to hold view references inside the CardView:
            WorkoutListViewHolder vh = new WorkoutListViewHolder(itemView);

            //The resulting view holder instance, vh, is returned back to the caller (the layout manager).
            return vh;
        }

        //constructor
        public WorkoutListAdapter(List<Workout> workouts) {
            mWorkouts = workouts;
        }
    }

}