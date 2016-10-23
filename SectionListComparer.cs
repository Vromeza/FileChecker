using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileChecker {
    class SectionListComparer : IEqualityComparer<Dictionary<string, List<string>>> {

        public bool Equals(Dictionary<string, List<string>> dictionaryA, Dictionary<string, List<string>> dictionaryB) {
            return true;
        }

        public int GetHashCode(Dictionary<string, List<string>> obj) {
            return 1;
        }
    }
}
