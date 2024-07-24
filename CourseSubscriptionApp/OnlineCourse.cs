
namespace CourseSubscriptionApp
{
    public class OnlineCourse : Course
    {
        public OnlineCourse() : base(new OnlineSubscriptionService()) { }
    }
}
