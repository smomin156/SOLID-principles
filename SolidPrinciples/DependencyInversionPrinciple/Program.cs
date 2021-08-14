using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomobile automobile = new Jeep();
            //IAutomobile automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();

            Console.ReadLine();
        }
    }

    public interface IAutomobile//abstraction
    {
        void Ignition();
        void Stop();
    }

    public class Jeep : IAutomobile//low level class
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
    }

    public class SUV : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
    }
    public class AutomobileController//high level class
    {
        IAutomobile m_Automobile;

        public AutomobileController(IAutomobile automobile)//constructor injection
        {
            this.m_Automobile = automobile;
        }

        public void Ignition()
        {
            m_Automobile.Ignition();
        }

        public void Stop()
        {
            m_Automobile.Stop();
        }

    }

}
