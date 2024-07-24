
namespace CourseSubscriptionApp
{
    public class OfflineCourse : Course
    {
        public OfflineCourse() : base(new OfflineSubscriptionService()) { }
    }
}