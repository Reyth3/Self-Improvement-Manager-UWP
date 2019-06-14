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
    public class HabitPlanVM
    {
        public HabitPlanVM(HabitPlan habit)
        {
            Name = habit.Name;
            Description = habit.Description;
            StartingDay = habit.StartingDay;
            DaysTilCompleted = habit.DaysTilCompleted;
            EndingDay = habit.EndingDay;
            DailyObjectives = new ObservableCollection<HabitObjectiveVM>(habit.DailyObjectives.Select(o => o.ToViewModel()));
            ProgressData = new ObservableCollection<HabitDayVM>(habit.ProgressData.Select(o => o.ToViewModel()));
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartingDay { get; set; }
        public int DaysTilCompleted { get; set; }
        public DateTime EndingDay { get; set; }
        public ObservableCollection<HabitObjectiveVM> DailyObjectives { get; set; }
        public ObservableCollection<HabitDayVM> ProgressData { get; set; }


        public HabitPlan ToModel() => new HabitPlan(this);
    }

    [AddINotifyPropertyChangedInterface]
    public class HabitObjectiveVM
    {
        public HabitObjectiveVM(HabitObjective objective)
        {
            Text = objective.Text;
            Optional = objective.Optional;
        }

        public string Text { get; set; }
        public bool Optional { get; set; }


        public HabitObjective ToModel() => new HabitObjective(this);
    }

    [AddINotifyPropertyChangedInterface]
    public class HabitDayVM
    {
        public HabitDayVM(HabitDay day)
        {
            Date = day.Date;
            ObjectivesBreakdown = new ObservableCollection<KeyValuePair<HabitObjectiveVM, bool>>(day.ObjectivesBreakdown.Select(o => new KeyValuePair<HabitObjectiveVM, bool>(o.Key.ToViewModel(), o.Value)));
        }

        public DateTime Date { get; set; }
        public ObservableCollection<KeyValuePair<HabitObjectiveVM, bool>> ObjectivesBreakdown { get; set; }

        public HabitDay ToModel() => new HabitDay(this);
    }
}
