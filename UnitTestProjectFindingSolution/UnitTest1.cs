using FindingSolution1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectFindingSolution
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod_Remove_one_number()
    {
      const string source1 = "12345678910";
      const int source2 = 3;
      const string expected = "1245678910";
      string result = Program.Remove(source1, source2);
      Assert.AreEqual(expected, result);
    }
  }
}