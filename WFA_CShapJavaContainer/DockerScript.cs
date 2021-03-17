using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CShapJavaContainer
{
    public class DockerScript
    {
        public static string ContainerLocation = "";
        public static string ContainerId = "";
        public static string ContainerName = "";
        public static string GetContainerIdScript = "docker ps -q";
        public static string GetContainerIdExistedScript = "docker ps -aq";
        public static string GetSourceContainerScript = "docker container inspect "; //+ ContainerId
        public static string StartContainerScript = "docker start "; //+ ContainerId
        public static string StopContainerScript = "docker stop "; //+ ContainerId
        public static string Compile()
        {
            return "docker exec " + ContainerId + " bash /data/compile.sh";
        }
    }
}
