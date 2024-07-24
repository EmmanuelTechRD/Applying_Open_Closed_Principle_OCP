
namespace CourseSubscriptionApp
{
    public class HybridCourse : Course
    {
        public HybridCourse() : base(new HybridSubscriptionService()) { }
    }
}
