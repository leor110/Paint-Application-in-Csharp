
namespace CS_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Load = new System.Windows.Forms.Button();
            this.pnl_toolbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_used_color = new System.Windows.Forms.Button();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.TKB_Size = new System.Windows.Forms.TrackBar();
            this.btn_Save_img = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_fill = new System.Windows.Forms.Label();
            this.lbl_eraser = new System.Windows.Forms.Label();
            this.lbl_Pen = new System.Windows.Forms.Label();
            this.pcbx_section_line3 = new System.Windows.Forms.PictureBox();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.btn_Eraser = new System.Windows.Forms.Button();
            this.btn_Pen = new System.Windows.Forms.Button();
            this.btl_Rectangle = new System.Windows.Forms.Button();
            this.lbl_Rectangle = new System.Windows.Forms.Label();
            this.lbl_Ellipse = new System.Windows.Forms.Label();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.btl_Ellipse = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.pcbx_section_line2 = new System.Windows.Forms.PictureBox();
            this.pcbx_section_line1 = new System.Windows.Forms.PictureBox();
            this.lbl_color_used = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcbx_bg = new System.Windows.Forms.PictureBox();
            this.pnl_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_section_line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_section_line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_section_line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.Location = new System.Drawing.Point(664, 13);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(53, 23);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // pnl_toolbar
            // 
            this.pnl_toolbar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_toolbar.Controls.Add(this.pictureBox1);
            this.pnl_toolbar.Controls.Add(this.btn_used_color);
            this.pnl_toolbar.Controls.Add(this.btn_save_file);
            this.pnl_toolbar.Controls.Add(this.TKB_Size);
            this.pnl_toolbar.Controls.Add(this.btn_Save_img);
            this.pnl_toolbar.Controls.Add(this.btn_clear);
            this.pnl_toolbar.Controls.Add(this.lbl_fill);
            this.pnl_toolbar.Controls.Add(this.lbl_eraser);
            this.pnl_toolbar.Controls.Add(this.lbl_Pen);
            this.pnl_toolbar.Controls.Add(this.pcbx_section_line3);
            this.pnl_toolbar.Controls.Add(this.btn_Fill);
            this.pnl_toolbar.Controls.Add(this.btn_Eraser);
            this.pnl_toolbar.Controls.Add(this.btn_Pen);
            this.pnl_toolbar.Controls.Add(this.btl_Rectangle);
            this.pnl_toolbar.Controls.Add(this.lbl_Rectangle);
            this.pnl_toolbar.Controls.Add(this.lbl_Ellipse);
            this.pnl_toolbar.Controls.Add(this.lbl_Line);
            this.pnl_toolbar.Controls.Add(this.btl_Ellipse);
            this.pnl_toolbar.Controls.Add(this.btn_Line);
            this.pnl_toolbar.Controls.Add(this.pcbx_section_line2);
            this.pnl_toolbar.Controls.Add(this.pcbx_section_line1);
            this.pnl_toolbar.Controls.Add(this.lbl_color_used);
            this.pnl_toolbar.Controls.Add(this.btn_Load);
            this.pnl_toolbar.Location = new System.Drawing.Point(0, 1);
            this.pnl_toolbar.Name = "pnl_toolbar";
            this.pnl_toolbar.Size = new System.Drawing.Size(802, 86);
            this.pnl_toolbar.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btn_used_color
            // 
            this.btn_used_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_used_color.Location = new System.Drawing.Point(103, 3);
            this.btn_used_color.Name = "btn_used_color";
            this.btn_used_color.Size = new System.Drawing.Size(55, 57);
            this.btn_used_color.TabIndex = 46;
            this.btn_used_color.UseVisualStyleBackColor = true;
            this.btn_used_color.Click += new System.EventHandler(this.btn_used_color_Click);
            // 
            // btn_save_file
            // 
            this.btn_save_file.BackColor = System.Drawing.SystemColors.Control;
            this.btn_save_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_file.Location = new System.Drawing.Point(664, 42);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(53, 37);
            this.btn_save_file.TabIndex = 45;
            this.btn_save_file.Text = "Save file";
            this.btn_save_file.UseVisualStyleBackColor = false;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
            // 
            // TKB_Size
            // 
            this.TKB_Size.BackColor = System.Drawing.SystemColors.Control;
            this.TKB_Size.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TKB_Size.Location = new System.Drawing.Point(597, 7);
            this.TKB_Size.Maximum = 11;
            this.TKB_Size.Minimum = 1;
            this.TKB_Size.Name = "TKB_Size";
            this.TKB_Size.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TKB_Size.Size = new System.Drawing.Size(45, 76);
            this.TKB_Size.TabIndex = 44;
            this.TKB_Size.Value = 1;
            this.TKB_Size.Scroll += new System.EventHandler(this.TKB_Size_Scroll);
            // 
            // btn_Save_img
            // 
            this.btn_Save_img.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_img.Location = new System.Drawing.Point(725, 42);
            this.btn_Save_img.Name = "btn_Save_img";
            this.btn_Save_img.Size = new System.Drawing.Size(53, 37);
            this.btn_Save_img.TabIndex = 43;
            this.btn_Save_img.Text = "Save image";
            this.btn_Save_img.UseVisualStyleBackColor = false;
            this.btn_Save_img.Click += new System.EventHandler(this.btn_Save_img_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(725, 13);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(53, 23);
            this.btn_clear.TabIndex = 42;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_fill
            // 
            this.lbl_fill.AutoSize = true;
            this.lbl_fill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_fill.ForeColor = System.Drawing.Color.White;
            this.lbl_fill.Location = new System.Drawing.Point(554, 67);
            this.lbl_fill.Name = "lbl_fill";
            this.lbl_fill.Size = new System.Drawing.Size(21, 12);
            this.lbl_fill.TabIndex = 41;
            this.lbl_fill.Text = "Fill";
            // 
            // lbl_eraser
            // 
            this.lbl_eraser.AutoSize = true;
            this.lbl_eraser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_eraser.ForeColor = System.Drawing.Color.White;
            this.lbl_eraser.Location = new System.Drawing.Point(491, 66);
            this.lbl_eraser.Name = "lbl_eraser";
            this.lbl_eraser.Size = new System.Drawing.Size(43, 13);
            this.lbl_eraser.TabIndex = 40;
            this.lbl_eraser.Text = "Eraser";
            // 
            // lbl_Pen
            // 
            this.lbl_Pen.AutoSize = true;
            this.lbl_Pen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Pen.ForeColor = System.Drawing.Color.White;
            this.lbl_Pen.Location = new System.Drawing.Point(427, 66);
            this.lbl_Pen.Name = "lbl_Pen";
            this.lbl_Pen.Size = new System.Drawing.Size(29, 13);
            this.lbl_Pen.TabIndex = 39;
            this.lbl_Pen.Text = "Pen";
            // 
            // pcbx_section_line3
            // 
            this.pcbx_section_line3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pcbx_section_line3.Location = new System.Drawing.Point(648, -1);
            this.pcbx_section_line3.Name = "pcbx_section_line3";
            this.pcbx_section_line3.Size = new System.Drawing.Size(10, 86);
            this.pcbx_section_line3.TabIndex = 38;
            this.pcbx_section_line3.TabStop = false;
            // 
            // btn_Fill
            // 
            this.btn_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fill.Image")));
            this.btn_Fill.Location = new System.Drawing.Point(540, 13);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(51, 51);
            this.btn_Fill.TabIndex = 37;
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eraser.Image")));
            this.btn_Eraser.Location = new System.Drawing.Point(483, 13);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.Size = new System.Drawing.Size(51, 51);
            this.btn_Eraser.TabIndex = 36;
            this.btn_Eraser.UseVisualStyleBackColor = true;
            this.btn_Eraser.Click += new System.EventHandler(this.btn_Eraser_Click);
            // 
            // btn_Pen
            // 
            this.btn_Pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pen.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pen.Image")));
            this.btn_Pen.Location = new System.Drawing.Point(418, 13);
            this.btn_Pen.Name = "btn_Pen";
            this.btn_Pen.Size = new System.Drawing.Size(51, 51);
            this.btn_Pen.TabIndex = 35;
            this.btn_Pen.UseVisualStyleBackColor = true;
            this.btn_Pen.Click += new System.EventHandler(this.btn_Pen_Click);
            // 
            // btl_Rectangle
            // 
            this.btl_Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btl_Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("btl_Rectangle.Image")));
            this.btl_Rectangle.Location = new System.Drawing.Point(331, 11);
            this.btl_Rectangle.Name = "btl_Rectangle";
            this.btl_Rectangle.Size = new System.Drawing.Size(51, 51);
            this.btl_Rectangle.TabIndex = 34;
            this.btl_Rectangle.UseVisualStyleBackColor = true;
            this.btl_Rectangle.Click += new System.EventHandler(this.btl_Rectangle_Click);
            // 
            // lbl_Rectangle
            // 
            this.lbl_Rectangle.AutoSize = true;
            this.lbl_Rectangle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Rectangle.ForeColor = System.Drawing.Color.White;
            this.lbl_Rectangle.Location = new System.Drawing.Point(326, 65);
            this.lbl_Rectangle.Name = "lbl_Rectangle";
            this.lbl_Rectangle.Size = new System.Drawing.Size(56, 12);
            this.lbl_Rectangle.TabIndex = 33;
            this.lbl_Rectangle.Text = "Rectangle";
            // 
            // lbl_Ellipse
            // 
            this.lbl_Ellipse.AutoSize = true;
            this.lbl_Ellipse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Ellipse.ForeColor = System.Drawing.Color.White;
            this.lbl_Ellipse.Location = new System.Drawing.Point(264, 65);
            this.lbl_Ellipse.Name = "lbl_Ellipse";
            this.lbl_Ellipse.Size = new System.Drawing.Size(44, 13);
            this.lbl_Ellipse.TabIndex = 32;
            this.lbl_Ellipse.Text = "Ellipse";
            // 
            // lbl_Line
            // 
            this.lbl_Line.AutoSize = true;
            this.lbl_Line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Line.ForeColor = System.Drawing.Color.White;
            this.lbl_Line.Location = new System.Drawing.Point(200, 65);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(31, 13);
            this.lbl_Line.TabIndex = 31;
            this.lbl_Line.Text = "Line";
            // 
            // btl_Ellipse
            // 
            this.btl_Ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btl_Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("btl_Ellipse.Image")));
            this.btl_Ellipse.Location = new System.Drawing.Point(257, 11);
            this.btl_Ellipse.Name = "btl_Ellipse";
            this.btl_Ellipse.Size = new System.Drawing.Size(51, 51);
            this.btl_Ellipse.TabIndex = 29;
            this.btl_Ellipse.UseVisualStyleBackColor = true;
            this.btl_Ellipse.Click += new System.EventHandler(this.btl_Ellipse_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Line.Image = global::CS_App.Properties.Resources.Line;
            this.btn_Line.Location = new System.Drawing.Point(190, 11);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(51, 51);
            this.btn_Line.TabIndex = 28;
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // pcbx_section_line2
            // 
            this.pcbx_section_line2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pcbx_section_line2.Location = new System.Drawing.Point(402, -1);
            this.pcbx_section_line2.Name = "pcbx_section_line2";
            this.pcbx_section_line2.Size = new System.Drawing.Size(10, 86);
            this.pcbx_section_line2.TabIndex = 27;
            this.pcbx_section_line2.TabStop = false;
            // 
            // pcbx_section_line1
            // 
            this.pcbx_section_line1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pcbx_section_line1.Location = new System.Drawing.Point(174, 0);
            this.pcbx_section_line1.Name = "pcbx_section_line1";
            this.pcbx_section_line1.Size = new System.Drawing.Size(10, 86);
            this.pcbx_section_line1.TabIndex = 4;
            this.pcbx_section_line1.TabStop = false;
            // 
            // lbl_color_used
            // 
            this.lbl_color_used.AutoSize = true;
            this.lbl_color_used.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_color_used.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_color_used.ForeColor = System.Drawing.Color.White;
            this.lbl_color_used.Location = new System.Drawing.Point(100, 64);
            this.lbl_color_used.Name = "lbl_color_used";
            this.lbl_color_used.Size = new System.Drawing.Size(68, 13);
            this.lbl_color_used.TabIndex = 3;
            this.lbl_color_used.Text = "Used color";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pcbx_bg
            // 
            this.pcbx_bg.BackColor = System.Drawing.Color.White;
            this.pcbx_bg.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbx_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbx_bg.Location = new System.Drawing.Point(0, 0);
            this.pcbx_bg.Name = "pcbx_bg";
            this.pcbx_bg.Size = new System.Drawing.Size(800, 450);
            this.pcbx_bg.TabIndex = 3;
            this.pcbx_bg.TabStop = false;
            this.pcbx_bg.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbx_bg_Paint);
            this.pcbx_bg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcbx_bg_MouseClick);
            this.pcbx_bg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbx_bg_MouseDown);
            this.pcbx_bg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbx_bg_MouseMove);
            this.pcbx_bg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbx_bg_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_toolbar);
            this.Controls.Add(this.pcbx_bg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CS.Painter - HIT project by Tamir & Leor";
            this.pnl_toolbar.ResumeLayout(false);
            this.pnl_toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_section_line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_section_line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_section_line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_bg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Panel pnl_toolbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pcbx_bg;
        private System.Windows.Forms.Label lbl_color_used;
        private System.Windows.Forms.PictureBox pcbx_section_line1;
        private System.Windows.Forms.PictureBox pcbx_section_line2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btl_Ellipse;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Label lbl_Line;
        private System.Windows.Forms.Label lbl_Rectangle;
        private System.Windows.Forms.Label lbl_Ellipse;
        public System.Windows.Forms.Button btl_Rectangle;
        private System.Windows.Forms.Label lbl_fill;
        private System.Windows.Forms.Label lbl_eraser;
        private System.Windows.Forms.Label lbl_Pen;
        private System.Windows.Forms.PictureBox pcbx_section_line3;
        public System.Windows.Forms.Button btn_Fill;
        private System.Windows.Forms.Button btn_Eraser;
        private System.Windows.Forms.Button btn_Pen;
        private System.Windows.Forms.Button btn_Save_img;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TrackBar TKB_Size;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.Button btn_used_color;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

