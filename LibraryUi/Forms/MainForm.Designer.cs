﻿namespace LibraryUi;

partial class MainForm
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
        label1 = new Label();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(317, 268);
        label1.Name = "label1";
        label1.Size = new Size(0, 20);
        label1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new Point(110, 179);
        button1.Name = "button1";
        button1.Size = new Size(94, 57);
        button1.TabIndex = 2;
        button1.Text = "Work with the client";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // button2
        // 
        button2.Location = new Point(341, 179);
        button2.Name = "button2";
        button2.Size = new Size(94, 57);
        button2.TabIndex = 3;
        button2.Text = "Order";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(568, 179);
        button3.Name = "button3";
        button3.Size = new Size(94, 57);
        button3.TabIndex = 4;
        button3.Text = "Catalog of books";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "MainForm";
        Text = "MainForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Button button1;
    private Button button2;
    private Button button3;
}
