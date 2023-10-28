using System;
using System.Collections.Generic;

namespace PR_4 {
    public class MyArray {
        private int length = 0;
        public int[] Arr;

        public int Length {
            get => length;
            set => length = value;
        }

        public MyArray(int n) {
            if (n <= 0)
                throw new Exception("Масив не може бути менше 0");
            Arr = new int[n];
        }
        public MyArray(int[] arr) {
            this.Arr = arr ?? throw new Exception("Невірний масив!");
            length = arr.Length;
        }

        private (int, int) FindIndex() {
            var found = false;
            var neg = -1;
            var pos = -1;
            for (var i = 0; i < Arr.Length; i++) {
                if (Arr[i] < 0 && !found) {
                    found = true;
                    neg = i;
                }
                if (neg != -1 && Arr[i] >= 0) {
                    pos = i;
                    break;
                }
            }
            return (neg, pos);
        }

        public int[] Calculate() {
            Array.Resize(ref Arr, length);
            var ans = new List<int>();
            (var neg, var pos) = FindIndex();
            if (neg == -1)
                return Arr;
            if (pos > Arr.Length)
                return new int[]{};
            
            for (var i = 0; i < Arr.Length; i++) {
                if (i == neg)
                    i = pos;
                ans.Add(Arr[i]);
            }
            return ans.ToArray();
        }
    }
}