using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OMCS.Passive;
using OMCS.Passive.MultiChat;
using ESBasic;
using OMCS.Contracts;

namespace VideoChatRoom
{
    public partial class MultiVideoChatContainer : UserControl
    {       
        private IMultimediaManager multimediaManager;
        private IChatGroup chatGroup;

        /// <summary>
        /// 当点击邀请好友的Button时，触发此事件。
        /// </summary>
        public event CbGeneric InviteFriendClick;

        public MultiVideoChatContainer()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// 双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);// 禁止擦除背景.
            this.SetStyle(ControlStyles.UserPaint, true);//自行绘制            
            this.UpdateStyles();
        }

        public void Close()
        {
            if (this.multimediaManager != null)
            {
                this.multimediaManager.AudioCaptured -= new ESBasic.CbGeneric<byte[]>(multimediaManager_AudioCaptured);
                this.multimediaManager.AudioPlayed -= new ESBasic.CbGeneric<byte[]>(multimediaManager_AudioPlayed);
                this.multimediaManager.ChatGroupEntrance.Exit(ChatType.Video, this.chatGroup.GroupID);
            }
        }

        public void Initialize(IMultimediaManager mgr, string chatGroupID)
        {             
            this.multimediaManager = mgr;
            this.chatGroup = this.multimediaManager.ChatGroupEntrance.Join(ChatType.Video, chatGroupID);

            this.decibelDisplayer_mic.Working = true;
            this.decibelDisplayer_speaker.Working = true;
            this.multimediaManager.AudioCaptured += new ESBasic.CbGeneric<byte[]>(multimediaManager_AudioCaptured);
            this.multimediaManager.AudioPlayed += new ESBasic.CbGeneric<byte[]>(multimediaManager_AudioPlayed);

            this.chatGroup.SomeoneJoin += new ESBasic.CbGeneric<IChatUnit>(chatGroup_SomeoneJoin);
            this.chatGroup.SomeoneExit += new CbGeneric<string>(chatGroup_SomeoneExit);

            VideoPanel myselfPanel = new VideoPanel();
            this.flowLayoutPanel1.Controls.Add(myselfPanel);
            myselfPanel.Initialize(this.chatGroup.MyChatUnit, true);
            //myselfPanel.Visible = false;
            myselfPanel.InitializeVideo(this.chatGroup.MyChatUnit, true);
            //版本0328
            string user_id = this.chatGroup.MyChatUnit.MemberID;
            if(user_id.Equals("会议室2"))  //如果myself是网格中心的话，聊天组里面的全部显示
            {
                foreach (IChatUnit unit in this.chatGroup.GetOtherMembers())
                {
                    VideoPanel panel0 = new VideoPanel();
                    this.flowLayoutPanel1.Controls.Add(panel0);
                    //panel.Visible = false;
                    panel0.Initialize(unit, false);
                    panel0.InitializeVideo(unit, false); 
                }

            }
            else  //如果myself不是的话，判断聊天组里有没有网格zx，如果有仅显示网格zx
            {
                foreach (IChatUnit unit in this.chatGroup.GetOtherMembers())
                {
                    if (unit.MemberID.Equals("会议室2"))
                    {
                        VideoPanel panel1 = new VideoPanel();
                        this.flowLayoutPanel1.Controls.Add(panel1);
                        //panel.Visible = false;
                        panel1.Initialize(unit, false);
                        panel1.InitializeVideo(unit, false);
                    }
                    else
                    {
                        VideoPanel panel2 = new VideoPanel();
                        this.flowLayoutPanel1.Controls.Add(panel2);
                        panel2.Visible = false;
                        panel2.Initialize(unit, false);

                    }
                }
            }

            this.groupBox_members.Text = string.Format("成员列表（{0}人）" ,this.flowLayoutPanel1.Controls.Count);

            this.flowLayoutPanel1_SizeChanged(this.flowLayoutPanel1, new EventArgs());
        }        

        void chatGroup_SomeoneExit(string memberID)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<string>(this.chatGroup_SomeoneExit), memberID);
            }
            else
            {
                VideoPanel target = null;
                foreach (VideoPanel panel in this.flowLayoutPanel1.Controls)
                {
                    if (panel.MemberID == memberID)
                    {
                        target = panel;
                        break;
                    }
                }

                if (target == null)
                {
                    return;
                }

                this.flowLayoutPanel1.Controls.Remove(target);
                this.groupBox_members.Text = string.Format("成员列表 （{0}人）", this.flowLayoutPanel1.Controls.Count);
                this.toolStripLabel1.Text = string.Format("{0} 退出了组!", memberID);
            }
        }

        void chatGroup_SomeoneJoin(IChatUnit unit)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<IChatUnit>(this.chatGroup_SomeoneJoin), unit);
            }
            else
            {
                if (unit.MemberID.Equals("会议室2"))
                {
                    VideoPanel panel = new VideoPanel();
                    this.flowLayoutPanel1.Controls.Add(panel);
                    panel.Initialize(unit, false);
                    panel.InitializeVideo(unit, false);
                }
                else
                {
                    VideoPanel panel = new VideoPanel();
                    this.flowLayoutPanel1.Controls.Add(panel);
                    panel.Initialize(unit, false);
                    panel.Visible = false;
                    //panel.InitializeVideo(unit, false);
 
                }
                this.groupBox_members.Text = string.Format("成员列表 （{0}人）", this.flowLayoutPanel1.Controls.Count);
                this.toolStripLabel1.Text = string.Format("{0} 加入了组!" ,unit.MemberID);
            }
        }              

        void multimediaManager_AudioPlayed(byte[] data)
        {
            this.decibelDisplayer_speaker.DisplayAudioData(data);
        }

        void multimediaManager_AudioCaptured(byte[] data)
        {
            this.decibelDisplayer_mic.DisplayAudioData(data);
        }
       
        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.decibelDisplayer_mic.Visible = this.skinCheckBox_mic.Checked;
            this.multimediaManager.OutputAudio = this.skinCheckBox_mic.Checked;
            this.decibelDisplayer_mic.Working = this.skinCheckBox_mic.Checked;
        }

        private void skinCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.decibelDisplayer_speaker.Visible = this.skinCheckBox_speaker.Checked;
            this.decibelDisplayer_speaker.Working = this.skinCheckBox_speaker.Checked;
            this.multimediaManager.Mute = !this.skinCheckBox_speaker.Checked;    
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.InviteFriendClick != null)
            {
                this.InviteFriendClick();
            }
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            //foreach (VideoPanel panel in this.flowLayoutPanel1.Controls)
            //{
            //    panel.Width = this.flowLayoutPanel1.Width - 2;
            //}
        }

        private void skinCheckBox_camera_CheckedChanged(object sender, EventArgs e)
        {
            this.multimediaManager.OutputVideo = this.skinCheckBox_camera.Checked;
        }

        private void skinToolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }        
    }
}
