namespace ImeiValidator.BusinessLayer
{
    public interface IImeiProvider
    {
        string GetImeiStatus(string imei);
    }
}