using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
namespace LaundaryApplication
{
    public partial class LaundaryApp : Form
    {
        public LaundaryApp()
        {
            InitializeComponent();
        }

        //Find and Replace Method
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Creeate the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {

                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<orderNum>", 123456789);
                this.FindAndReplace(wordApp, "<id>", 038137162);
                this.FindAndReplace(wordApp, "<customer>", "אדהם");
                this.FindAndReplace(wordApp, "<quantity1>", 32);
                this.FindAndReplace(wordApp, "<unit1>", "כביסה");
                this.FindAndReplace(wordApp, "<costForOneUnit1>", 6);
                this.FindAndReplace(wordApp, "<totalCost1>", 512);
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void button_GetDetails_Click(object sender, EventArgs e)
        {
            Form_get_details f1 = new Form_get_details();
            f1.Show();
        }

        private void button_generateOrder(object sender, EventArgs e)
        {
            int num = 5855469;
            
            string orderName = "";
            orderName = num.ToString() + "adham" + ".doc";
            string outName = @"C:\C#\LaundaryApp\LaundaryApplication\outs\";
            outName += orderName;
            Console.WriteLine(outName);
            System.Threading.Thread.Sleep(3000);//sleep for 3 secs
            CreateWordDocument(@"C:\C#\LaundaryApp\LaundaryApplication\hazmana.docx",outName);
        }

        private void button_buildNewOrder_Click(object sender, EventArgs e)
        {
            int num = 5855469;

            string orderName = "";
            orderName = num.ToString() + "adham" + ".doc";
            string outName = @"C:\C#\LaundaryApp\outs\";
            outName += orderName;
            Console.WriteLine(outName);
            System.Threading.Thread.Sleep(3000);//sleep for 3 secs
            CreateWordDocument(@"C:\C#\LaundaryApp\LaundaryApplication\hazmana.docx", outName);
        }
    }
}
