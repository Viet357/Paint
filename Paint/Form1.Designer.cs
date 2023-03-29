namespace Paint
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
            this.lbLocation = new System.Windows.Forms.Label();
            this.btnLineSize = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.ptbColor = new System.Windows.Forms.PictureBox();
            this.ptbEditColor = new System.Windows.Forms.PictureBox();
            this.ptbDrawing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.ForeColor = System.Drawing.Color.Black;
            this.lbLocation.Location = new System.Drawing.Point(13, 768);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(24, 16);
            this.lbLocation.TabIndex = 20;
            this.lbLocation.Text = "0:0";
            // 
            // btnLineSize
            // 
            this.btnLineSize.Location = new System.Drawing.Point(663, 31);
            this.btnLineSize.Margin = new System.Windows.Forms.Padding(4);
            this.btnLineSize.Name = "btnLineSize";
            this.btnLineSize.Size = new System.Drawing.Size(133, 56);
            this.btnLineSize.TabIndex = 22;
            this.btnLineSize.Scroll += new System.EventHandler(this.btnLineSize_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnBezier);
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(444, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 110);
            this.panel1.TabIndex = 24;
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.Transparent;
            this.btnBezier.BackgroundImage = global::Paint.Properties.Resources._105123;
            this.btnBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBezier.Location = new System.Drawing.Point(127, 4);
            this.btnBezier.Margin = new System.Windows.Forms.Padding(4);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(50, 46);
            this.btnBezier.TabIndex = 29;
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.Transparent;
            this.btnPolygon.BackgroundImage = global::Paint.Properties.Resources.polygon;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.Location = new System.Drawing.Point(70, 58);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(4);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(49, 46);
            this.btnPolygon.TabIndex = 28;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Location = new System.Drawing.Point(8, 58);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(48, 46);
            this.btnRectangle.TabIndex = 27;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Location = new System.Drawing.Point(67, 4);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(52, 46);
            this.btnEllipse.TabIndex = 26;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.BackgroundImage = global::Paint.Properties.Resources.Line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Location = new System.Drawing.Point(4, 4);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(52, 46);
            this.btnLine.TabIndex = 25;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(707, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(815, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Color";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.btnUnGroup);
            this.panel3.Controls.Add(this.btnGroup);
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(166, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 110);
            this.panel3.TabIndex = 27;
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnUnGroup.BackgroundImage = global::Paint.Properties.Resources.ungroup;
            this.btnUnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnGroup.Location = new System.Drawing.Point(65, 4);
            this.btnUnGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(54, 49);
            this.btnUnGroup.TabIndex = 29;
            this.btnUnGroup.UseVisualStyleBackColor = false;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnGroup.BackgroundImage = global::Paint.Properties.Resources.group;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.Location = new System.Drawing.Point(4, 4);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(53, 49);
            this.btnGroup.TabIndex = 29;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundImage = global::Paint.Properties.Resources.selection;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Location = new System.Drawing.Point(65, 57);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(54, 49);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Paint.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(4, 57);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 49);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnOpen);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(27, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 110);
            this.panel4.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::Paint.Properties.Resources._9755169;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(65, 57);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 49);
            this.btnClear.TabIndex = 29;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImage = global::Paint.Properties.Resources._5082617;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(4, 57);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 49);
            this.btnOpen.TabIndex = 31;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Paint.Properties.Resources._2874050;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(65, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 49);
            this.btnSave.TabIndex = 30;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = global::Paint.Properties.Resources._4202611;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Location = new System.Drawing.Point(4, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 49);
            this.btnNew.TabIndex = 29;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnEraser);
            this.panel2.Controls.Add(this.btnPen);
            this.panel2.Controls.Add(this.btnFill);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(304, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 110);
            this.panel2.TabIndex = 28;
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Transparent;
            this.btnEraser.BackgroundImage = global::Paint.Properties.Resources._483907;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEraser.Location = new System.Drawing.Point(4, 57);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(53, 49);
            this.btnEraser.TabIndex = 31;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.Transparent;
            this.btnPen.BackgroundImage = global::Paint.Properties.Resources._1250925;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.Location = new System.Drawing.Point(65, 4);
            this.btnPen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(54, 49);
            this.btnPen.TabIndex = 30;
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Transparent;
            this.btnFill.BackgroundImage = global::Paint.Properties.Resources._7180272;
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFill.Location = new System.Drawing.Point(4, 4);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(53, 49);
            this.btnFill.TabIndex = 29;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // ptbColor
            // 
            this.ptbColor.BackColor = System.Drawing.Color.Black;
            this.ptbColor.Location = new System.Drawing.Point(860, 57);
            this.ptbColor.Margin = new System.Windows.Forms.Padding(4);
            this.ptbColor.Name = "ptbColor";
            this.ptbColor.Size = new System.Drawing.Size(21, 21);
            this.ptbColor.TabIndex = 21;
            this.ptbColor.TabStop = false;
            this.ptbColor.Click += new System.EventHandler(this.ptbColor_Click);
            // 
            // ptbEditColor
            // 
            this.ptbEditColor.BackColor = System.Drawing.Color.Transparent;
            this.ptbEditColor.BackgroundImage = global::Paint.Properties.Resources.wheel;
            this.ptbEditColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbEditColor.Location = new System.Drawing.Point(814, 16);
            this.ptbEditColor.Margin = new System.Windows.Forms.Padding(4);
            this.ptbEditColor.Name = "ptbEditColor";
            this.ptbEditColor.Size = new System.Drawing.Size(67, 62);
            this.ptbEditColor.TabIndex = 23;
            this.ptbEditColor.TabStop = false;
            this.ptbEditColor.Click += new System.EventHandler(this.ptbEditColor_Click);
            // 
            // ptbDrawing
            // 
            this.ptbDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbDrawing.Location = new System.Drawing.Point(27, 128);
            this.ptbDrawing.Name = "ptbDrawing";
            this.ptbDrawing.Size = new System.Drawing.Size(917, 622);
            this.ptbDrawing.TabIndex = 0;
            this.ptbDrawing.TabStop = false;
            this.ptbDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint_event);
            this.ptbDrawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseClick);
            this.ptbDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseDown);
            this.ptbDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseMove);
            this.ptbDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(967, 793);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbColor);
            this.Controls.Add(this.ptbEditColor);
            this.Controls.Add(this.btnLineSize);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.ptbDrawing);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbDrawing;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.PictureBox ptbColor;
        private System.Windows.Forms.TrackBar btnLineSize;
        private System.Windows.Forms.PictureBox ptbEditColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
    }
}

