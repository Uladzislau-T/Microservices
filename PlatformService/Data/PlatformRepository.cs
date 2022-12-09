using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepository : IPlatformRepository
    {
        public AppDbContext _context { get; set; }

        public PlatformRepository(AppDbContext context) 
        {
            _context= context;
        }
        public void CreatPlatform(Platform platform)
        {
            if (platform == null)
                throw new ArgumentNullException();

            _context.Platform.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platform.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platform.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
