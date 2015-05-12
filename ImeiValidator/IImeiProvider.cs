using System.Threading.Tasks;

namespace ImeiValidator
{
    public interface IImeiProvider
    {
        bool IsImeiValid(string imei);

        Task<bool> IsImeiValidAsync(string imei);

        string GetImeiStatus(string imei);
    }
}