using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================
            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var soleartist = from match in Artists
                where match.Hometown == "Mount Vernon"
                orderby match.ArtistName descending
                select new { match.ArtistName, match.Age };
                Console.WriteLine("The artist from Mount Vernon is:");
                    foreach (object artist in soleartist)
                    {
                        Console.WriteLine(artist);
                    }
            //Who is the youngest artist in our collection of artists?
            var youngestartist = from match in Artists
                orderby match.ArtistName descending
                select new { match.ArtistName};
                Console.WriteLine("The artists from Atlanta are:");
                    foreach (object artist in youngestartist)
                    {
                        Console.WriteLine(artist);
                    }
            //Display all artists with 'William' somewhere in their real name
            var william = from match in Artists
                where match.RealName.Contains("William")
                orderby match.ArtistName descending
                select new { match.ArtistName, match.RealName };
                Console.WriteLine("The artists with a real name William are:");
                foreach (object artist in william)
                    {
                        Console.WriteLine(artist);
                    }
            //Display all groups with names less than 8 characters in length
            var grouplessthan = from match in Groups
                where match.GroupName.Length < 8
                orderby match.GroupName descending
                select new { match.GroupName, match.Id };
                Console.WriteLine("Groups with names less than 8 characters:");
                foreach (object artist in grouplessthan)
                    {
                        Console.WriteLine(artist);
                    }
            //Display the 3 oldest artist from Atlanta
            var oldest = from match in Artists
                where match.Hometown == "Atlanta"
                orderby match.Age descending
                select new { match.ArtistName , match.Age};
                oldest = oldest.Take(3);
                Console.WriteLine("The oldest artists from Atlanta:");
                foreach (object artist in oldest)
                    {
                        Console.WriteLine(artist);
                    }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            var groupnotny = from g in Groups
                join a in Artists on g.Id equals a.GroupId
                // group a.GroupId
                where a.Hometown != "New York"
                orderby g.GroupName descending
                select new { g.GroupName, g.Id };
                groupnotny = groupnotny.Distinct();
                Console.WriteLine("The groups not from NYC are:");
                foreach (object group in groupnotny)
                    {
                        Console.WriteLine(group);
                    }
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            var wtc = from a in Artists
                join g in Groups on a.GroupId equals g.Id 
                where g.GroupName != "Wu-Tang Clan"
                orderby a.ArtistName descending
                select new { a.ArtistName };
                Console.WriteLine("The artists from Wu-Tang Clan are:");
                foreach (object artist in wtc)
                    {
                        Console.WriteLine(artist);
                    }
        }
    }
}
