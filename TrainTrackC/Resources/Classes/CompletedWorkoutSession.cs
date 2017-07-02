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

namespace TrainTrackC.Resources.Classes
{
    class CompletedWorkoutSession
    {
        private DateTime _Date;
        private Workout _Workout;
        private String _WorkoutSessionNotes;

        public DateTime Date { get => _Date; set => _Date = value; }
        public string WorkoutSessionNotes { get => _WorkoutSessionNotes; set => _WorkoutSessionNotes = value; }
        internal Workout Workout { get => _Workout; set => _Workout = value; }

        public CompletedWorkoutSession()
        {

        }
    }
}