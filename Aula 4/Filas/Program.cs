using Filas;

static void Main(string[] args)
{
    CallCenter center = new CallCenter();
    Parallel.Invoke(
    () => CallersAction(center),
    () => ConsultantAction(center, "Marcin",
    ConsoleColor.Red),
    () => ConsultantAction(center, "James",
    ConsoleColor.Yellow),
    () => ConsultantAction(center, "Olivia",
    ConsoleColor.Green));
}

private static void CallersAction(CallCenter center)
{
    Random random = new Random();

    center.Call(1234);
    center.Call(5678);
    center.Call(1468);
    center.Call(9641);
    center.Call(4321);
    center.Call(1122);

    while (true)
    {
        int clientId = random.Next(1, 10000);
        int waitingCount = center.Call(clientId);
        Log($"Incoming call from {clientId}, waiting in the queue: {waitingCount}");
        Thread.Sleep(random.Next(1000, 5000));
    }
}




