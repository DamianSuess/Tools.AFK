namespace Tools.MouseMove
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
      this.BtnStart = new System.Windows.Forms.Button();
      this.BtnStop = new System.Windows.Forms.Button();
      this.UdInterval = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.ChkBoundToForm = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.UdInterval)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnStart
      // 
      this.BtnStart.Location = new System.Drawing.Point(12, 12);
      this.BtnStart.Name = "BtnStart";
      this.BtnStart.Size = new System.Drawing.Size(75, 23);
      this.BtnStart.TabIndex = 0;
      this.BtnStart.Text = "Start";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
      // 
      // BtnStop
      // 
      this.BtnStop.Location = new System.Drawing.Point(99, 12);
      this.BtnStop.Name = "BtnStop";
      this.BtnStop.Size = new System.Drawing.Size(75, 23);
      this.BtnStop.TabIndex = 1;
      this.BtnStop.Text = "Stop";
      this.BtnStop.UseVisualStyleBackColor = true;
      this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
      // 
      // UdInterval
      // 
      this.UdInterval.Location = new System.Drawing.Point(93, 41);
      this.UdInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.UdInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.UdInterval.Name = "UdInterval";
      this.UdInterval.Size = new System.Drawing.Size(81, 20);
      this.UdInterval.TabIndex = 2;
      this.UdInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Interval (min)";
      // 
      // ChkBoundToForm
      // 
      this.ChkBoundToForm.AutoSize = true;
      this.ChkBoundToForm.Location = new System.Drawing.Point(16, 67);
      this.ChkBoundToForm.Name = "ChkBoundToForm";
      this.ChkBoundToForm.Size = new System.Drawing.Size(111, 17);
      this.ChkBoundToForm.TabIndex = 4;
      this.ChkBoundToForm.Text = "Bound to Window";
      this.ChkBoundToForm.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(187, 94);
      this.Controls.Add(this.ChkBoundToForm);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.UdInterval);
      this.Controls.Add(this.BtnStop);
      this.Controls.Add(this.BtnStart);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Move my mouse";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.UdInterval)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnStart;
    private System.Windows.Forms.Button BtnStop;
    private System.Windows.Forms.NumericUpDown UdInterval;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox ChkBoundToForm;
  }
}

