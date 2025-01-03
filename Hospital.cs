using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Hospital
    {
        public virtual void HospitalDetails(string Name,string City)
        {
            Console.WriteLine("HospitalName:" + Name + "\nHospitalCity:" + City);

        }
    }
    internal class Apollo:Hospital
    {
        public override void HospitalDetails(string Name, string City)
        {
            base.HospitalDetails(Name, City);

        }
    }
    internal class Wockhardt : Hospital
    {
        public override void HospitalDetails(string Name, string City)
        {
            base.HospitalDetails(Name,City);

        }
    }
    internal class Gokul_Superspeciality: Hospital
    {
        public override void HospitalDetails(string Name, string City)
        {
            base.HospitalDetails(Name, City);

        }
    }
}
