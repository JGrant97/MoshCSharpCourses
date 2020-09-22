using System;

namespace Interfaces_and_Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"D:\My Documents\GitHub\C#\MoshCSharpCourses\Intermediate\Interfaces and Extensibility\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
