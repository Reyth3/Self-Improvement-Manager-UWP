using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_SIM.ViewModels;

namespace XYZ_SIM.Models
{
    public class UserData
    {
        public UserData() { Habits = new List<HabitPlan>(); }
        public UserData(UserDataVM vm)
        {
            Habits = vm.Habits.Select(o => o.ToModel()).ToList();
        }

        public List<HabitPlan> Habits { get; set; }
    }
}
