using System.Collections.Generic;

namespace BruteForceDictionary
{
    /// <summary>
    /// A collection of word lists as provided by YAWL.
    /// </summary>
    /// <see cref="https://github.com/elasticdog/yawl"/>
    public static partial class WordLists {
        /// <summary>
        /// All twentyseven letter words in the YAWL collection.
        /// </summary>
        public static IEnumerable<string> TwentySevenLetterWords = new string[] { "electroencephalographically", "ethylenediaminetetraacetate" };
    }
}