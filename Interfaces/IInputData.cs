using EncStego.Classes;

namespace EncStego.Interfaces
{
    public interface IInputData
    {
        DataInfo GetDataInfo(string input);

        string GetData(DataInfo input, string part);
    }
}