using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CShapJavaContainer
{
    public class RunScript
    {
        public virtual ICollection<PSObject> Run(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            ICollection<PSObject> results = pipeline.Invoke();
            runspace.Close();
            return results;
            //StringBuilder stringBuilder = new StringBuilder();
            ////foreach(PSObject res in results)
            ////{
            ////    stringBuilder.AppendLine(res.ToString());
            ////}
            //return stringBuilder.ToString();

        }



        public bool Start()
        {
            if (DockerScript.ContainerId.Length < 1) 
            {
                if (this.isContainerExisted() is false) return false; 
            }
             
                ICollection<PSObject> results = this.Run(DockerScript.StartContainerScript + DockerScript.ContainerId);
                string name = "";
                foreach (PSObject res in results)
                {
                    name = res.ToString();
                }
                if (name.Length > 0)
                {
                    DockerScript.ContainerName = name;
                    return true;
                }
            
            return false;
        }
        public bool Stop()
        {
            ICollection<PSObject> results = this.Run(DockerScript.StopContainerScript + DockerScript.ContainerId);
            string name = "";
            foreach (PSObject res in results)
            {
                name = res.ToString();
            }
            if (name.Length > 0)
            {
                DockerScript.ContainerName = "";
                DockerScript.ContainerId = "";
                DockerScript.ContainerLocation = "";
                return true;
            }
            return false;
        }


        public string Compile(string parameter)
        {
            string script = DockerScript.Compile() + " " + parameter;
            ICollection<PSObject> results = this.Run(script);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject res in results)
            {
                stringBuilder.AppendLine(res.ToString());
            }
            return stringBuilder.ToString();
        }


        public string GetLocationOfContainer()
        {

            ICollection<PSObject> results = this.Run(DockerScript.GetSourceContainerScript + DockerScript.ContainerId);
            string str = "";
            foreach (PSObject res in results)
            {
                if (res.ToString().Contains("\"Source\":"))
                {
                    str = res.ToString().Trim();
                    int firstPos = str.IndexOf(":") + 3;        //form : "Source": "C:/Users/lamhv/DockerFile/JavaProject",
                    int lastPos = str.LastIndexOf("\"");
                    str = str.Substring(firstPos, lastPos - firstPos);
                    break;
                }
            }
            return str;
        }



        public bool isContainerRunning()
        {
            ICollection<PSObject> results = this.Run(DockerScript.GetContainerIdScript);
            string id = "";
            foreach (PSObject res in results)
            {
                id = res.ToString();
            }

            if (id.Length < 1)
            {
                return false;
            }
            DockerScript.ContainerId = id;
            DockerScript.ContainerLocation = this.GetLocationOfContainer();
            return true;
        }


        public bool isContainerExisted()
        {
            string id = "";
            ICollection<PSObject> results = this.Run(DockerScript.GetContainerIdExistedScript);
            foreach (PSObject res in results)
            {
                id = res.ToString();
            }
            if (id.Length < 1)
            {
                return false;
            }
            DockerScript.ContainerId = id;
            DockerScript.ContainerLocation = this.GetLocationOfContainer();

            return true;
        }

    }
}
