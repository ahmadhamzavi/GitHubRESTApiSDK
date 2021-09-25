using GitHubRESTApiSDK;
using GitHubRESTApiSDK.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace GitHubRESTApiConsoleApp
{
    class Program
    {
        static string Url = "https://api.github.com";
        static void Main(string[] args)
        {
            var gitHubClient = GitHubClient.getInstance(Url, ReadAccessToken());
            var repositories = gitHubClient.Repositories().GetAwaiter().GetResult();
            ShowReposiories(repositories);

            gitHubClient.Dispose();
            Console.ReadLine();
        }

        static void ShowReposiories(List<GitRepository> repositories)
        {
            var repositoryTable = ConsoleTable.getInstance(new string[] { "name", "language", "owner", "description" });
            if (repositories.IsNotNull() && repositories.Count > 0)
            {
                repositoryTable.PrintHeaders();
                foreach (var repo in repositories)
                {
                    repositoryTable.PrintData(new string[] { repo.name, repo.language??"", repo.owner.login, repo.description ?? "" });
                }
            }
        }
        static string ReadAccessToken()
        {
            Console.WriteLine("Please enter git hub AccessToken ");
            Console.WriteLine("Like:ghp_n90TrRQ6hghfgdfgfdeJ4diUiFFyRqjm3GfeC9");
            Console.WriteLine("Create access token:");
            Console.WriteLine("\t Login to Github.com");
            Console.WriteLine("\t Goto https://github.com/settings/tokens");
            Console.WriteLine("\t Use Personal access tokens tab");
            Console.Write("Access Token:");
            var token = Console.ReadLine();
            if (token.IsNullOrWhiteSpace())
            {
                token = ReadAccessToken();
            }
            return token;
        }
    }
}
