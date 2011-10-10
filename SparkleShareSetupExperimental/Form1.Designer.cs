namespace SparkleShareSetupExperimental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container ();
            TreeNode treeNode1 = new TreeNode ("Node 1", "additional info");
            TreeNode treeNode2 = new TreeNode ("Node 2", "additional info");
            TreeNode treeNode3 = new TreeNode ("Node 3", "additional info");
            TreeNode treeNode4 = new TreeNode ("Node 4", "additional info");
            TreeNode treeNode5 = new TreeNode ("Node 5", "additional info");
            TreeNode treeNode6 = new TreeNode ("Node 6", "additional info");
            TreeNode treeNode7 = new TreeNode ("Node 7", "additional info");
            TreeNode treeNode8 = new TreeNode ("Node 8", "additional info");
            TreeNode treeNode9 = new TreeNode ("Node 9", "additional info");
            TreeNode treeNode10 = new TreeNode ("Node 10", "additional info");
            TreeNode treeNode11 = new TreeNode ("Node 11", "additional info");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Form1));
            this.treeView1 = new TreeView ();
            this.imageList1 = new System.Windows.Forms.ImageList (this.components);
            this.SuspendLayout ();
            // 
            // treeView1
            // 
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 35;
            this.treeView1.Location = new System.Drawing.Point (120, 95);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode2.Name = "Node1";
            treeNode3.Name = "Node2";
            treeNode4.Name = "Node3";
            treeNode5.Name = "Node4";
            treeNode6.Name = "Node5";
            treeNode7.Name = "Node6";
            treeNode8.Name = "Node7";
            treeNode9.Name = "Node8";
            treeNode10.Name = "Node9";
            treeNode11.Name = "Node10";
            this.treeView1.Nodes.AddRange (new System.Windows.Forms.TreeNode [] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size (448, 192);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject ("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName (0, "github.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (621, 454);
            this.Controls.Add (this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout (false);

        }

        #endregion

        private TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

