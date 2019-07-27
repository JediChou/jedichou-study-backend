// sample0512.cs
// Wait() method, Pulse() method, PulseAll method from Monitor class
using System.Threading;
public class Program {
	static object ball = new object();
	public static void Main() {
		Thread threadPing = new Thread(ThreadPingProc);
		Thread threadPong = new Thread(ThreadPongProc);
		threadPing.Start(); threadPong.Start();
		threadPing.Join(); threadPong.Join();
	}
	static void ThreadPingProc() {
		System.Console.WriteLine("ThreadPing: Hello!");
		lock( ball )
			for( int i=0; i<5; i++) {
				System.Console.WriteLine("Threaing: Ping");
				Monitor.Pulse(ball);
				Monitor.Wait(ball);
			}
		System.Console.WriteLine("ThreadPing: Bye!");
	}
	static void ThreadPongProc() {
		System.Console.WriteLine("ThreadPong: Hello!");
		lock( ball )
			for( int i=0; i<5; i++) {
				System.Console.WriteLine("Threaing: Pong");
				Monitor.Pulse(ball);
				Monitor.Wait(ball);
			}
		System.Console.WriteLine("ThreadPong: Bye!");
	}
}
