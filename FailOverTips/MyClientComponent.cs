namespace FailOverTips
{
    using System;

    public class MyClientComponent
    {
        private IConnectionManager connManager;

        public MyClientComponent(IConnectionManager connManager)
        {
            this.connManager = connManager;
        }

        public void DoSomeOperationWithDB()
        {
            var conn = this.connManager.GetConnection(DbEnum.FM);
            Console.WriteLine($"Let's do something with this conenction: {conn.ToString()}");
        }
    }
}
