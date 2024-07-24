
namespace CourseSubscriptionApp
{
    public class HybridSubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionService onlineService;
        private readonly ISubscriptionService offlineService;

        public HybridSubscriptionService()
        {
            this.onlineService = new OnlineSubscriptionService();
            this.offlineService = new OfflineSubscriptionService();
        }

        public void Subscribe(Student std)
        {
            // Código para subscribir tanto a un curso online como offline
            onlineService.Subscribe(std);
            offlineService.Subscribe(std);

            // Mensajes indicando la suscripción a todos los cursos
            Console.WriteLine("Suscrito al curso de modalidad virtual.");
            Console.WriteLine("Suscrito al curso de modalidad presencial.");
            Console.WriteLine("Suscrito al curso de modalidad híbrida.");
        }
    }
}