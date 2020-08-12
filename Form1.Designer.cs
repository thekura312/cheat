namespace Exploit_Template_with_WRDAPI
{
    partial class cheat
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
            this.inputScript = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnBtools = new System.Windows.Forms.Button();
            this.inputTPTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTPTo = new System.Windows.Forms.Button();
            this.txtIsInjected = new System.Windows.Forms.Label();
            this.InjectedChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // inputScript
            // 
            this.inputScript.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputScript.Location = new System.Drawing.Point(10, 54);
            this.inputScript.Margin = new System.Windows.Forms.Padding(2);
            this.inputScript.Name = "inputScript";
            this.inputScript.Size = new System.Drawing.Size(524, 232);
            this.inputScript.TabIndex = 1;
            this.inputScript.Text = "--paste your script here\nprint(\"Hello from the kura\")";
            this.inputScript.TextChanged += new System.EventHandler(this.inputScript_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(10, 290);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(119, 32);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // btnInject
            // 
            this.btnInject.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInject.Location = new System.Drawing.Point(10, 9);
            this.btnInject.Margin = new System.Windows.Forms.Padding(2);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(109, 41);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Attach";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // btnBtools
            // 
            this.btnBtools.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtools.Location = new System.Drawing.Point(416, 290);
            this.btnBtools.Margin = new System.Windows.Forms.Padding(2);
            this.btnBtools.Name = "btnBtools";
            this.btnBtools.Size = new System.Drawing.Size(118, 34);
            this.btnBtools.TabIndex = 4;
            this.btnBtools.Text = "BTools";
            this.btnBtools.UseVisualStyleBackColor = true;
            this.btnBtools.Click += new System.EventHandler(this.BtnBtools_Click);
            // 
            // inputTPTo
            // 
            this.inputTPTo.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTPTo.ForeColor = System.Drawing.Color.Gray;
            this.inputTPTo.Location = new System.Drawing.Point(218, 295);
            this.inputTPTo.Margin = new System.Windows.Forms.Padding(2);
            this.inputTPTo.Name = "inputTPTo";
            this.inputTPTo.Size = new System.Drawing.Size(118, 24);
            this.inputTPTo.TabIndex = 5;
            this.inputTPTo.Text = "PlrUsername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "TP To:";
            // 
            // btnTPTo
            // 
            this.btnTPTo.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTo.Location = new System.Drawing.Point(340, 290);
            this.btnTPTo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTPTo.Name = "btnTPTo";
            this.btnTPTo.Size = new System.Drawing.Size(66, 34);
            this.btnTPTo.TabIndex = 7;
            this.btnTPTo.Text = "Go";
            this.btnTPTo.UseVisualStyleBackColor = true;
            this.btnTPTo.Click += new System.EventHandler(this.BtnTPTo_Click);
            // 
            // txtIsInjected
            // 
            this.txtIsInjected.AutoSize = true;
            this.txtIsInjected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsInjected.Location = new System.Drawing.Point(123, 17);
            this.txtIsInjected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIsInjected.Name = "txtIsInjected";
            this.txtIsInjected.Size = new System.Drawing.Size(125, 20);
            this.txtIsInjected.TabIndex = 9;
            this.txtIsInjected.Text = "Is Injected: false";
            this.txtIsInjected.Click += new System.EventHandler(this.txtIsInjected_Click);
            // 
            // InjectedChecker
            // 
            this.InjectedChecker.Enabled = true;
            this.InjectedChecker.Interval = 3000;
            this.InjectedChecker.Tick += new System.EventHandler(this.InjectedChecker_Tick);
            // 
            // cheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 330);
            this.Controls.Add(this.txtIsInjected);
            this.Controls.Add(this.btnTPTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTPTo);
            this.Controls.Add(this.btnBtools);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.inputScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cheat";
            this.Opacity = 0.89D;
            this.Text = "cheat";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox inputScript;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnBtools;
        private System.Windows.Forms.TextBox inputTPTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTPTo;
        private System.Windows.Forms.Label txtIsInjected;
        private System.Windows.Forms.Timer InjectedChecker;
    }
}

