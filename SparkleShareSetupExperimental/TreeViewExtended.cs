using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SparkleShareSetupExperimental {
    public partial class TreeView : System.Windows.Forms.TreeView {

        public TreeView ()
        {
            
        }
        protected override void OnDrawNode (DrawTreeNodeEventArgs e)
        {
            e.Graphics.DrawString (e.Node.Text, new Font ("Microsoft Sans Serif", 13), new SolidBrush (Color.Black), e.Bounds.X, e.Bounds.Y);
            // TODO: Add the descriptive text here. Problem is that I cant get the lblText!
            base.OnDrawNode (e);
        }

    }


    public class TreeNode : System.Windows.Forms.TreeNode {
        private String lblAdditionalInfo;

        public TreeNode (string text, string addnInfo)
        {
            this.Text = text;
            this.lblAdditionalInfo = addnInfo;
        }

        public string LblText
        {
            get { return lblAdditionalInfo; }
            set { lblAdditionalInfo = value; }
        }

    }
}
