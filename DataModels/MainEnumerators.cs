using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCsharp1.DataModels
{
    public class MainEnumerators
    {
        public enum MenuItems
        {
            Iterations = 1,
            DemoArrayList = 2,
            TestEnums = 3,
            Employees = 4,
            ExitProgram = 9,
        }

        public enum EmployeeMenuItems
        {
            AddEmployee = 1,
            RemoveEmployee = 2,
            ModifyEmployee = 3,
            SearchEmployee = 4,
            ExitProgram = 9,
        }

        public enum CarEngine
        {
            Petrol = 1,
            Diesel,
            Electric,
            Hybrid,
            PluginHybrid
        }

        public enum Gender
        {
            None,
            Male,
            Female
        }
    }
}
