using System.Collections.Generic;

namespace Assessment
{
    public class StringProvider : IElementsProvider<string>
    {
        public IEnumerable<string> ProcessData(string source)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> ProcessDataComa(string source)
        {
    
            return source.Split(SeparatorChars.Comma);
        }

        public IEnumerable<string> ProcessDataPipe(string source)
        {
            return source.Split(SeparatorChars.Pipe);
        }

        public IEnumerable<string> ProcessDataSpace(string source)
        {
            return source.Split(SeparatorChars.Space);
        }
    }
}