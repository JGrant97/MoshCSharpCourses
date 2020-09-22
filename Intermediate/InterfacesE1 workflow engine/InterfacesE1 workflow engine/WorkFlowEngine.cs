using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetTasks())
            {
                try
                {
                    activity.Execute();

                }
                catch (Exception)
                {
                    //logging
                    //Terminate
                    throw;
                }
            }
        }
    }
}
