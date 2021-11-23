using NUnit.Framework;

namespace Project1
{

	[TestFixture]
	public class Tests1
	{
		[Test]
		public static void FailedTest1()
		{
			Assert.Fail("To be failed");
		}

		[Test]
		public static void SuccessTest1()
		{
			
		}

		[Test]
		public static void NetCoreFailedTest()
		{
			#if NETCOREAPP
			Assert.Fail("Failed under netcore");
			#endif
		}
	}
}