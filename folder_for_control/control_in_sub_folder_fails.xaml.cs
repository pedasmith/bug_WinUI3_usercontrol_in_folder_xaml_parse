using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace bug_WinUI3_usercontrol_in_folder_xaml_parse.folder_for_control
{
    public sealed partial class control_in_sub_folder_fails : UserControl
    {
        public control_in_sub_folder_fails()
        {
            try
            {
                InitializeComponent();
            }
            catch (XamlParseException parseException)
            {
                Log_Fatal($"Unhandled XamlParseException in SettingsPage: {parseException.Message}");
                foreach (var key in parseException.Data.Keys)
                {
                    Log_Fatal($"{key}:{parseException.Data[key]?.ToString()}");
                }
                throw;
            }
        }

        private static void Log_Fatal(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
            Console.WriteLine(str);
        }

#if RESULTS_FROM_THE_LOG_FATAL

Unhandled XamlParseException in SettingsPage: XAML parsing failed.
Description:Unspecified error

RestrictedDescription:Cannot locate resource from 'ms-appx:///folder_for_control/control_in_sub_folder_fails.xaml'.
RestrictedErrorReference:
RestrictedCapabilitySid:
__RestrictedErrorObjectReference:WinRT.ObjectReferenceWithContext`1[WinRT.Interop.IUnknownVftbl]
__HasRestrictedLanguageErrorObject:False
Exception thrown: 'Microsoft.UI.Xaml.Markup.XamlParseException' in bug_WinUI3_usercontrol_in_folder_xaml_parse.dll
WinRT information: Cannot locate resource from 'ms-appx:///folder_for_control/control_in_sub_folder_fails.xaml'.
XAML parsing failed.

#endif
    }
}
