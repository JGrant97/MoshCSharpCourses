using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    class Encoding : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("You video is ready for encoding");
        }
    }
}
