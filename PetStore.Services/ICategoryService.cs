namespace PetStore.Services
{
    public interface ICategoryService 
    {
        //void Add(string name);

        bool Exists(int categoryId);
    }
}
