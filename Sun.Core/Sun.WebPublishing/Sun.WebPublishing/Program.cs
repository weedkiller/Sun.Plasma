﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sun.Core.SelfUpdating;

namespace Sun.WebPublishing
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var publisher = new WebPublisher();
            var selfUpdater = new SelfUpdater();

            // --------------------------------------------
            // Sun.SelfUpdater
            // --------------------------------------------
            var selfUpdaterApp = selfUpdater.GetApplication("Sun.SelfUpdater", SelfUpdater.SUN_UPDATER_ROOTURL);

            publisher.PublishApplication(
                // App to publish
                selfUpdaterApp,
                // Local exe path
                @"C:\Users\TinoMaik\Source\Repos\Sun.Plasma\Sun.SelfUpdater\Sun.SelfUpdater\Sun.SelfUpdater\bin\Release\Sun.SelfUpdater.exe",
                // Bugfixes
                new List<string>() { },
                // New stuff
                new List<string>() { 
                    "Updated from .Net Framework v4.0 to .Net Framework v4.5"
                },
                // Files to delete
                new List<string>(),
                // FTP Server
                "systemsunitednavy.com",
                // User
                "RononDex",
                // Private key file
                @"B:\Atlantis-LAB1\dev\Plasma\SUN_PrivateKey_Converted.ppk",
                //Passphrase to encrypt private file
                "W0RKINSTAL",
                // Folder path
                "/apps");

            // --------------------------------------------
            // Sun.Plasma
            // --------------------------------------------            
            var plasmsApp = selfUpdater.GetApplication("Sun.Plasma", SelfUpdater.SUN_UPDATER_ROOTURL);

            publisher.PublishApplication(
                // App to publish
                plasmsApp, 
                // Local exe path
                @"C:\Users\TinoMaik\Source\Repos\Sun.Plasma\Sun.Plasma\Sun.Plasma\bin\Release\Sun.Plasma.exe",
                 // Bugfixes
                new List<string>() {
                    "Network related stuff (for example loading news feed) now also works when you are behind a proxy",
                    "AppData files (logfiles, SunLogin.blob) now get stored correctly in their own subfolder instead of directly in %APPDATA%",
                    "Increased security when storing credentials using 'Remember Me' in the login screen. Your credentials are now getting encrypted using a 2048-bit key that changes everytime you log in, and the key is safely stored in your registery only your user can access.",
                    "Fixed a bug, where the ScrollWheel in the news window would not work",
                    "Fixed a bug in the self-updating mechanism (missing file)." },
                // New stuff
                new List<string>() { 
                    "Updated from .Net Framework v4.0 to .Net Framework v4.5",
                    "New option on login screen to automatically launch application on windows startup (will be moved to Settings window later)",
                    "Added 'Coming Soon' screens to menu entries that are not implemented yet.",
                    "Added 'Fleet Resources' menu item, that opens browsers with the fleet resources",
                    "Added 'My Account' control (is only a clickdummy atm)",
                    "Some UI / style adjustements (rounded window corners, ...)",
                    "Star Citizen can now be launched directly from Sun.Plasma",
                    "Made applications compatible with Windows 10 (untested)",
                    "Added buttons to launch mumble and star citizen from the tray icon",
                    "More stuff gets logged into the logfile now, for easier bugfixing"
                },
                // Files to delete
                new List<string>(),
                // FTP Server
                "systemsunitednavy.com",
                // User
                "RononDex",
                // Private key file
                @"B:\Atlantis-LAB1\dev\Plasma\SUN_PrivateKey_Converted.ppk",
                //Passphrase to encrypt private file
                "W0RKINSTAL",
                // Folder path
                "/apps");
        }
    }
}
