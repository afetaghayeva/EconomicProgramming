
namespace EconomicProgramming
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GC_Result2 = new DevExpress.XtraGrid.GridControl();
            this.GV_Result2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Result = new DevExpress.XtraGrid.GridControl();
            this.GV_Result = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Result2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Result2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GC_Result2);
            this.layoutControl1.Controls.Add(this.btnCalculate);
            this.layoutControl1.Controls.Add(this.GC_Result);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(832, 453);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GC_Result2
            // 
            this.GC_Result2.Location = new System.Drawing.Point(431, 12);
            this.GC_Result2.MainView = this.GV_Result2;
            this.GC_Result2.Name = "GC_Result2";
            this.GC_Result2.Size = new System.Drawing.Size(389, 429);
            this.GC_Result2.TabIndex = 3;
            this.GC_Result2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Result2});
            this.GC_Result2.Visible = false;
            // 
            // GV_Result2
            // 
            this.GV_Result2.GridControl = this.GC_Result2;
            this.GV_Result2.Name = "GV_Result2";
            this.GV_Result2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GV_Result2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.GV_Result2.OptionsBehavior.Editable = false;
            this.GV_Result2.OptionsView.ShowGroupPanel = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 419);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(415, 22);
            this.btnCalculate.StyleController = this.layoutControl1;
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Hesabla";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // GC_Result
            // 
            this.GC_Result.Location = new System.Drawing.Point(12, 12);
            this.GC_Result.MainView = this.GV_Result;
            this.GC_Result.Name = "GC_Result";
            this.GC_Result.Size = new System.Drawing.Size(415, 403);
            this.GC_Result.TabIndex = 0;
            this.GC_Result.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Result});
            // 
            // GV_Result
            // 
            this.GV_Result.GridControl = this.GC_Result;
            this.GV_Result.Name = "GV_Result";
            this.GV_Result.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GV_Result.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.GV_Result.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(832, 453);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GC_Result;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(419, 407);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCalculate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 407);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(419, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.GC_Result2;
            this.layoutControlItem3.Location = new System.Drawing.Point(419, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(393, 433);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // Form1
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Result2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Result2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GC_Result;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Result;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl GC_Result2;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Result2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

