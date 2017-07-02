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
    class Workout
    {
        private String _Name;
        private String _Detail;

        public string Name { get => _Name; set => _Name = value; }
        public string Detail { get => _Detail; set => _Detail = value; }

        public Workout(String name, String detail)
        {
            this._Name = name;
            this._Detail = detail;
        }
    }
}