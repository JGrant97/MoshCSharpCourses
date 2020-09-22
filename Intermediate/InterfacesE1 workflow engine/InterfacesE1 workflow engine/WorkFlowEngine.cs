using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    class WorkFlowEngine
    {
        private readonly IList<IActivities> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<IActivities>();
        }


        public void Run(Video video)
        {
            foreach (var activity in _activities)
            {
                activity.Execute(new Message());
            }
        }

        public void Execute(IActivities workflow)
        {
            _activities.Add(workflow);

        }
    }
}
