using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class CD
    {
        private TimeSpan total, temp;
        public string Title { get; set; }
        public string Artist { get; set; }
        private List<Song> songs;
        public List<Song> SongList
        {
            get { return songs; }
        }

        public CD()
        {
            songs = new List<Song>();
        }

        private string CountLength()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                temp = TimeSpan.ParseExact(songs.ElementAt(i).Length, "m\\:ss", null); ;
                total = total + temp;
            }
            return total.ToString();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void AlbumInfoConsole()
        {
            Console.WriteLine("CD data:");
            Console.WriteLine("- Artist: " + Artist);
            Console.WriteLine("- Title: " + Title);
            Console.WriteLine("- Length: " + CountLength());
            Console.WriteLine("- Songs:");
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine("  - " + songs.ElementAt(i).ToString());
            }
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Length { get; set; }

        public Song()
        {

        }

        public override string ToString()
        {
            return Title + ", " + Length;
        }
    }
}
