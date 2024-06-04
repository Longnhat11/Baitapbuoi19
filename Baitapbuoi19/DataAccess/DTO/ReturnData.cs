using Baitapbuoi19.Models;

namespace Baitapbuoi19.DataAccess.DTO
{
    public class ReturnData
    {
        public int ReturnCode { get; set; }
        public string ReturnMsg { get; set; }
    }
    public class ReturnDataReturnStudent:ReturnData 
    {
        public Students ReturnStudent { get; set; }
    }
}
