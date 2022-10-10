using Playnite.SDK;
using Playnite.SDK.Events;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PlayniteOverlay
{
    public class PlayniteOverlay : GenericPlugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        private PlayniteOverlaySettingsViewModel settings { get; set; }

        public override Guid Id { get; } = Guid.Parse("fd8e7aeb-d6d7-4569-91c7-8bfa520c5934");

        public PlayniteOverlay(IPlayniteAPI api) : base(api)
        {
            settings = new PlayniteOverlaySettingsViewModel(this);
            Properties = new GenericPluginProperties
            {
                HasSettings = true
            };

            public string fontFamily = IPlayniteSettingsAPI.FontFamilyName;
            List<data> settingsData = new List<data>();
            settingsData.Add(new data() { 
                font = fontFamily;
                gamePID = " ";
            });
            
            string json = JsonSerializer.Serialize(settingsData)
            File.WriteAllText(@"%appdata%/Playnite/ExtensionsData/fd8e7aeb-d6d7-4569-91c7-8bfa520c5934/OverlaySettings.json", json);
        }

        public override void OnGameInstalled(OnGameInstalledEventArgs args)
        {
            // Add code to be executed when game is finished installing.
        }

        public override void OnGameStarted(OnGameStartedEventArgs args)
        {
            // Add code to be executed when game is started running.
            if (args.SourceAction.IsPlayAction == true)
            {
                Int32 GamePID = args.StartedProcessID;
            }
        }

        public override void OnGameStarting(OnGameStartingEventArgs args)
        {
            // Add code to be executed when game is preparing to be started.
        }

        public override void OnGameStopped(OnGameStoppedEventArgs args)
        {
            // Add code to be executed when game is preparing to be started.
        }

        public override void OnGameUninstalled(OnGameUninstalledEventArgs args)
        {
            // Add code to be executed when game is uninstalled.
        }

        public override void OnApplicationStarted(OnApplicationStartedEventArgs args)
        {
            // Add code to be executed when Playnite is initialized.
        }

        public override void OnApplicationStopped(OnApplicationStoppedEventArgs args)
        {
            // Add code to be executed when Playnite is shutting down.
        }

        public override void OnLibraryUpdated(OnLibraryUpdatedEventArgs args)
        {
            // Add code to be executed when library is updated.
        }

        public override ISettings GetSettings(bool firstRunSettings)
        {
            return settings;
        }

        public override UserControl GetSettingsView(bool firstRunSettings)
        {
            return new PlayniteOverlaySettingsView();
        }
    }
}