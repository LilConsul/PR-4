using System;
using System.Windows.Forms;

namespace PR_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
            var wr = new ShowArray();
            var arr = new int[] {1, 2, -3, -4, 3, 4, -5, -6 };
            var array = new MyArray(arr);
            
            Console.WriteLine(wr.WriteArray(array));
            Console.WriteLine("\n");
            Console.WriteLine(wr.WriteArray(array.Calculate()));
        }
    }
}