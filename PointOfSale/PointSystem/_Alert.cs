using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSystem
{
   public  class _Alert
    {

        //===========================================================
        //  { Abu Ehab _  May 2014 }   
        // ^^^ مخــــــطط في المستقبل أضــــافة صـوت لكل رساله
        //===========================================================


        #region " Controls "

        static Form Frm = new Form();
        static Timer timer1 = new Timer();
        static Label ImageLab = new Label();
        static Label MsgHolderLab = new Label();
        Panel BackPanel = new Panel();
        #endregion

        #region " Create Controls "
        static void CreateMsgFrm()
        {
            // Form
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.BackgroundImageLayout = ImageLayout.Stretch;
            Frm.Size = new Size(338, 60);
            Frm.TopMost = true;
            //=======================================

            // ImageLab
            ImageLab.AutoSize = false;
            ImageLab.Dock = DockStyle.Right;
            ImageLab.BackColor = Color.Transparent;
            ImageLab.ImageAlign = ContentAlignment.MiddleCenter;
            ImageLab.Size = new Size(59, 60);
            ImageLab.BorderStyle = BorderStyle.None;
            Frm.Controls.Add(ImageLab);
            //============================
            // MsgHolderLab
            MsgHolderLab.Size = new Size(280, 60);
            MsgHolderLab.BackColor = Color.Transparent;
            MsgHolderLab.Anchor = AnchorStyles.Right;
            MsgHolderLab.TextAlign = ContentAlignment.MiddleRight;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            Frm.Controls.Add(MsgHolderLab);

        }
        #endregion

        #region "   Timer      "
        static void ActivateTimer()
        {
            timer1.Interval = 3000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

        }
        static void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Frm.Cursor = Cursors.Default;
            Frm.Hide();
        }
        #endregion

        #region "  ^^^ Messages ^^^     "


        #region "  Info      "
        public static void Information(string Msg)
        {

            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info;

            Frm.BackgroundImage = Properties.Resources.BOkey;
            MsgHolderLab.Text = Msg;
            Frm.Show();

        }

        public static void Information(string Title, string Msg)
        {

            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info;

            Frm.BackgroundImage = Properties.Resources.BOkey;
            MsgHolderLab.Text = Title + System.Environment.NewLine + Msg;
            Frm.Show();

        }



        #endregion


        #region "  Error  "
        public static void Error(string Title, string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.error5;

            Frm.BackgroundImage = Properties.Resources.BError;

            MsgHolderLab.Text = Title + System.Environment.NewLine + Msg;
            Frm.Show();
        }


        public static void Error(string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.error5;

            Frm.BackgroundImage = Properties.Resources.BError;

            MsgHolderLab.Text = Msg;
            Frm.Show();
        }



        #endregion


        #region "  Warning  "
        public static void Warning(string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Warning;
            Frm.BackgroundImage = Properties.Resources.BWarnnig;
            MsgHolderLab.ForeColor = Color.Blue;
            MsgHolderLab.Text = Msg;
            Frm.Show();

        }
        // Title +  System.Environment.NewLine + Msg;

        public static void Warning(string Title, string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Warning;
            Frm.BackgroundImage = Properties.Resources.BWarnnig;
            MsgHolderLab.ForeColor = Color.Blue;
            MsgHolderLab.Text = Title + System.Environment.NewLine + Msg;
            Frm.Show();

        }

        #endregion


        #region "Attention "
        public static void Attention(string Title, string Msg)
        {
            CreateMsgFrm();


            ImageLab.TextAlign = ContentAlignment.TopCenter;
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info2;

            Frm.BackgroundImage = Properties.Resources.BAlaert;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Text = Title + System.Environment.NewLine + Msg;
            ActivateTimer();
            Frm.Show();


        }

        public static void Attention(string Msg)
        {
            CreateMsgFrm();


            ImageLab.TextAlign = ContentAlignment.TopCenter;
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info2;

            Frm.BackgroundImage = Properties.Resources.BAlaert;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Text = Msg;
            ActivateTimer();
            Frm.Show();


        }
        #endregion



        #endregion

        #region "  ^^^ About     "
        public static void About()
        {

            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Flag;
            Frm.BackgroundImage = Properties.Resources.BAlaert;
            MsgHolderLab.TextAlign = ContentAlignment.MiddleLeft;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Text = " Abu Ehab" +
                System.Environment.NewLine + " Palestinain Police Officer" +
                System.Environment.NewLine + " Xprema Systems @2014";
            Frm.Show();
        }
        #endregion


        ~_Alert() { }
        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }
    }
}
