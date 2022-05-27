using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Flow.Launcher.Plugin.SharedCommands;

namespace Flow.Launcher.Plugin.AwsToolkit
{
    /// <summary>
    /// Main plugin class
    /// </summary>
    public class Main: IPlugin
    {
        private List<ConsoleService> _services;

        /// <summary>
        /// Filters AWS Console services by query. Selecting a result opens the AWS Console service URL in a new
        /// browser tab.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<Result> Query(Query query)
        {
            var results = new List<Result>();
            if (string.IsNullOrEmpty(query.Search)) return results;
            var keyword = query.Search;

            var searchList = _services.Where(x => x.Command.ToLower().Contains(keyword));

            results.AddRange(searchList.Select(s => new Result
            {
                Title = s.Command,
                SubTitle = s.Description,
                IcoPath = $"Images\\{s.Command}.png",
                Action = _ =>
                {
                    try
                    {
                        s.Url.OpenInBrowserTab();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }));

            return results;
        }

        /// <summary>
        /// Plugin initialization. Reads AWS Console services data from console-service.jsonl 
        /// </summary>
        /// <param name="context"></param>
        public void Init(PluginInitContext context)
        {
            _services = File.ReadLines($"{context.CurrentPluginMetadata.PluginDirectory}\\console-services.jsonl").ToList().ConvertAll(
                line => JsonSerializer.Deserialize<ConsoleService>(line));
        }
    }
}