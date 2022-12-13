using Data.Context;

namespace LMS_Api.Controllers
{
    public class ControllerBase
    {
        public ControllerBase()
        {
            using (Context x = new Context())
            {
                x.Database.EnsureCreated();
            }
        }

    }
}
