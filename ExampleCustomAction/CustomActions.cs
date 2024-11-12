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
        public static ActionResult CustomAction(Session session)
        {
            return ActionResult.Success;
        }
    }
}
