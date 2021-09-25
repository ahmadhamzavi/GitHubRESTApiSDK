using GitHubRESTApiSDK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubRESTApiSDK
{
    public interface IGitHubClient: IDisposable
    {
        Task<List<GitRepository>> Repositories();
    }
}
