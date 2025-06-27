using leetcode.TryAnswer;

namespace leetcode.TestProject;

public class Solution70Test
{
    /// <summary>
    /// 这是一个带有 [SetUp] 特性的空方法。
    /// NUnit 会在每个测试方法执行前自动调用它，通常用于初始化测试环境或准备测试数据。
    /// 当前方法体为空，表示没有特殊的初始化逻辑。
    /// </summary>
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// 这是一个带有 [Test] 特性的测试方法。NUnit 会自动识别并运行它。
    /// 方法体内调用了 Assert.Pass();，这表示该测试无条件通过。
    /// </summary>
    [Test]
    public void ClimbStairsTest1()
    {
        Solution70 solution = new Solution70();
        var res = solution.ClimbStairs();
        
    }
}
