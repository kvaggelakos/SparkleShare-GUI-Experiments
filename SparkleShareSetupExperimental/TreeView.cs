using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SparkleShareSetupExperimental {
    public class TreeView : System.Windows.Forms.TreeView {

        public TreeView () {
            
        }
        protected override void OnDrawNode (DrawTreeNodeEventArgs e) {
            e.Graphics.DrawString (e.Node.Text.Split (';') [0], new Font ("Microsoft Sans Serif", 13),
                new SolidBrush (Color.Black), e.Bounds.X, e.Bounds.Y);
            e.Graphics.DrawString (e.Node.Text.Split (';') [1], new Font ("Microsoft Sans Serif", 9),
                new SolidBrush (Color.Black), e.Bounds.X + 10, e.Bounds.Y+15);
            base.OnDrawNode (e);
        }
    }

    public class TreeNode : System.Windows.Forms.TreeNode {
        public TreeNode (string text) {
            this.Text = text;
        }
    }

}
