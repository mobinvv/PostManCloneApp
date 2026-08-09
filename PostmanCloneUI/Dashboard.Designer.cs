namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsText = new TextBox();
            resultsLabel = new Label();
            apiLabel = new Label();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(31, 22);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(218, 41);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiText
            // 
            apiText.Location = new Point(68, 104);
            apiText.Name = "apiText";
            apiText.Size = new Size(528, 27);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(602, 104);
            callApi.Name = "callApi";
            callApi.Size = new Size(43, 29);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = SystemColors.Window;
            resultsText.Location = new Point(31, 218);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(614, 226);
            resultsText.TabIndex = 4;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsLabel.Location = new Point(31, 169);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(104, 38);
            resultsLabel.TabIndex = 5;
            resultsLabel.Text = "Results";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(28, 108);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(34, 20);
            apiLabel.TabIndex = 6;
            apiLabel.Text = "API:";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 424);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 26);
            statusStrip.TabIndex = 7;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(50, 20);
            systemStatus.Text = "Ready";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(apiLabel);
            Controls.Add(resultsLabel);
            Controls.Add(resultsText);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Dashboard";
            Text = "Postman Clone by Mobina";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label label2;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private Label resultsLabel;
        private Label apiLabel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
    }
}
