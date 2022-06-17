namespace DataAccessLayer
{
    public class FileService : IDataService 
    {
        // ReadFile

        // UpdateFile
        public IEnumerable<T> GetData<T>()
        {

            // access file system, read some information, deserialise it and convert it to the generic data type passed in
            return new List<T>();
        }
    }
}