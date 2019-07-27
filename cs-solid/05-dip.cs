// File: 05-dip.cs
// Desc: Dependency Inversion Principle（依赖反转原则）
// Desc: 认为一个方法应该遵从依赖于抽象而不是一个实例，控制反转，依赖注入是该原则的一种实现

namespace DependencyInversionPrinciple
{
    using System;

    /// <summary>
    /// 银行账户接口
    /// </summary>
    interface IBankAccount
    {
        /// <summary>
        /// 卡号
        /// </summary>
        long BankNumber { get; set; }

        /// <summary>
        /// 余额
        /// </sumamry>
        decimal Balance { get; set; }
    }

    /// <summary>
    /// 转账人接口
    /// </summary>
    interface ITransferSource: IBankAccount
    {
        /// <summary>
        /// 减少账户余额
        /// </summary>
        void CutPayment(decimal value);
    }

    /// <summary>
    /// 收款人接口
    /// </summary>
    interface ITranserDestination: IBankAccount
    {
        /// <summary>
        /// 增加账户余额
        /// </summary>
        void AddMoney(decimal value);
    }

    /// <summary>
    /// 银行帐号类
    /// </summary>
    class BankAccount: IBankAccount, ITransferSource, ITranserDestination
    {
        /// <summary>
        /// 银行卡号，实现IBankAccount中的BankNumber
        /// </summary>
        public long BankNumber { get; set; }

        /// <summary>
        /// 余额，实现实现IBankAccount中的Balance
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 减少账户余额
        /// </summary>
        public void CutPayment(decimal value)
        {
            Balance -= value;
        }

        /// <summary>
        /// 增加账户余额
        /// </summary>
        public void AddMoney(decimal value)
        {
            Balance += value;
        }
    }

    /// <summary>
    /// 交易类
    /// </summary>
    class TransferAmount
    {
        /// <summary>
        /// 交易金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 执行转账交易
        /// </summary>
        public void Transfer(ITransferSource source, ITranserDestination dest)
        {
            source.CutPayment(Amount);
            dest.AddMoney(Amount);
        }
    }

    /// <summary>
    /// 转账交易测试程序
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 创建相关交易参与的对象实例
            ITransferSource source = new BankAccount { Balance=10000, BankNumber=111 };
            ITranserDestination dest = new BankAccount { Balance=1, BankNumber=222 };
            TransferAmount transfer = new TransferAmount();
            
            // 指定交易金额，进行转账
            transfer.Amount = 9999;
            transfer.Transfer(source, dest);

            // 输出转账后的余额
            Console.WriteLine("source balance: {0}", source.Balance);
            Console.WriteLine("dest balance: {0}", dest.Balance);
        }
    }   
}