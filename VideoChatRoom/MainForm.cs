using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using OMCS.Passive;

namespace VideoChatRoom
{
    public partial class MainForm : Form
    {
        private IMultimediaManager multimediaManager;
        public MainForm(IMultimediaManager mgr ,string chatRoomID)
        {
            InitializeComponent();

            this.multimediaManager = mgr;
            this.Text = this.Text + " - " + chatRoomID;
            this.skinLabel_userID.Text = this.multimediaManager.CurrentUserID;            
            this.multiVideoChatContainer1.Initialize(this.multimediaManager, chatRoomID);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.multiVideoChatContainer1.Close();
            this.multimediaManager.Dispose();
        }
    }
}
