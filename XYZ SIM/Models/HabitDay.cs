using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_SIM.ViewModels;

namespace XYZ_SIM.Models
{
    public class HabitDay
    {
        public HabitDay(DateTime day, IList<HabitObjective> objectives)
        {
            Date = day;
            ObjectivesBreakdown = new Dictionary<HabitObjective, bool>();
            foreach (var obj in objectives)
                ObjectivesBreakdown.Add(obj, false);
        }

        public HabitDay(HabitDayVM vm)
        {
            Date = vm.Date;
            ObjectivesBreakdown = vm.ObjectivesBreakdown.ToDictionary(o => o.Key.ToModel(), o => o.Value);
        }

        public DateTime Date { get; set; }
        public Dictionary<HabitObjective, bool> ObjectivesBreakdown { get; set; }

        public HabitDayVM ToViewModel() => new HabitDayVM(this);
    }
}
