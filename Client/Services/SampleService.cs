namespace FormsServices.Client.Services
{
    /// <summary>
    /// Example service
    /// </summary>
    public interface ISampleService
    {
        /// <summary>
        /// Get enumerable of random numbers
        /// </summary>
        /// <returns>enumerable int</returns>
        Task<IEnumerable<int>> GetRandomNumbers();
    }

    internal class SampleService : ISampleService
    {
        public async Task<IEnumerable<int>> GetRandomNumbers()
        {
            var list = new int[10];

            for (var i = 0; i < list.Length; i++)
            {
                await Task.Delay(100);
                list[i] = new Random().Next();
            }

            return list;
        }
    }
}
