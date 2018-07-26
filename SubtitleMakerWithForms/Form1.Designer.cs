namespace SubtitleMakerWithForms
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_time_st = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_time_ed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_paste = new System.Windows.Forms.Button();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_serial_init = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_back5s = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.SuspendLayout();
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(12, 12);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(342, 256);
            this.media.TabIndex = 0;
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(391, 37);
            this.tb_source.Multiline = true;
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(359, 55);
            this.tb_source.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "字幕ソース";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(395, 275);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(359, 135);
            this.tb_output.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "開始";
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(679, 416);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 3;
            this.btn_copy.Text = "コピー(&C)";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(681, 232);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(75, 23);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "連続(&D)";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(600, 232);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(75, 23);
            this.btn_finish.TabIndex = 3;
            this.btn_finish.Text = "終了(&F)";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(519, 232);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "開始(&S)";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(391, 123);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(359, 103);
            this.tb_input.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "入力";
            // 
            // tb_time_st
            // 
            this.tb_time_st.Location = new System.Drawing.Point(61, 358);
            this.tb_time_st.Name = "tb_time_st";
            this.tb_time_st.Size = new System.Drawing.Size(145, 19);
            this.tb_time_st.TabIndex = 4;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(675, 97);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "リセット(&R)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(395, 416);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保存(&A)";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "終了";
            // 
            // tb_time_ed
            // 
            this.tb_time_ed.Location = new System.Drawing.Point(61, 383);
            this.tb_time_ed.Name = "tb_time_ed";
            this.tb_time_ed.Size = new System.Drawing.Size(145, 19);
            this.tb_time_ed.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "出力";
            // 
            // btn_paste
            // 
            this.btn_paste.Location = new System.Drawing.Point(594, 97);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(75, 23);
            this.btn_paste.TabIndex = 3;
            this.btn_paste.Text = "貼り付け(&P)";
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // tb_serial
            // 
            this.tb_serial.Location = new System.Drawing.Point(61, 408);
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.Size = new System.Drawing.Size(145, 19);
            this.tb_serial.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "連番";
            // 
            // btn_serial_init
            // 
            this.btn_serial_init.Location = new System.Drawing.Point(212, 406);
            this.btn_serial_init.Name = "btn_serial_init";
            this.btn_serial_init.Size = new System.Drawing.Size(75, 23);
            this.btn_serial_init.TabIndex = 3;
            this.btn_serial_init.Text = "初期化(&I)";
            this.btn_serial_init.UseVisualStyleBackColor = true;
            this.btn_serial_init.Click += new System.EventHandler(this.btn_serial_init_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(268, 275);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(86, 23);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "読込・再生(&L)";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_back5s
            // 
            this.btn_back5s.Location = new System.Drawing.Point(176, 275);
            this.btn_back5s.Name = "btn_back5s";
            this.btn_back5s.Size = new System.Drawing.Size(86, 23);
            this.btn_back5s.TabIndex = 3;
            this.btn_back5s.Text = "5秒戻る(&B)";
            this.btn_back5s.UseVisualStyleBackColor = true;
            this.btn_back5s.Click += new System.EventHandler(this.btn_back5s_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_serial);
            this.Controls.Add(this.tb_time_ed);
            this.Controls.Add(this.tb_time_st);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_back5s);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_serial_init);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.media);
            this.Name = "Form1";
            this.Text = "字幕メーカー";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_time_st;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_time_ed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_serial_init;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_back5s;
    }
}

