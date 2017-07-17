namespace SYW.GB
{
    public class RequestSyntaxCreator
    {
        public string Call = "https://platform.shopyourway.com/products/search";

        public string Auth =
            "&token=0_18401_253402300799_1_c78a591a5ecaf201c77c315dae461f0647bbbe90bc5f999d782de90e6b5bdb6f&hash=b8b5adaf022fcbc2f70476b3d0181bd2a12b859d440cc40aa9638aa2513eaebe";

        /// <summary>
        /// Takes a string and creates a call's syntax around it
        /// </summary>
        /// <param name="query">a string - what you'd type to the search box</param>
        /// <returns>uri ready to be invoked (string)</returns>
        public string BuildUriFromQuery(string query)
        {
            return (Call + "?q=" + query + "&limit=20" + Auth);
        }

    }
}