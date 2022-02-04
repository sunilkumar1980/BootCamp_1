namespace BC.Api.RepositoryContracts
{
    public interface IRepository<T> where T:class
    {
        T GetById(int id);
        List<T> GetAll();
        int AddRecord(T record);
        int UpdateRecord(T record);
        int DeleteRecord(int id);   

    }
}
