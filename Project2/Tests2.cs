using NUnit.Framework;

namespace Project2
{

	public class Tests2
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
	}
}