﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    class Processing : IActivities
    {
        public void Execute(Message message)
        {
            Console.WriteLine("Your video has started processing");
        }
    }
}
