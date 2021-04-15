using System.Threading.Tasks;

namespace Routeorama.Data
{
    public interface IFetchData
    {
        Task<string> FetchLabelData();
    }
}