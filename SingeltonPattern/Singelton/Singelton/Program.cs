using Singelton;

class Program
{
    static void Main(string[] args)
    {
        Logger logger = Logger.GetInstance();
        logger.Log("Application started");

        PerformSomeOperation();

        logger.Log("Application finished successfully");
    }

    static void PerformSomeOperation()
    {
        Logger logger = Logger.GetInstance();
        logger.Log("Performing some operation");
        try
        {
            logger.Log("Operation completed successfully");
        }
        catch (Exception ex)
        {
            logger.Log($"Error occurred: {ex.Message}");
        }
    }
}