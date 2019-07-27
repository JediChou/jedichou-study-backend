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
			// ����һ��BankAccount����
			var accounts = new BankAccount[5];
			for(int i=0; i<accounts.Length; i++)
				accounts[i] = new BankAccount();

			// ͳ���˻������ı���
			int totalBalance = 0;
			
			// ����һ��barrier
			var barrier = new Barrier(5, (myBarrier) => {
				totalBalance = 0;
				foreach(var account in accounts)
					totalBalance += account.Balance;
				Console.WriteLine("Total: {0}", totalBalance);
			});
	
			// ����һ��Task����
			var tasks = new Task[5];

			// ѭ����������
			for (int i=0; i < tasks.Length; i++)
			{
				tasks[i] = new Task((stateObj) => {

					// Ϊaccount���󴴽�����reference
					var account = (BankAccount)stateObj;

					// start of phase
					var rnd = new Random();
					for (int j = 0; j < 1000; j++)
						account.Balance += rnd.Next(1, 100);
					// end of phase

					// �����û���Task�Ѿ�����
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
			
					// �����û���ǰTask�ѽ���
					Console.WriteLine(
						"Task {0}, phase {1} ended",
						Task.CurrentId,
						barrier.CurrentPhaseNumber
					);

					// singal the barrier
					barrier.SignalAndWait();

				}, accounts[i]);
			}

			// ��������
			foreach (Task t in tasks)
				t.Start();

			// �ȴ����е��������
			Task.WaitAll(tasks);

			// �˳�����
			Console.WriteLine("Press eneter to finish");
			Console.ReadLine();
		}
	}
}
