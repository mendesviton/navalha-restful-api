using data.model;

namespace data.repository
{
    public interface IRepository<T> where T : BaseModel
    {
        string Create(T model);
        string Update(T model);

        string Delete(int id);

        List<T> GetAll();

        T GetById(int id);
    }
}
