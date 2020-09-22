using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    class UploadVideo : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to the cloud...");
        }
    }
}
