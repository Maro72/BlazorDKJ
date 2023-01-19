namespace BlazorDKJ.Models
{
     interface ITbJm
    {
        IEnumerable<Tbjm> GetTbjm();
        void InsertJm(Tbjm tbjm);
        void UpdateJm(long id, Tbjm tbjm);
        Tbjm SingleJm(long id);
        void DeleteJm(int id);


    }
}
