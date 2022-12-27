using Facade.SomeVideoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class VideoConverter
    {
        internal VideoFile Convert(string fileName, string format)
        {
            var file = new VideoFile(fileName);
            var codecFactory = new CodecFactory();
            string codec = codecFactory.Extract(file);
            BaseCompressionCodec destinationCodec;
            if (codec == "mp4")
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }
            var bitrateReader = new BitrateReader();
            string buffer = bitrateReader.Read(fileName, codec);
            string result = bitrateReader.Convert(buffer, destinationCodec);
            var audioMixer = new AudioMixer();
            result = audioMixer.Fix(result);
            return file;
        }
    }
}
