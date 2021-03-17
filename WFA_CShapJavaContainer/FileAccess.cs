using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CShapJavaContainer
{
    public class FileAccess
    {
        public string fileName { get; set; }
        public void Write(List<string> src)
        {
            string file = fileName + ".java";
            string path = Path.Combine(DockerScript.ContainerLocation, file);
            File.WriteAllLines(path, src);
        }

        public void CreateShScriptFile()
        {
            string src = "cd /data;";
            src += "javac " + fileName + ".java;";
            src += "java " + fileName + " \"$@\"";
            string path = Path.Combine(DockerScript.ContainerLocation, "compile.sh");
            File.WriteAllText(path, src);
        }
    }
}
