using Booking.Classes;
using Booking.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.usercontrol
{
    public partial class ticketDetail : UserControl
    {
        private Ticket ticket;
        private string email;
        private Dictionary<string, string> logoMap;
        private User currentUser;
        public ticketDetail(Ticket ticketdetail , string passenger_email ,User user)
        {
            InitializeComponent();
            InitializeLogoMap();
            ticket = ticketdetail;
            email = passenger_email;
            currentUser = user;
            viewTicketDisplay();
          //  print_btn.Click += print_btn_Click;
           // email_btn.Click += email_btn_Click;
        }
        private void viewTicketDisplay()
        {
            bookDate_lbl.Text = ticket.bookingDate.ToString();
            ticketNum_lbl.Text = ticket.ticketNumber.ToString();
            accom_lbl.Text = ticket.accomodationName.ToString();
            discountT_lbl.Text = ticket.discountType.ToString();
            passName_lbl.Text = ticket.passName.ToString();
            age_lbl.Text = ticket.passAge.ToString();
            sex_lbl.Text = ticket.passSex.ToString();
            fare_lbl.Text = ticket.fare.ToString();
            origin_lbl.Text = ticket.originName.ToString();
            destination_lbl.Text = ticket.destinationName.ToString();
            schedule_lbl.Text = ticket.tripSched.ToString();
            vessel_lbl.Text = ticket.vesselName.ToString();
            bfare_lbl.Text = ticket.basefare.ToString();
            discount_lbl.Text = ticket.discount.ToString();
            if (logoMap.ContainsKey(ticket.shippingLine.ToString()))
            {
                logo_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                logo_pictureBox.Image = Image.FromFile(logoMap[ticket.shippingLine.ToString()]);
            }
        }
        private void InitializeLogoMap()
        {
            logoMap = new Dictionary<string, string>();
            logoMap.Add("Oceanjet", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\oceanjet.png");
            logoMap.Add("Seacat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\seacat.png");
            logoMap.Add("Supercat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\supercat.png");
            logoMap.Add("Roble", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\rsi-logo-short.png");
            logoMap.Add("Lite Shipping", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\lite1.png");
            logoMap.Add("Lapu-Lapu", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\list_lapulapu.png");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            var printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            var printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); 
            }
            UserHome parentForm = this.ParentForm as UserHome;
            if (parentForm != null)
            {
                bookingControl bc = new bookingControl(currentUser);
                parentForm.DashboardPanel.Controls.Clear();
                parentForm.DashboardPanel.Controls.Add(bc);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(ticket_panel.Width, ticket_panel.Height);
            ticket_panel.DrawToBitmap(bitmap, new Rectangle(0, 0, ticket_panel.Width, ticket_panel.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void email_btn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(ticket_panel.Width, ticket_panel.Height);
            ticket_panel.DrawToBitmap(bitmap, new Rectangle(0, 0, ticket_panel.Width, ticket_panel.Height));

            string tempFilePath = Path.Combine(Path.GetTempPath(), "ticket.png");
            bitmap.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Png);

            ApplicationSystemEmail sendTicket = new ApplicationSystemEmail();
            MessageBox.Show("Iterinary Receipt has been sent!");
            UserHome parentForm = this.ParentForm as UserHome;
            if (parentForm != null)
            {
                bookingControl bc = new bookingControl(currentUser);
                parentForm.DashboardPanel.Controls.Clear();
                parentForm.DashboardPanel.Controls.Add(bc);
                sendTicket.sendEmailWithAttachment(email, tempFilePath);
            }
        }
    }
}
