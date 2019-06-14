using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_SIM.ViewModels;

namespace XYZ_SIM.Models
{
    public class HabitObjective
    {
        public HabitObjective(string text, bool optional = false)
        {
            Text = text;
            Optional = optional;
        }

        public HabitObjective(HabitObjectiveVM vm)
        {
            Text = vm.Text;
            Optional = vm.Optional;
        }

        public string Text { get; set; }
        public bool Optional { get; set; }

        public HabitObjectiveVM ToViewModel() => new HabitObjectiveVM(this);
    }
}
