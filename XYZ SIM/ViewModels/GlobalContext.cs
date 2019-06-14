using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_SIM.ViewModels
{
    public class GlobalContext
    {
        public static GlobalContext Current { get; set; }
        public GlobalContext()
        {
            UserData = new UserDataVM();
            if (Current == null)
                Current = this;
            else if (Current != this)
                throw new NotSupportedException("Only one instance can be created.");
        }

        public static GlobalContext Initialize()
        {
            if (Current != null)
                return Current;
            else return new GlobalContext();
        }

        public HamburgerMenuItem[] NavigationItems { get; set; } = new HamburgerMenuItem[]
        {
            new HamburgerMenuItem("Overview", '\uE10F', typeof(Views.Overview)),
            new HamburgerMenuItem("Habit Builder", '\uE149', typeof(Views.HabitPlanner)),
            new HamburgerMenuItem("Inspiration", '\uE706', typeof(MainPage)),
            new HamburgerMenuItem("Try Something New", '\uE2B1', typeof(MainPage)),
            new HamburgerMenuItem("Day Planner", '\uE10F', typeof(MainPage)),
            new HamburgerMenuItem("Mood Diary", '\uE170', typeof(MainPage)),
        };
        public UserDataVM UserData { get; set; }
    }
}
