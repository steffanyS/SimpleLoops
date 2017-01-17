namespace Turtle_Graphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.Hexagon = new System.Windows.Forms.Button();
            this.Star = new System.Windows.Forms.Button();
            this.Spiral = new System.Windows.Forms.Button();
            this.Sun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(0, 0);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(0, 39);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(0, 77);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(75, 23);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // Hexagon
            // 
            this.Hexagon.Location = new System.Drawing.Point(0, 119);
            this.Hexagon.Name = "Hexagon";
            this.Hexagon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Hexagon.Size = new System.Drawing.Size(75, 23);
            this.Hexagon.TabIndex = 3;
            this.Hexagon.Text = "Hexagon";
            this.Hexagon.UseVisualStyleBackColor = true;
            this.Hexagon.Click += new System.EventHandler(this.Hexagon_Click);
            // 
            // Star
            // 
            this.Star.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Star.Location = new System.Drawing.Point(0, 161);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(75, 23);
            this.Star.TabIndex = 4;
            this.Star.Text = "Star";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // Spiral
            // 
            this.Spiral.Location = new System.Drawing.Point(0, 203);
            this.Spiral.Name = "Spiral";
            this.Spiral.Size = new System.Drawing.Size(75, 23);
            this.Spiral.TabIndex = 5;
            this.Spiral.Text = "Spiral";
            this.Spiral.UseVisualStyleBackColor = true;
            this.Spiral.Click += new System.EventHandler(this.Spiral_Click);
            // 
            // Sun
            // 
            this.Sun.Location = new System.Drawing.Point(0, 241);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(75, 23);
            this.Sun.TabIndex = 6;
            this.Sun.Text = "Sun";
            this.Sun.UseVisualStyleBackColor = true;
            this.Sun.Click += new System.EventHandler(this.Sun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 407);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.Spiral);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.Hexagon);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Turtle Graphics - Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button Hexagon;
        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.Button Spiral;
        private System.Windows.Forms.Button Sun;
    }
}

