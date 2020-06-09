using Microsoft.AspNetCore.ResponseCompression;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBlog.Middleware
{
    public class CustomCompressionProvider : ICompressionProvider
    {
        public string EncodingName => "blogcustomcompression";
        public bool SupportsFlush => true;

        public Stream CreateStream(Stream outputStream)
        {
            return outputStream;
        }
    }
}
