using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace frama.election.core
{
    public sealed class CsvResultReader : IEnumerable<string>
    {
        private string _filePath;

        public CsvResultReader(string path)
        {
            _filePath = path;
        }

        public IEnumerator<string> GetEnumerator()
        {
            var allLines = File.ReadLines(_filePath);

            IList<string> toBeProcessed = new List<string>(allLines);

            toBeProcessed.Remove(allLines.First());

            return toBeProcessed.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
