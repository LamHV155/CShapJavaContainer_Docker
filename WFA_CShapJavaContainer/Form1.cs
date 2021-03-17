using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CShapJavaContainer
{
    public partial class frm_Compile : Form
    {
        public frm_Compile()
        {
            InitializeComponent();
            RunScript runScript = new RunScript();
            if(runScript.isContainerRunning() is true)
            {
                lbl_NotContainer.Visible = false;
                lbl_Running.Visible = true;
                lbl_Existed.Visible = false;
            }
            else if(runScript.isContainerExisted() is true)
            {
                lbl_Running.Visible = false;
                lbl_Existed.Visible = true ;
                lbl_NotContainer.Visible = false;
            }
            else
            {
                lbl_Running.Visible = false;
                lbl_Existed.Visible = false;
                lbl_NotContainer.Visible = true;
            }
        }

        private void btn_StartUbuntu20Java_Click(object sender, EventArgs e)
        {
            RunScript runScript = new RunScript();
            if(lbl_NotContainer.Visible == true)
            {
                MessageBox.Show("Không tồn tại container nào !");
            }
            else if(lbl_Running.Visible == true)
            {
                MessageBox.Show("Container đang chạy !");
            }
            else if(runScript.Start() is true)
            {
                lbl_Running.Visible = true;
                lbl_Existed.Visible = false;
                lbl_NotContainer.Visible = false;
            }
            else
            {
                MessageBox.Show("Khởi chạy không thành công !");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            RunScript runScript = new RunScript();
            if (lbl_NotContainer.Visible == true)
            {
                MessageBox.Show("Không tồn tại container nào !");
            }
            else if(lbl_Existed.Visible == true)
            {
                MessageBox.Show("Không có container đang chạy !");
            }
            else if (runScript.Stop() is true)
            {
                lbl_Running.Visible = false;
                lbl_Existed.Visible = true;
                lbl_NotContainer.Visible = false;
            }
            else
            {
                MessageBox.Show("Dừng không thành công !");
            }
        }

        private void btn_Compile_Click(object sender, EventArgs e)
        {
            RunScript runScript = new RunScript();

            if(lbl_Existed.Visible is true)
            {
                MessageBox.Show("Khởi chạy container trước khi compile ! ");
                return;
            }
            if (tbx_InsertParameter.TextLength < 1)
            {
                MessageBox.Show("Điền tham số !");
                return;
            }
            FileAccess fileAccess = new FileAccess();

         
            List<string> lines = new List<string>();
            foreach(var line in tbx_InsertCode.Lines)
            {
                if(line.Contains("class ") is true)
                {
                    int firstPos = line.IndexOf(" ") + 1;
                    int lastPost = line.IndexOf("{");
                    fileAccess.fileName = line.Substring(firstPos, lastPost - firstPos);
                }
                lines.Add(line);
            }

            fileAccess.Write(lines);
            fileAccess.CreateShScriptFile();
            string str = runScript.Compile(tbx_InsertParameter.Text);
            MessageBox.Show(str);
        }
    }
}
