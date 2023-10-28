using System;
using System.Windows.Forms;

namespace PR_4 {
    public partial class Form1 : Form {
        private string inFile = "inFile.txt";
        private string outFile = "outFile.txt";
        
        private ReadFile reader = new ReadFile();
        private WriteFile writer = new WriteFile();
        private ShowArray shower = new ShowArray();
        public Form1() {
            InitializeComponent();

            var arr = new MyArray(9);
            reader.Read(inFile, arr);
            in_label.Text = shower.WriteArray(arr);
        }

        private void button1_Click(object sender, EventArgs e) {
            var arr = new MyArray(9);
            reader.Read(inFile, arr);
            var calculated = new MyArray(arr.Calculate());
            
            writer.Write(outFile, calculated);
            out_label.Text = shower.WriteArray(calculated);
        }
    }
}