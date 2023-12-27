using SonicFlow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicFlow.Controller
{
    public class MusicController
    {
        private readonly MusicDbContext dbContext;

        public MusicController()
        {
            try
            {
                dbContext = new MusicDbContext();
                dbContext.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating the database: {ex.Message}");
            }
        }

        public List<MusicTrack> GetMusicTracks()
        {
            return dbContext.MusicTracks.ToList();
        }

        public void AddMusicTrack(MusicTrack track)
        {
            dbContext.MusicTracks.Add(track);
            dbContext.SaveChanges();
        }

        public void UpdateMusicTrack(MusicTrack track)
        {
            dbContext.MusicTracks.Update(track);
            dbContext.SaveChanges();
        }

        public void DeleteMusicTrack(int id)
        {
            var track = dbContext.MusicTracks.Find(id);
            if (track != null)
            {
                dbContext.MusicTracks.Remove(track);
                dbContext.SaveChanges();
            }
        }
    }



}
