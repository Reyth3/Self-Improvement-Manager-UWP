using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_SIM.Models;

namespace XYZ_SIM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class UserDataVM
    {
        public UserDataVM()
        {
            Habits = new ObservableCollection<HabitPlanVM>();
        }

        public UserDataVM(UserData data)
        {
            Habits = new ObservableCollection<HabitPlanVM>(data.Habits.Select(o => o.ToViewModel()));
        }

        public ObservableCollection<HabitPlanVM> Habits { get; set; }


        public UserData ToModel() => new UserData(this);
    }
}
