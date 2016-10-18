namespace RadioButtonsTest2
{
    partial class RadioButtonForm
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retryCancelButton = new System.Windows.Forms.RadioButton();
            this.yesNoButton = new System.Windows.Forms.RadioButton();
            this.yesNoCancelButton = new System.Windows.Forms.RadioButton();
            this.abortRetryIgnoreButton = new System.Windows.Forms.RadioButton();
            this.okCancelButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.questionButton = new System.Windows.Forms.RadioButton();
            this.informationButton = new System.Windows.Forms.RadioButton();
            this.exclamationButton = new System.Windows.Forms.RadioButton();
            this.errorButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(27, 33);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(103, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Choose Type of Box";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retryCancelButton);
            this.groupBox1.Controls.Add(this.yesNoButton);
            this.groupBox1.Controls.Add(this.yesNoCancelButton);
            this.groupBox1.Controls.Add(this.abortRetryIgnoreButton);
            this.groupBox1.Controls.Add(this.okCancelButton);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button Type";
            // 
            // retryCancelButton
            // 
            this.retryCancelButton.AutoSize = true;
            this.retryCancelButton.Location = new System.Drawing.Point(13, 248);
            this.retryCancelButton.Name = "retryCancelButton";
            this.retryCancelButton.Size = new System.Drawing.Size(83, 17);
            this.retryCancelButton.TabIndex = 5;
            this.retryCancelButton.TabStop = true;
            this.retryCancelButton.Text = "RetryCancel";
            this.retryCancelButton.UseVisualStyleBackColor = true;
            this.retryCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // yesNoButton
            // 
            this.yesNoButton.AutoSize = true;
            this.yesNoButton.Location = new System.Drawing.Point(14, 207);
            this.yesNoButton.Name = "yesNoButton";
            this.yesNoButton.Size = new System.Drawing.Size(57, 17);
            this.yesNoButton.TabIndex = 4;
            this.yesNoButton.TabStop = true;
            this.yesNoButton.Text = "YesNo";
            this.yesNoButton.UseVisualStyleBackColor = true;
            this.yesNoButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // yesNoCancelButton
            // 
            this.yesNoCancelButton.AutoSize = true;
            this.yesNoCancelButton.Location = new System.Drawing.Point(14, 166);
            this.yesNoCancelButton.Name = "yesNoCancelButton";
            this.yesNoCancelButton.Size = new System.Drawing.Size(90, 17);
            this.yesNoCancelButton.TabIndex = 3;
            this.yesNoCancelButton.TabStop = true;
            this.yesNoCancelButton.Text = "YesNoCancel";
            this.yesNoCancelButton.UseVisualStyleBackColor = true;
            this.yesNoCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // abortRetryIgnoreButton
            // 
            this.abortRetryIgnoreButton.AutoSize = true;
            this.abortRetryIgnoreButton.Location = new System.Drawing.Point(13, 119);
            this.abortRetryIgnoreButton.Name = "abortRetryIgnoreButton";
            this.abortRetryIgnoreButton.Size = new System.Drawing.Size(105, 17);
            this.abortRetryIgnoreButton.TabIndex = 2;
            this.abortRetryIgnoreButton.TabStop = true;
            this.abortRetryIgnoreButton.Text = "AbortRetryIgnore";
            this.abortRetryIgnoreButton.UseVisualStyleBackColor = true;
            this.abortRetryIgnoreButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // okCancelButton
            // 
            this.okCancelButton.AutoSize = true;
            this.okCancelButton.Location = new System.Drawing.Point(14, 78);
            this.okCancelButton.Name = "okCancelButton";
            this.okCancelButton.Size = new System.Drawing.Size(73, 17);
            this.okCancelButton.TabIndex = 1;
            this.okCancelButton.TabStop = true;
            this.okCancelButton.Text = "OKCancel";
            this.okCancelButton.UseVisualStyleBackColor = true;
            this.okCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(14, 35);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(40, 17);
            this.okButton.TabIndex = 0;
            this.okButton.TabStop = true;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(260, 314);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(200, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(257, 353);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(35, 13);
            this.displayLabel.TabIndex = 3;
            this.displayLabel.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.questionButton);
            this.groupBox2.Controls.Add(this.informationButton);
            this.groupBox2.Controls.Add(this.exclamationButton);
            this.groupBox2.Controls.Add(this.errorButton);
            this.groupBox2.Location = new System.Drawing.Point(260, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon Type";
            // 
            // questionButton
            // 
            this.questionButton.AutoSize = true;
            this.questionButton.Location = new System.Drawing.Point(25, 166);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(67, 17);
            this.questionButton.TabIndex = 3;
            this.questionButton.TabStop = true;
            this.questionButton.Text = "Question";
            this.questionButton.UseVisualStyleBackColor = true;
            this.questionButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // informationButton
            // 
            this.informationButton.AutoSize = true;
            this.informationButton.Location = new System.Drawing.Point(25, 119);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(77, 17);
            this.informationButton.TabIndex = 2;
            this.informationButton.TabStop = true;
            this.informationButton.Text = "Information";
            this.informationButton.UseVisualStyleBackColor = true;
            this.informationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // exclamationButton
            // 
            this.exclamationButton.AutoSize = true;
            this.exclamationButton.Location = new System.Drawing.Point(25, 78);
            this.exclamationButton.Name = "exclamationButton";
            this.exclamationButton.Size = new System.Drawing.Size(82, 17);
            this.exclamationButton.TabIndex = 1;
            this.exclamationButton.TabStop = true;
            this.exclamationButton.Text = "Exclamation";
            this.exclamationButton.UseVisualStyleBackColor = true;
            this.exclamationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // errorButton
            // 
            this.errorButton.AutoSize = true;
            this.errorButton.Location = new System.Drawing.Point(25, 35);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(47, 17);
            this.errorButton.TabIndex = 0;
            this.errorButton.TabStop = true;
            this.errorButton.Text = "Error";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
            // 
            // RadioButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.promptLabel);
            this.Name = "RadioButtonForm";
            this.Text = "Demonstrating Radio Button Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.RadioButton yesNoCancelButton;
        private System.Windows.Forms.RadioButton abortRetryIgnoreButton;
        private System.Windows.Forms.RadioButton okCancelButton;
        private System.Windows.Forms.RadioButton okButton;
        private System.Windows.Forms.RadioButton retryCancelButton;
        private System.Windows.Forms.RadioButton yesNoButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton errorButton;
        private System.Windows.Forms.RadioButton questionButton;
        private System.Windows.Forms.RadioButton informationButton;
        private System.Windows.Forms.RadioButton exclamationButton;
    }
}

