using System;
using System.IO;

namespace PR_4 {
    public class ReadFile : IRead {
        public void Read(string path, MyArray arr) {
            using (var sr = new StreamReader(path,
                       System.Text.Encoding.Default)) {
                try {
                    var i = 0;
                    var line = "";
                    while ((line = sr.ReadLine()) != null) {
                        arr.Arr[i] = Convert.ToInt32(line);
                        i++;
                    }
                    arr.Length = i;
                    sr.Close();
                }
                catch (Exception e) {
                    throw new AccessViolationException("Помилка читання файлу!");
                }
            }
        }
    }
}