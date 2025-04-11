using SampleMvcApp.Core;

namespace SampleMvcApp.Infrastructure
{
    public class EmployeeRepository : IGetDataRepository
    {
        public string GetNameById(int id)
        {
            string name;
            if (id == 1)
            {
                name = "Rookies";
            }
            else if (id == 2)
            {
                name = "Nashers";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}
