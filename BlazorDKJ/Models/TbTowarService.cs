using BlazorDKJ.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorDKJ.Models
{
    public class TbTowarService : ITbTowarService
    {
        public mczeContext _context;
        public TbTowarService(mczeContext context)
        {
            _context = context;
        }

        public void DeleteTowar(int id)
        {
            try
            {
                Tbtowar ord = _context.Tbtowar.Find(id);
                _context.Tbtowar.Remove(ord);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Tbtowar> GetTbtowar()
        {
            try
            {
                return _context.Tbtowar.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertTowar(Tbtowar tbtowar)
        {
            try
            {
                _context.Tbtowar.Add(tbtowar);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Tbtowar SingleTowar(long id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTowar(long id, Tbtowar towar)
        {
            try
            {
                var local = _context.Set<Tbtowar>().Local.FirstOrDefault(entry => entry.Idtowar.Equals(towar.Idtowar));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(towar).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
