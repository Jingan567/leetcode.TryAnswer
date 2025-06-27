using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.TryAnswer
{
    #region 70. 爬楼梯
    /*
     * 假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
     * 每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
     * 
     * 示例 1：
     * 输入：n = 2
     * 输出：2
     * 解释：有两种方法可以爬到楼顶。
     * 1. 1 阶 + 1 阶
     * 2. 2 阶
     * 
     * 示例 2：
     * 输入：n = 3
     * 输出：3
     * 解释：有三种方法可以爬到楼顶。
     * 1. 1 阶 + 1 阶 + 1 阶
     * 2. 1 阶 + 2 阶
     * 3. 2 阶 + 1 阶
     * 
     * 提示：
     * 1 <= n <= 45
     */
    #endregion
    public class Solution70
    {
        public int ClimbStairs(int n)
        {
            #region 错误代码
            //这种方法是错误的，因为它会计算出所有可能的组合，但并没有考虑到重复的情况。
            //int count = 0;
            //for (int x = 0; x < 45; x++)
            //{
            //    for (int y = 0; y < 23; y++)
            //    {
            //        if ((x + 2 * y) == n) count++;
            //    }
            //}
            //return count;
            #endregion


            #region 正确代码
            //动态规划+滚动数组
            int p = 0, q = 0, r = 1;
            for (int i = 1; i <= n; ++i)
            {
                p = q;
                q = r;
                r = p + q;
            }
            return r;
            #endregion
        }
    }
}
