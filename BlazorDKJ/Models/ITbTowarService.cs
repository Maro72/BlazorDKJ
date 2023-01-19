namespace BlazorDKJ.Models
{
    interface ITbTowarService
    {
        IEnumerable<Tbtowar> GetTbtowar();
        void InsertTowar(Tbtowar tbtowar);
        void UpdateTowar(long id, Tbtowar tbtowar);
        Tbtowar SingleTowar(long id);
        void DeleteTowar(int id);




    }
}
