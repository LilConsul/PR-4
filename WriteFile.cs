using System.IO;

namespace PR_4 {
    public class WriteFile : IWrite{
        public void Write(string path, MyArray arr) {
            using (var sw = new StreamWriter(path, false, System.Text.Encoding.Default)) {
                foreach (var num in arr.Arr) {
                    sw.WriteLine(num.ToString());
                }
                sw.Close();
            }
        }
    }
}