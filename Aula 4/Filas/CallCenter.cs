using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0;
        public ConcurrentQueue<IncomingCall> Calls { get; private set; } = [];

        /*
            Atenção, metodos contrutores possuem o mesmo nome da classe (REGRA)
            São invocados quando constrói-se uma nova instância de objeto deste tipo
        */
        public CallCenter()
        {
            Calls = new ConcurrentQueue<IncomingCall>();
        }

        public int Call(int ClientId)
        {
            IncomingCall call = new IncomingCall();
            call.Id = ++_counter;
            call.ClientId = ClientId;
            call.CallTime = DateTime.Now;

            Calls.Enqueue(call);
            return Calls.Count;
        }

        public IncomingCall Answer(string Consultant)
        {
            if (Calls.Count > 0 && Calls.TryDequeue(out IncomingCall call))
            {
                call.Consultant = Consultant;
                call.StartTime = DateTime.Now;
                return call;
            }

            return null!;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }

    private static void Log(string text)
{
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
}

}