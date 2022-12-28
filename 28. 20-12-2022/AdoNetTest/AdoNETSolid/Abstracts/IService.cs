namespace AdoNETSolid.Abstracts
{
    public interface IService<T>
    {
        void Create(T model);
        void Delete(int id);
        List<T> GetAll();
    }
}
