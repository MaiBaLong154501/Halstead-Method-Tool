using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halstead.GUI
{
    public partial class frm_Main : Form
    {
        private string[] fe = { "*.cs", "*.java", "*.c", "*.cpp", "*.js" };
        private String[] files;
        private Dictionary<string, int> listOperator;
        private Dictionary<string, int> listOperand;
        private source.HalsteadMethod halstead;

        public frm_Main()
        {
            this.listOperator = new Dictionary<string, int>();
            this.listOperand = new Dictionary<string, int>();
            halstead = new source.HalsteadMethod(listOperator, listOperand);
            files = null;
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowerDialog = new FolderBrowserDialog();
            folderBrowerDialog.Description = "Custom Description";

            if (folderBrowerDialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_Path.Text = folderBrowerDialog.SelectedPath;
            }
            String folder = this.txt_Path.Text;
            try
            {
                List<string> list = new List<string>();
                foreach (string s in fe)
                {
                    string[] f = Directory.GetFiles(folder, s, SearchOption.AllDirectories);
                    foreach (string s1 in f)
                        list.Add(s1);
                }
                this.files = list.ToArray();
                
            }
            catch (Exception err)
            {
                Debug.Print(err.ToString());
            }
            this.Analyse();
        }

        private void Analyse()
        {
            this.listOperator = new Dictionary<string, int>();
            this.listOperand = new Dictionary<string, int>();
            try
            {
                if (files != null)
                {
                    foreach (String f in files)
                    {
                        try
                        {
                                source.Counting calc = new source.Counting(f, listOperator, listOperand);

                                this.listOperator = calc.listOperator;
                                this.listOperand = calc.listOperand;

                                halstead = new source.HalsteadMethod(this.listOperator, this.listOperand);

                                txt_Files.AppendText(f + Environment.NewLine);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Lỗi. Làm phiền bạn thử lại sau!!!");
                        }
                    }
                    ViewResult();
                    ViewOperand();
                    ViewOperator();
                }
            }
            catch (Exception err)
            {
                Debug.Print(err.ToString());
            }
        }

        private void ViewResult()
        {
            String results = "";
            results += "+ Number of distinct operators in the program(μ1): " + halstead.NumberOfOperators;
            results += "\r\n+ Number of distinct operands in the program(μ2): " + halstead.NumberOfOperands;
            results += "\r\n+ Total number of occurrences of operators in the program(N1): " + halstead.TotalOperators;
            results += "\r\n+ Total number of occurrences of operands in the program(N2): " + halstead.TotalOperands;
            results += "\r\n+ Program vocabulary(μ): " + halstead.ProgramVocaburary();
            results += "\r\n+ Program length(N): " + halstead.ProgramLength();
            results += "\r\n+ Program volume(V): " + halstead.ProgramVolume().ToString("0.#####");
            results += "\r\n+ Program difficulty(D): " + halstead.ProgramDifficulty().ToString("0.#####");
            results += "\r\n+ Program level(L): " + halstead.ProgramLevel().ToString("0.#####");
            results += "\r\n+ Program estimate length: " + halstead.ProgramEstimatedLength().ToString("0.#####");
            results += "\r\n+ Effort: " + halstead.CalculateEffort().ToString("0.#####");
            results += "\r\n+ Time: " + halstead.CalculateTime().ToString("0.#####");
            results += "\r\n+ Remaining Bugs: " + halstead.CalculateRemainingBugs().ToString("0.#####");

            this.txt_Result.Text = results;
        }

        private void ViewOperator()
        {
            dtg_Operator.DataSource = (from d in listOperator orderby d.Value select new { d.Key, d.Value }).ToList();
            this.dtg_Operator.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Operator.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            this.dtg_Operator.BorderStyle = BorderStyle.None;
            this.dtg_Operator.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dtg_Operator.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Operator.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dtg_Operator.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dtg_Operator.BackgroundColor = Color.White;
            this.dtg_Operator.EnableHeadersVisualStyles = false;
            this.dtg_Operator.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dtg_Operator.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            this.dtg_Operator.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dtg_Operator.AllowUserToAddRows = false;
        }

        private void ViewOperand()
        {
            dtg_Operand.DataSource = (from d in listOperand orderby d.Value select new { d.Key, d.Value }).ToList();
            this.dtg_Operand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Operand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            this.dtg_Operand.BorderStyle = BorderStyle.None;
            this.dtg_Operand.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dtg_Operand.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Operand.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dtg_Operand.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dtg_Operand.BackgroundColor = Color.White;
            this.dtg_Operand.EnableHeadersVisualStyles = false;
            this.dtg_Operand.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dtg_Operand.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            this.dtg_Operand.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dtg_Operand.AllowUserToAddRows = false;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.listOperator = new Dictionary<string, int>();
            this.listOperand = new Dictionary<string, int>();
            halstead = new source.HalsteadMethod(listOperator, listOperand);
            files = null;
            txt_Files.Text = "";
            txt_Path.Text = "";
            txt_Result.Text = "";
            this.dtg_Operand.DataSource = null;
            this.dtg_Operand.Rows.Clear();

            this.dtg_Operator.DataSource = null;
            this.dtg_Operator.Rows.Clear();

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        Chunk chunk = new Chunk("Count Operand", FontFactory.GetFont("dax-black"));
                        chunk.SetUnderline(0.5f, -1.5f);
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        doc.Add(new Paragraph("Operator"));
                        doc.Add(new Paragraph(" "));
                        // Export to PDF in Windows Forms DataGrid Operator
                        PdfPTable pdfTable = new PdfPTable(dtg_Operator.ColumnCount);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 70;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        //Adding Header row
                        foreach (DataGridViewColumn column in dtg_Operator.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            pdfTable.AddCell(cell);
                        }
                        //Adding DataRow
                        foreach (DataGridViewRow row in dtg_Operator.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value == null)
                                {

                                }
                                else
                                {
                                    pdfTable.AddCell(cell.Value.ToString());

                                }
                            }
                        }
                        doc.Add(pdfTable);

                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph("Operand"));
                        doc.Add(new Paragraph(" "));
                        // Export to PDF in Windows Forms DataGrid Operand  
                        PdfPTable pdf_Operand = new PdfPTable(dtg_Operand.ColumnCount);
                        pdf_Operand.DefaultCell.Padding = 3;
                        pdf_Operand.WidthPercentage = 70;
                        pdf_Operand.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdf_Operand.DefaultCell.BorderWidth = 1;
                        //Adding Header row
                        foreach (DataGridViewColumn column in dtg_Operand.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            pdf_Operand.AddCell(cell);
                        }
                        //Adding DataRow
                        foreach (DataGridViewRow row in dtg_Operand.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value == null)
                                {

                                }
                                else
                                {
                                    pdf_Operand.AddCell(cell.Value.ToString());

                                }
                            }
                        }
                        doc.Add(pdf_Operand);

                        //doc.Add(new iTextSharp.text.Paragraph(txt_Files.Text));
                        doc.Add(new Paragraph("Calculate"));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new iTextSharp.text.Paragraph(txt_Result.Text));
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
