using System;
using System.Threading;
using System.Threading.Tasks;

namespace List0412
{
	class BankAccount
	{
		public int Balance { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			// 创建一个BankAccount数组
			var accounts = new BankAccount[5];
			for(int i=0; i<accounts.Length; i++)
				accounts[i] = new BankAccount();

			// 统计账户总余额的变量
			int totalBalance = 0;
			
			// 创建一个barrier
			var barrier = new Barrier(5, (myBarrier) => {
				totalBalance = 0;
				foreach(var account in accounts)
					totalBalance += account.Balance;
				Console.WriteLine("Total: {0}", totalBalance);
			});
	
			// 定义一个Task数组
			var tasks = new Task[5];

			// 循环创建任务
			for (int i=0; i < tasks.Length; i++)
			{
				tasks[i] = new Task((stateObj) => {

					// 为account对象创建类型reference
					var account = (BankAccount)stateObj;

					// start of phase
					var rnd = new Random();
					for (int j = 0; j < 1000; j++)
						account.Balance += rnd.Next(1, 100);
					// end of phase

					// 告诉用户本Task已经结束
					Console.WriteLine(
						"Task {0}, phase {1} ended",
						Task.CurrentId,
						barrier.CurrentPhaseNumber
					);

					// start of phase
					// alter of balance of this Task's account using the
					// toal balance deduct 10% of the difference from the
					// total balance
					account.Balance -= (totalBalance - account.Balance) / 10;
			
					// 告诉用户当前Task已结束
					Console.WriteLine(
						"Task {0}, phase {1} ended",
						Task.CurrentId,
						barrier.CurrentPhaseNumber
					);

					// singal the barrier
					barrier.SignalAndWait();

				}, accounts[i]);
			}

			// 启动任务
			foreach (Task t in tasks)
				t.Start();

			// 等待所有的任务结束
			Task.WaitAll(tasks);

			// 退出操作
			Console.WriteLine("Press eneter to finish");
			Console.ReadLine();
		}
	}
}
