namespace PW3SPP
{
    partial class ReadWriteForm
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
            textBox1 = new TextBox();
            OpenButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1238, 543);
            textBox1.TabIndex = 0;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(12, 561);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(614, 100);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Открыть";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButtonClick;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(634, 561);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(614, 100);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButtonClick;
            // 
            // ReadWriteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(SaveButton);
            Controls.Add(OpenButton);
            Controls.Add(textBox1);
            Name = "ReadWriteForm";
            Text = "Чтение / запись текстового файла в кодировке ANSI";
            Load += ReadWriteFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button OpenButton;
        private Button SaveButton;
    }
}
