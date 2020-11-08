using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
    class WorkoutViewModel
    {
        public int WorkoutID { get; set; }
        public string Exercise1 { get; set; }
        public int Exercise1Sets { get; set; }
        public int Exercise1Reps { get; set; }
        
        public string DisplayExercise1
        {
            get
            {
               return this.Exercise1 + ": " + this.Exercise1Sets + "x" + this.Exercise1Reps;
            }
        }
    }
}

