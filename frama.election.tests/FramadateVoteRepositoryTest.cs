using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Shouldly;
using frama.election.core;

namespace frama.election.tests
{
    public class FramadateVoteRepositoryTest
    {
        [Fact]
        public async void GetEnmerator_When_Invoked_Then_ReturnCollectionOfString()
        {
            string fileName = "SampleCode-01.csv";

            IEnumerable<string> output = new CsvResultReader(fileName);

            output.First().ShouldBe("\"macreiben@gmail.com\",\"Oui\",\"Non\",");
        }
    }
}
