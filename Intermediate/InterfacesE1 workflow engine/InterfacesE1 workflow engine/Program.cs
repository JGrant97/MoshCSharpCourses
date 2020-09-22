using System;

namespace InterfacesE1_workflow_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new Encoding());
            workflow.Add(new Processing());
            workflow.Add(new DatabaseChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workflow);
        }
    }
}
