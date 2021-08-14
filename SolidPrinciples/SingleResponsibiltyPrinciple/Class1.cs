using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibiltyPrinciple
{
    //notimplimenting SRP as open and closegate functions are not needed in garage station class
    //public class GarageStation
    //{
    //    public void DoOpenGate()
    //    {
    //        //Open the gate functinality
    //    }

    //    public void PerformService()
    //    {
    //        //Check if garage is opened
    //        //finish the vehicle service
    //    }

    //    public void DoCloseGate()
    //    {
    //        //Close the gate functinality
    //    }
    //}

    public class Gate
    {
        public void OpenGate()
        {
            //Open the Garage for service
        }

        public void CloseGate()
        {
            //Close the Garage functionlity
        }
    }

    public class GarageStation
    {
        Gate g = new Gate();
        public void PerformService()
        {
            //Check if garage is opened
            //finish the vehicle service
        }


    }
}
