namespace Cake.Issues.PullRequests
{
    /// <summary>
    /// Defines issue limits for a specific provider.
    /// </summary>
    public interface IProviderIssueLimits
    {
        /// <summary>
        /// Gets or sets the global number of issues which should be posted at maximum over all
        /// <see cref="IIssueProvider"/>.
        /// Issues are filtered by <see cref="IIssue.Priority"/> and issues with an <see cref="IIssue.AffectedFileRelativePath"/>
        /// are prioritized.
        /// Default is <c>null</c> which won't set a global limit.
        /// Use <see cref="MaxIssuesToPostAcrossRuns"/> to set a limit across multiple runs.
        /// </summary>
        int? MaxIssuesToPost { get; set; }

        /// <summary>
        /// Gets or sets the global number of issues which should be posted at maximum over all
        /// <see cref="IIssueProvider"/> and across multiple runs.
        /// Issues are filtered by <see cref="IIssue.Priority"/> and issues with an <see cref="IIssue.AffectedFileRelativePath"/>
        /// are prioritized.
        /// Default is <c>null</c> which won't set a limit across multiple runs.
        /// Use <see cref="MaxIssuesToPost"/> to set a limit for a single run.
        /// </summary>
        int? MaxIssuesToPostAcrossRuns { get; set; }
    }
}