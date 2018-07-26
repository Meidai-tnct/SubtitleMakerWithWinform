using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitleMakerWithForms
{
    public partial class Form1 : Form
    {
        // 歌詞ファイルを作成するソフト。だいたい45分くらいで作った。→結果1本作るのに2時間かかった

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            tb_source.Text = Clipboard.GetText();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_input.Text = tb_source.Text;
            tb_output.Clear();
            btn_serial_init.PerformClick();

            tb_input.Text += "\n\n";

            // 一番上の行を選択
            tb_input.Select(0, tb_input.Text.IndexOf("\n"));
        }

        private string DoubleTimeToString(double time_bySec)
        {
            //00:00:10,000

            int hour = (int)time_bySec / 3600;
            int min = (int)(time_bySec % 3600)/60;
            int sec = (int)time_bySec % 60;
            int msec = (int)(time_bySec * 1000) % 1000;

            return hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00") + "," + msec.ToString("000");
        }

        private void setStart()
        {
            if (!string.IsNullOrEmpty(tb_time_ed.Text))
            {
                return;
            }

            //00:00:10,000
            tb_time_st.Text = DoubleTimeToString(media.Ctlcontrols.currentPosition);
        }

        private void setEnd()
        {
            if (string.IsNullOrEmpty(tb_time_st.Text))
            {
                return;
            }

            //00:00:10,000
            tb_time_ed.Text = DoubleTimeToString(media.Ctlcontrols.currentPosition);

        }

        private void insertText()
        {
            // 選択範囲を取得
            string text = tb_input.SelectedText.Replace("\n",string.Empty);

            // 出力
            tb_output.Text += tb_serial.Text + "\r\n" + tb_time_st.Text + " --> " + tb_time_ed.Text + "\r\n" + text + "\r\n\r\n";
            tb_serial.Text = (int.Parse(tb_serial.Text) + 1).ToString();
            Clipboard.SetText(tb_output.Text);

            tb_time_st.Clear();
            tb_time_ed.Clear();


            // 一番上の行を削除、空行を飛ばす
            tb_input.Text = tb_input.Text.Substring(tb_input.Text.IndexOf("\n") + 1);
            if (string.IsNullOrWhiteSpace(tb_input.Text) || tb_input.Text.IndexOf("\n") < 0)
            {
                MessageBox.Show("ソースの最後です");
                return;
            }
            while (string.IsNullOrWhiteSpace(tb_input.Text.Substring(0, tb_input.Text.IndexOf("\n"))))
            {
                tb_input.Text = tb_input.Text.Substring(tb_input.Text.IndexOf("\n") + 1);
                if (string.IsNullOrWhiteSpace(tb_input.Text)||tb_input.Text.IndexOf("\n")<0)
                {
                    MessageBox.Show("ソースの最後です");
                    return;
                }
            }

            // 一番上の行を選択
            tb_input.Select(0, tb_input.Text.IndexOf("\n"));

            //カレット位置を末尾に移動
            tb_output.SelectionStart = tb_output.Text.Length;
            //テキストボックスにフォーカスを移動
            tb_output.Focus();
            //カレット位置までスクロール
            tb_output.ScrollToCaret();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            setStart();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            setEnd();
            insertText();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            setEnd();
            insertText();
            setStart();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_output.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string dir = media.URL.Substring(0, media.URL.LastIndexOf("\\"));
            string name = media.URL.Substring(media.URL.LastIndexOf("\\")+1);

            //書き込むファイルが既に存在している場合は、上書きする
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
               dir + "\\" + name.Substring(0, name.LastIndexOf(".")) + ".srt", false);
            //TextBox1.Textの内容を書き込む
            sw.Write(tb_output.Text.Replace("\r",string.Empty));
            //閉じる
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_serial.Text = "1";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                media.URL = openFileDialog1.FileName;
                System.Diagnostics.Debug.WriteLine(media.URL + "を開きました");
            }
        }

        private void btn_serial_init_Click(object sender, EventArgs e)
        {
            tb_serial.Text = "1";
        }

        private void btn_back5s_Click(object sender, EventArgs e)
        {
            media.Ctlcontrols.currentPosition = media.Ctlcontrols.currentPosition - 5;
        }
    }
}
