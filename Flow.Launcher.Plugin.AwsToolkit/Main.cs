using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Flow.Launcher.Plugin;
using Flow.Launcher.Plugin.SharedCommands;

namespace Flow.Launcher.Plugin.AwsToolkit
{
    public class Main: IPlugin
    {
        private List<ConsoleService> _services;

        public List<Result> Query(Query query)
        {
            var results = new List<Result>();
            if (string.IsNullOrEmpty(query.Search)) return results;
            var keyword = query.Search;

            var searchList = _services.Where(x => x.command.ToLower().Contains(keyword));

            results.AddRange(searchList.Select(s => new Result
            {
                Title = s.command,
                SubTitle = s.description,
                IcoPath = $"Images\\{s.command}.png",
                Action = c =>
                {
                    try
                    {
                        s.url.OpenInBrowserTab();
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

        public void Init(PluginInitContext context)
        {
            _services = File.ReadLines($"{context.CurrentPluginMetadata.PluginDirectory}\\console-services.jsonl").ToList().ConvertAll(
                line => JsonSerializer.Deserialize<ConsoleService>(line));
        }
    }
}