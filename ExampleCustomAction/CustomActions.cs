using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ExampleCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult LaunchNotepadPlusPlus(Session session)
        {
            session.Log("Begin LaunchNotepadPlusPlus");

            try
            {
                // Get the install location of Notepad++
                string installLocation = "C:/Program Files/Notepad++";

                // Construct the full path to notepad++.exe
                string notepadPlusPlusPath = System.IO.Path.Combine(installLocation, "notepad++.exe");

                // Start Notepad++
                Process.Start(notepadPlusPlusPath);
            }
            catch (Exception ex)
            {
                session.Log("Error in LaunchNotepadPlusPlus: {0}", ex.Message);
                return ActionResult.Failure;
            }

            session.Log("End LaunchNotepadPlusPlus");
            return ActionResult.Success;
        }
    }
}
