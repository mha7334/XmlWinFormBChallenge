namespace WebOrderLib
{
    public interface IProcessingService<T>
    {
        T Process(string file);
    }
}