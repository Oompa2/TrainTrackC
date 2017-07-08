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
    class WorkoutListViewHolder : RecyclerView.ViewHolder
    {
        public TextView WorkoutName { get; private set; }
        public TextView WorkoutDetail { get; private set; }

        // Locate and store view references
        public WorkoutListViewHolder(View itemView) : base (itemView)
        {
            WorkoutName = itemView.FindViewById<TextView>(Resource.Id.textViewWorkoutName);
            WorkoutDetail = itemView.FindViewById<TextView>(Resource.Id.textViewWorkoutDetail);

        }

    }
}