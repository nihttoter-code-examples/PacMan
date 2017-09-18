using System;

namespace PuckMan {
    class FileReader {
        private readonly string _filePath;
        private int[,] _map;

        public FileReader(string filePath) {
            _filePath = filePath;
        }

        public int[,] ReadFile() {
            string[] lines = System.IO.File.ReadAllLines(_filePath);
            _map = new int[13, 13];

            int i = 0;
            int j = 0;
            foreach (string line in lines) {
                foreach (var item in line) {
                    _map[j, i]= Convert.ToInt32(item.ToString());
                    j++;
                }
                j = 0;
                i++;
            }

            return _map;
        }
    }
}
