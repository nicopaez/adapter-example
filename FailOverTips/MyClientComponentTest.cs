namespace FailOverTips
{
    using Moq;
    using NUnit.Framework;
    using System.Data.Common;

    [TestFixture]
    public class MyClientComponentTest
    {
        [Test]
        public void ShouldCallGetConnection()
        {
            DbConnection conn = new Mock<DbConnection>().Object;
            var connManagerMock = new Mock<IConnectionManager>();
            connManagerMock.Setup(x => x.GetConnection(It.IsAny<DbEnum>())).Returns(conn);
            var myComponent = new MyClientComponent(connManagerMock.Object);

            myComponent.DoSomeOperationWithDB();

            connManagerMock.Verify(x => x.GetConnection(DbEnum.FM), Times.Once);
        }
    }
}
