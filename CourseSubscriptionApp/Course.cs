
namespace CourseSubscriptionApp
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        protected ISubscriptionService subscriptionService;

        public Course(ISubscriptionService subscriptionService)
        {
            this.subscriptionService = subscriptionService;
        }

        public void Subscribe(Student std)
        {
            subscriptionService.Subscribe(std);
        }
    }
}