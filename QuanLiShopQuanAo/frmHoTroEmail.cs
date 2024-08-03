using System.Net.Mail;

namespace QuanLiShopQuanAo.Resources
{
    public partial class frmHoTroEmail : Form
    {
        public frmHoTroEmail()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            //string recipientEmail = txtEmail.Text;
            //string emailBody = txtNoiDung.Text;

            //if (string.IsNullOrEmpty(recipientEmail) || string.IsNullOrEmpty(emailBody))
            //{
            //    MessageBox.Show("Please enter both email and body content.");
            //    return;
            //}

            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //    mail.From = new MailAddress("hoccongviectruong@gmail.com");
            //    mail.To.Add(recipientEmail);
            //    mail.Subject = "Subject";
            //    mail.Body = emailBody;

            //    if (!string.IsNullOrEmpty(attachmentPath))
            //    {
            //        Attachment attachment = new Attachment(attachmentPath);
            //        mail.Attachments.Add(attachment);
            //    }

            //    smtpClient.Port = 587;
            //    smtpClient.Credentials = new System.Net.NetworkCredential("hoccongviectruong@gmail.com", "your-app-password");
            //    smtpClient.EnableSsl = true;

            //    smtpClient.Send(mail);
            //    MessageBox.Show("Email sent successfully!");

            //    txtEmail.Clear();
            //    txtNoiDung.Clear();
            //    lblChonFile.Text = "No file selected";
            //    attachmentPath = "";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Failed to send email: " + ex.Message);
            //}
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = choofdlog.FileName;
            }
        }

        private void tsmiReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
