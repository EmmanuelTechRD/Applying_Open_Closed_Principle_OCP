using CourseSubscriptionApp;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        // Crear instancias de los cursos
        Course onlineCourse = new OnlineCourse();
        Course offlineCourse = new OfflineCourse();
        Course hybridCourse = new HybridCourse();

        // Probar la suscripción
        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
    }
}
