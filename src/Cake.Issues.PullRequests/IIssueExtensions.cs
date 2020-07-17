namespace Cake.Issues.PullRequests
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extensions for the IIssue-Interface
    /// </summary>
    public static class IIssueExtensions
    {
        /// <summary>
        /// Sorts issues based on the following criteria:
        /// 1. Priority (descending)
        /// 2. AffectedFileRelativePath is null?
        /// 3. The AffectedFileRelativePath's FullPath.
        /// </summary>
        /// <param name="issues">Issues to be sorted</param>
        /// <returns>The sorted issues</returns>
        public static IEnumerable<IIssue> SortWithDefaultPriorization(this IEnumerable<IIssue> issues)
        {
            return issues
                .OrderByDescending(x => x.Priority)
                .ThenBy(x => x.AffectedFileRelativePath is null)
                .ThenBy(x => x.AffectedFileRelativePath?.FullPath);
        }
    }
}