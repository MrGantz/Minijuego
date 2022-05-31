namespace Minijuego
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.Pablo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pablo)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Image = global::Minijuego.Properties.Resources.RedBall;
            this.p1.Location = new System.Drawing.Point(27, 329);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(140, 134);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Image = global::Minijuego.Properties.Resources.RedBall;
            this.p2.Location = new System.Drawing.Point(368, 329);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(140, 134);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.Image = global::Minijuego.Properties.Resources.RedBall;
            this.p3.Location = new System.Drawing.Point(739, 329);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(140, 134);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p3.TabIndex = 2;
            this.p3.TabStop = false;
            // 
            // Pablo
            // 
            this.Pablo.Image = global::Minijuego.Properties.Resources.Pablo;
            this.Pablo.Location = new System.Drawing.Point(27, 185);
            this.Pablo.Name = "Pablo";
            this.Pablo.Size = new System.Drawing.Size(126, 138);
            this.Pablo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pablo.TabIndex = 3;
            this.Pablo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.Pablo);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox p1;
        private PictureBox p2;
        private PictureBox p3;
        private PictureBox Pablo;
        private System.Windows.Forms.Timer timer1;
    }
}