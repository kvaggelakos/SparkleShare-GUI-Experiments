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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node14");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 35;
            this.treeView1.Location = new System.Drawing.Point(120, 95);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = -2;
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Node1";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Node2";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Node3";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Node4";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Node5";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Node6";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Node7";
            treeNode10.Name = "Node8";
            treeNode10.Text = "Node8";
            treeNode11.Name = "Node9";
            treeNode11.Text = "Node9";
            treeNode12.Name = "Node10";
            treeNode12.Text = "Node10";
            treeNode13.Name = "Node11";
            treeNode13.Text = "Node11";
            treeNode14.Name = "Node12";
            treeNode14.Text = "Node12";
            treeNode15.Name = "Node13";
            treeNode15.Text = "Node13";
            treeNode16.Name = "Node14";
            treeNode16.Text = "Node14";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(448, 192);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "github.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 454);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

