using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRothSSA1.Services {
    public class MsgService {
        public static void doMsg(string status, string msg) {
            if (status == "Succeed") {
                MessageBox.Show(msg , "Information" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            } else {
                MessageBox.Show(msg , "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        public static DialogResult doQuestion(string msg) {
            var diag = MessageBox.Show(msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return diag;
        }
    }
}
