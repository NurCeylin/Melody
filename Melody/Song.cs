using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    internal class Song
    {
        public int idSong { get; set; }
        public string SongName { get; set; }
        public Album idAlbum { get; set; }
    }
}
