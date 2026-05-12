using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WAV_Player
{
    public partial class frmWAVPlayer : Form
    {
        SoundPlayer player; // 宣告播放器物件為類別成員變數，讓所有事件都能使用它
        public frmWAVPlayer()
        {
            InitializeComponent();
        }

        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // 過濾條件設定為WAV檔案
            this.ofdWAVFile.Filter = "WAV Files(*.wav)|*.wav";
            // 打開檔案對話方塊
            if (this.ofdWAVFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.ofdWAVFile.FileName;
            }
        }

        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                player = new SoundPlayer(); // 建立播放器物件
                player.SoundLocation = txtPath.Text; // 指定音效所在路徑檔名
                player.Load(); // 載入音效檔資料
                player.Play();
                //player.PlaySync(); // 同步播放，直到播放結束才繼續執行後續程式碼
                //MessageBox.Show("音效播放完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex){
                MessageBox.Show("播放音效檔失敗！\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        
        private void btnLoop_Click(object sender, EventArgs e)
        {
            // 使用完整檔名建立物件
            player = new SoundPlayer(txtPath.Text);
            player.PlayLooping(); // 重複播放
        }

        
        private void btnStop_Click(object sender, EventArgs e)
        {
            //FileStream fsWAV = new FileStream(txtPath.Text, FileMode.Open);
            // 使用檔案串流建立物件
            //SoundPlayer player = new SoundPlayer(fsWAV);
            player.Stop(); // 停止播放
            //fsWAV.Close();
        }

        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        
        // 注意：這個事件要到 Form 的屬性視窗 -> 點擊閃電圖示 (事件) -> 找到 FormClosing 點兩下產生
        private void frmWAVPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 取消關閉
            }
        }

    }
}
