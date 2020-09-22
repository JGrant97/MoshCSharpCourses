using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivities> _activities;

        public Workflow()
        {
            _activities = new List<IActivities>();
        }

        public void Add(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivities activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivities> GetTasks()
        {
            return _activities;
        }
    }
}
