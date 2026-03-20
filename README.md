# Link to [the bug](https://developercommunity.visualstudio.com/t/WinUI3-MicrosoftUI-creates-broken/11062978)

This is reported to Microsft [via feedback](https://developercommunity.visualstudio.com/t/WinUI3-MicrosoftUI-creates-broken/11062978)

### Copy of the bug text

Like ever to many people I've run into the XAML Parsing fail exception. In my case, though, I've got an absolutely trivial repro of the weirdest fricken problem. And it's helpfully up on Github in a public repro: https://github.com/pedasmith/bug_WinUI3_usercontrol_in_folder_xaml_parse

Repro steps:
1. Make a perfectly ordinary Blank WinUI (WinUI3, AFAICT) project and solution
    THIS IS THE FIRST COMMIT!
2. Add a UserControl to the top level folder, where the mainwindows.xaml is. 
3. And heck, make an empty sub-folder too and call it "folder_for_control"
4. To help debugging, add in a <TextBlock>
5. Switch to ARM64 mode because I'm on one of the shiny new Surface ARM devices, and press F5
6. Expected and actual results: the app runs
    THIS IS THE "Added UserControl to top level" commit
7. Add a UserControl to the sub-folder you made in step 3.
8. Press F5 to build and run. Or to a build/clean and build/rebuild and run
9 Expected result: app runs
   Actual result: **app throws exception** "Unhandled XamlParseException in SettingsPage: XAML parsing failed"



