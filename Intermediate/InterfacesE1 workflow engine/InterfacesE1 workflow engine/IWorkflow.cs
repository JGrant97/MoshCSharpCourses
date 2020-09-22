using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    public interface IWorkflow
    {
        void Add(IActivities activity);
        void Remove(IActivities activity);
        IEnumerable<IActivities> GetTasks();
    }
}
