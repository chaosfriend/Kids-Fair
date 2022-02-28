using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class Album
    {
        //Album name, artist, name and number of tracks
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Starting the Album Program!"); //Greetings text
            Console.WriteLine(); //blankline

            ReadAndSaveAlbumData();
            DisplayAlbumInfo();
        }
        public void ReadAndSaveAlbumData()
        {
            //Read a line of text
            Console.Write("What's the name of your favourite music album?");
            albumName = Console.ReadLine();

            //Read a lne about artist
            Console.Write("What is the name of the Artist or band for " + albumName);
            artistName = Console.ReadLine();

            //Read a line of text
            Console.Write("How many tracks does " + albumName + " have?");
            string tracks = Console.ReadLine();
            //convert string to number
            numOfTracks = int.Parse(tracks);
        }
            public void DisplayAlbumInfo()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Album Name: "+ albumName);//diaplay album name
            Console.WriteLine("Artist/Band: "+artistName); //display artist name
            Console.WriteLine("Number of tracks: " + numOfTracks); //number of tracks
            Console.WriteLine("Enjoy listening!"); //kind regards
        }               
    }
}
