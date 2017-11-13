using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFactory
{
    class Program
    {
        public delegate void DelFabrik(string nummer);

        public static List<DelFabrik> schritte = new List<DelFabrik>();
        public static List<MethodInfo> schritte2 = new List<MethodInfo>();

        static void Main(string[] args)
        {

            //schritte.Add(StepsToBuild.rohKarrosse_bereitstellen);
            //schritte.Add(StepsToBuild.motor_bereitstellen);
            //schritte.Add(StepsToBuild.achsen_montieren);
            //schritte.Add(StepsToBuild.motor_einsetzen);
            //schritte.Add(StepsToBuild.Achsen_Getriebe_verbinden);

            foreach (var S in typeof(StepsToBuild).GetMethods())
            {
                if(S.IsPublic && S.IsStatic)
                {
                    schritte.Add((DelFabrik)Delegate.CreateDelegate(typeof(DelFabrik), S));
                }

                //Console.WriteLine(S);
            }

            foreach (var S in typeof(StepsToBuild).GetMethods())
            {
                if (S.IsPublic && S.IsStatic)
                {
                    schritte2.Add(S);
                }

                //Console.WriteLine(S);
            }


            DelFabrik Auto_bauen = new DelFabrik((string s) => { });
            DelFabrik Auto_bauen2 = new DelFabrik((string s) => { });

            foreach (var S in schritte)
            {
                Auto_bauen += new DelFabrik(S);
                //Console.WriteLine(S);
            }

            Auto_bauen("1234121212");

            Console.WriteLine("------------------------------------");

            foreach (var S in schritte2)
            {
                //Auto_bauen2 += new DelFabrik(S.Name);
                //Console.WriteLine(S);
            }

            Auto_bauen2("1234121212");

            Console.ReadLine();
        }
    }
}
