using BlazorDKJ.Data;

namespace BlazorDKJ.Models
{
    public class TbJmService : ITbJm
    {
        public mczeContext _context;
        public TbJmService(mczeContext context)
        {
            _context = context;
        }
        public void DeleteJm(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tbjm> GetTbjm()
        {
            try
            {
                return _context.Tbjm.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertJm(Tbjm tbjm)
        {
            throw new NotImplementedException();
        }

        public Tbjm SingleJm(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateJm(long id, Tbjm tbjm)
        {
            throw new NotImplementedException();
        }
    }
}
