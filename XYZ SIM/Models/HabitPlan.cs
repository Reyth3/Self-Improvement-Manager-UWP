using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_SIM.ViewModels;

namespace XYZ_SIM.Models
{
    public class HabitPlan
    {
        public HabitPlan(HabitPlanVM vm)
        {
            Name = vm.Name;
            Description = vm.Description;
            StartingDay = vm.StartingDay;
            DaysTilCompleted = vm.DaysTilCompleted;
            EndingDay = vm.EndingDay;
            DailyObjectives = vm.DailyObjectives.Select(o => o.ToModel()).ToList();
            ProgressData = vm.ProgressData.Select(o => o.ToModel()).ToList();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartingDay { get; set; }
        public int DaysTilCompleted { get; set; }
        public DateTime EndingDay { get; set; }
        public List<HabitObjective> DailyObjectives { get; set; }
        public List<HabitDay> ProgressData { get; set; }

        public void InitializeProgressData()
        {
            if (ProgressData != null)
                return;
            ProgressData = new List<HabitDay>();
            var currentDay = StartingDay.AddDays(0);
            for(int i = 0; i < DaysTilCompleted; i++)
            {
                ProgressData.Add(new HabitDay(currentDay, DailyObjectives));
                currentDay = currentDay.AddDays(1);
            }
            EndingDay = currentDay;
        }

        public HabitPlanVM ToViewModel()
        {
            return new HabitPlanVM(this);
        }
    }
}
