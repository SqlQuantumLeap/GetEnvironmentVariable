# GetEnvironmentVariable
**Get the current value of a User- or Machine- scoped environment variable.**


**GetEnvironmentVariable** is a command-line utility -- a .NET Console App -- that returns the _current_ value of a _User_- (or even _Machine_-) scoped environment variable.

Since it is not possible to pass a _Process_-scoped environment variable back up to the parent / calling process (at least not without a lot of work), that leaves very few options when wanting to pass back a value from a program without creating a file.

User environment variables and Machine environment variables can, however, be passed back to the parent / calling process because they are saved in the Registry. The problem with using either of these is that only new processes are aware of the new values, but the parent / calling process does not reload environment variables, so changes in these two scopes are not immediately known.

It is possible to use [REG QUERY](https://technet.microsoft.com/en-us/library/cc742028.aspx) to get the current value, but it is not easily usable due to all of the extra formatting around the value that is returned:

    C:\>REG QUERY HKCU\Environment /v _MyTest
    
    HKEY_CURRENT_USER\Environment
        _MyTest    REG_SZ    bob

It is much easier to simply do:

    C:\>GetEnvironmentVariable.exe -name _MyTest
    bob

The reduced output makes it very easy to get the User or Machine environment variable into a local variable in a CMD script (i.e. batch file) using the `FOR` command:

**Outside of a script:**

    C:\>FOR /F %A IN ('GetEnvironmentVariable.exe -name _MyTest') DO @SET _TempVariable=%A
    C:\>echo %_TempVariable%
    bob
    
**Inside of a script:**

Contents of **TestGetVariable.cmd**:

    @ECHO OFF

    FOR /F %%A IN ('GetEnvironmentVariable.exe -name _MyTest') DO SET _TempScriptVariable=%%A

    ECHO Found: %_TempScriptVariable%

Running **TestGetVariable.cmd**:

    C:\>TestGetVariable.cmd
    Found: bob

