﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesE1_workflow_engine
{
    class DatabaseChangeStatus : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Database has changed video status to processing");
        }
    }
}