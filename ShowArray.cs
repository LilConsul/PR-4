using System.Linq;

namespace PR_4 {
    public class ShowArray {
        public string WriteArray(MyArray arr) {
            return arr == null ? "" : string.Join(", ", arr.Arr);
        }
        
        public string WriteArray(int[] arr) {
            return arr == null ? "" : string.Join(", ", arr);
        }
    }
}