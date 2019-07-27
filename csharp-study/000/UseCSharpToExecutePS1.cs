using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace CSharpExecutePs1
{
    class Program
    {
        static void Main(string[] args)
        {
            string script = @"Get-ChildItem c:\";
            string r = RunScript(script);
            Console.WriteLine(r);
            Console.WriteLine("End");
            Console.Read();
        }
        
        private static string RunScript(string scriptText)
        {
            // create Powershell runspace
            Runspace runspace = RunspaceFactory.CreateRunspace();
            // open it
            runspace.Open();
            // create a pipeline and feed it the script text
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(scriptText);
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();
            // close the runspace
            runspace.Close();

            // convert the script result into a single string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }
            return stringBuilder.ToString();
        }

        public void RunScript(List<string> scripts)
        {
            try
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();
                foreach (var scr in scripts)
                {
                    pipeline.Commands.AddScript(scr);
                }

                //返回结果   
                var results = pipeline.Invoke();
                runspace.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToString() + "日志记录:执行ps命令异常：" + e.Message);
            }
        }
    }
}
