using Booking.Classes;
using Booking.UserForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
using ZXing;

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
            DisplayBarcodeInBox(ticket.ticketNumber);
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
                logo_pictureBox.Image = System.Drawing.Image.FromFile(logoMap[ticket.shippingLine.ToString()]);
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
            ticket_panel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, ticket_panel.Width, ticket_panel.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        public Bitmap GenerateBarcode(string data)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128, 
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 50, 
                    Width = 259, 
                    Margin = 10  
                }
            };

            return barcodeWriter.Write(data); 
        }
        public void DisplayBarcodeInBox(string data)
        {
            Bitmap barcodeBitmap = GenerateBarcode(data); 
            barcode_box.Image = barcodeBitmap;            
        }
        public void ConvertBitmapToPDF(Bitmap bitmap, string pdfFilePath)
        {
            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs); 
                document.Open(); 

                
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Png);
                pdfImage.ScaleToFit(PageSize.A4.Width - 50, PageSize.A4.Height - 50); 
                document.Add(pdfImage); 
                document.Close(); 
            }
        }
        private void email_btn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(ticket_panel.Width, ticket_panel.Height);
            ticket_panel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, ticket_panel.Width, ticket_panel.Height));
            string tempPdfFilePath = Path.Combine(Path.GetTempPath(), "ticket.pdf");
            ConvertBitmapToPDF(bitmap, tempPdfFilePath);
            ApplicationSystemEmail sendTicket = new ApplicationSystemEmail();
            sendTicket.sendEmailWithAttachment(email, tempPdfFilePath);

            
            MessageBox.Show("Itinerary receipt has been sent!");

            
            UserHome parentForm = this.ParentForm as UserHome;
            if (parentForm != null)
            {
                bookingControl bc = new bookingControl(currentUser);
                parentForm.DashboardPanel.Controls.Clear();
                parentForm.DashboardPanel.Controls.Add(bc);
            }
        }
    }
}
