
namespace MomHudCustomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusText = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fontPreview = new System.Windows.Forms.Label();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tCrosshairStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.arrowsCrossCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.explain1 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.momVersionCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BHOP_crosshairCheckbox = new System.Windows.Forms.CheckBox();
            this.BHOP_viewmodelCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.applyButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(4, 423);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(718, 23);
            this.statusText.TabIndex = 0;
            this.statusText.Text = "press apply to create custom files";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fontPreview);
            this.tabPage1.Controls.Add(this.fontComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Font";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fontPreview
            // 
            this.fontPreview.AutoSize = true;
            this.fontPreview.Location = new System.Drawing.Point(7, 35);
            this.fontPreview.Name = "fontPreview";
            this.fontPreview.Size = new System.Drawing.Size(137, 13);
            this.fontPreview.TabIndex = 1;
            this.fontPreview.Text = "font preview coming soon :(";
            // 
            // fontComboBox
            // 
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Items.AddRange(new object[] {
            "default font",
            "avenir",
            "handel gothic",
            "surface"});
            this.fontComboBox.Location = new System.Drawing.Point(7, 7);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 21);
            this.fontComboBox.TabIndex = 0;
            this.fontComboBox.Text = "default font";
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tCrosshairStyleCheckBox);
            this.tabPage2.Controls.Add(this.arrowsCrossCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crosshair";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tCrosshairStyleCheckBox
            // 
            this.tCrosshairStyleCheckBox.AutoSize = true;
            this.tCrosshairStyleCheckBox.Location = new System.Drawing.Point(6, 29);
            this.tCrosshairStyleCheckBox.Name = "tCrosshairStyleCheckBox";
            this.tCrosshairStyleCheckBox.Size = new System.Drawing.Size(89, 17);
            this.tCrosshairStyleCheckBox.TabIndex = 3;
            this.tCrosshairStyleCheckBox.Text = "Use \"T\" style";
            this.tCrosshairStyleCheckBox.UseVisualStyleBackColor = true;
            // 
            // arrowsCrossCheckBox
            // 
            this.arrowsCrossCheckBox.AutoSize = true;
            this.arrowsCrossCheckBox.Location = new System.Drawing.Point(6, 6);
            this.arrowsCrossCheckBox.Name = "arrowsCrossCheckBox";
            this.arrowsCrossCheckBox.Size = new System.Drawing.Size(126, 17);
            this.arrowsCrossCheckBox.TabIndex = 2;
            this.arrowsCrossCheckBox.Text = "Use Arrows Crosshair";
            this.arrowsCrossCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.explain1);
            this.tabPage3.Controls.Add(this.colorComboBox);
            this.tabPage3.Controls.Add(this.momVersionCheckBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hud";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // explain1
            // 
            this.explain1.AutoSize = true;
            this.explain1.Location = new System.Drawing.Point(6, 38);
            this.explain1.Name = "explain1";
            this.explain1.Size = new System.Drawing.Size(70, 13);
            this.explain1.TabIndex = 3;
            this.explain1.Text = "color scheme";
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "blue (default)",
            "green",
            "pink"});
            this.colorComboBox.Location = new System.Drawing.Point(5, 54);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 2;
            this.colorComboBox.Text = "blue (default)";
            // 
            // momVersionCheckBox
            // 
            this.momVersionCheckBox.AutoSize = true;
            this.momVersionCheckBox.Location = new System.Drawing.Point(6, 6);
            this.momVersionCheckBox.Name = "momVersionCheckBox";
            this.momVersionCheckBox.Size = new System.Drawing.Size(120, 17);
            this.momVersionCheckBox.TabIndex = 1;
            this.momVersionCheckBox.Text = "Show MOM Version";
            this.momVersionCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gamemode";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(1, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(788, 393);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.BHOP_crosshairCheckbox);
            this.tabPage5.Controls.Add(this.BHOP_viewmodelCheckbox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(780, 367);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "bhop";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // BHOP_crosshairCheckbox
            // 
            this.BHOP_crosshairCheckbox.AutoSize = true;
            this.BHOP_crosshairCheckbox.Checked = true;
            this.BHOP_crosshairCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BHOP_crosshairCheckbox.Location = new System.Drawing.Point(7, 30);
            this.BHOP_crosshairCheckbox.Name = "BHOP_crosshairCheckbox";
            this.BHOP_crosshairCheckbox.Size = new System.Drawing.Size(105, 17);
            this.BHOP_crosshairCheckbox.TabIndex = 1;
            this.BHOP_crosshairCheckbox.Text = "Enable Crosshair";
            this.BHOP_crosshairCheckbox.UseVisualStyleBackColor = true;
            // 
            // BHOP_viewmodelCheckbox
            // 
            this.BHOP_viewmodelCheckbox.AutoSize = true;
            this.BHOP_viewmodelCheckbox.Checked = true;
            this.BHOP_viewmodelCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BHOP_viewmodelCheckbox.Location = new System.Drawing.Point(7, 7);
            this.BHOP_viewmodelCheckbox.Name = "BHOP_viewmodelCheckbox";
            this.BHOP_viewmodelCheckbox.Size = new System.Drawing.Size(113, 17);
            this.BHOP_viewmodelCheckbox.TabIndex = 0;
            this.BHOP_viewmodelCheckbox.Text = "Enable Viewmodel";
            this.BHOP_viewmodelCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(777, 363);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "surf";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(777, 363);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "defrag";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(777, 363);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "ahop";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(777, 363);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "conc";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(721, 423);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MOM Customizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox tCrosshairStyleCheckBox;
        private System.Windows.Forms.CheckBox arrowsCrossCheckBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox momVersionCheckBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox BHOP_crosshairCheckbox;
        private System.Windows.Forms.CheckBox BHOP_viewmodelCheckbox;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label fontPreview;
        private System.Windows.Forms.Label explain1;
        private System.Windows.Forms.ComboBox colorComboBox;
    }
}

