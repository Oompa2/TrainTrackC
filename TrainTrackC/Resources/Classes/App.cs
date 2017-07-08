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
    static class App
    {
        private static List<Workout> _AvailableWorkouts = new List<Workout>();
        private static List<CompletedWorkoutSession> _WorkoutHistory = new List<CompletedWorkoutSession>();

        public static List<Workout> AvailableWorkouts { get => _AvailableWorkouts; set => _AvailableWorkouts = value; }
        public static List<CompletedWorkoutSession> WorkoutHistory { get => _WorkoutHistory; set => _WorkoutHistory = value; }

        //This is a temporary method to fill the AvailableWorkouts list. 
        public static void fillAvailableWorkoutsTemp()
        {
            Workout workoutOne = new Workout("Snakebite","100 pushups, 100 situps, 100 heaves");
            Workout workoutTwo = new Workout("Fran", "100 pushups, 100 situps, 100 burpees");
            Workout workoutThree = new Workout("Helen", "Squat 1RM, deadlift 1RM, 20 x bodyweight squats, 20 x light deadlifts");
            Workout workoutFour = new Workout("Super Circuit", "Lunge entire length of football field x 5, smash a can on your head");
            Workout workoutFive = new Workout("Squat thruster 1000", "Run 300m, Squat thrust 70% max x 8");
            Workout workoutSix = new Workout("Sparticus", "Wear a wreath on your head, jump around");
            Workout workoutSeven = new Workout("The happy goat", "eat grass until your full, sleep");

            AvailableWorkouts.Add(workoutOne);
            AvailableWorkouts.Add(workoutTwo);
            AvailableWorkouts.Add(workoutThree);
            AvailableWorkouts.Add(workoutFour);
            AvailableWorkouts.Add(workoutFive);
            AvailableWorkouts.Add(workoutSix);
            AvailableWorkouts.Add(workoutSeven);
        }

        //This method is a temporary method to fill the WorkoutHistory list. To basically pretend you have done some workouts. 
        public static void fillWorkoutHistoryTemp()
        {
            
        }

    }
}