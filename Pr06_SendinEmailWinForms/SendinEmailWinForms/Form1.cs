using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SendinEmailWinForms
{
    //before starting the program, follow the link https://myaccount.google.com/lesssecureapps and enable unsafe applications

    public partial class Form1 : Form
    {
        private OpenFileDialog dlg = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!!!");
            
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            

            dlg.Title = "Open Image";
            dlg.Filter = "tmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(dlg.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            using (var mn = new  MailMessage("XXX","XXX"))//enter your email instead of XXX
            {
                mn.Subject = textBoxSubject.Text;
                if(mn.Subject=="")
                    mn.Subject = "Mail Subject";

                mn.Body = textBoxText.Text;
                if(mn.Body=="")
                    mn.Body = "Mail Body";

                mn.Attachments.Add(new Attachment(dlg.FileName));
                if(dlg.FileName=="")
                    mn.Attachments.Add(new Attachment("img.jpg"));

                using (var sc = new SmtpClient("smtp.gmail.com", 587))
                {
                    sc.EnableSsl = true;
                    sc.Timeout = 10000;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.UseDefaultCredentials = false;
                    sc.Credentials = new System.Net.NetworkCredential("XXX", "XXX");//enter your email and password instead of XXX
                    sc.Send(mn);
                }
            }
        }
    }
}
