using System;

namespace InterfacesE1_workflow_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkFlowEngine();
            workflowEngine.Execute(new UploadVideo());
            workflowEngine.Execute(new Encoding());
            workflowEngine.Execute(new Processing());
            workflowEngine.Execute(new DatabaseChangeStatus());
            workflowEngine.Run(new Video());
        }
    }
}
