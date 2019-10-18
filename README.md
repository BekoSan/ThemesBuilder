# ThemesBuilder
This is a simple themes builder , that helps you to create simple themes for your windows forms application.

## How to use ?

1 - Download and install the package from nuget.org.

2 - Add reference for the library.

3 - Create Themes classes like this and Implement the IThemeFactory Interface.


![Dark theme class](https://github.com/BekoSan/ThemesBuilder/blob/master/Images/DarkTheme.png)

![Light theme class](https://github.com/BekoSan/ThemesBuilder/blob/master/Images/LightTheme.png)


4 -  Call the IntilaizeTheme() method form ThemesManager class and pass the theme you want to apply.


![Apply theme](https://github.com/BekoSan/ThemesBuilder/blob/master/Images/ApplyTheTheme.gif)


5 - Call SetupUI() method for evrey form's constructor , to apply theme on it.


![Apply Form Theme](https://github.com/BekoSan/ThemesBuilder/blob/master/Images/ApplyTheThemeForm.gif)


### Light Theme Form

![Light Theme](https://github.com/BekoSan/ThemesBuilder/blob/master/Images/LightForm.png)


### Dark Theme Form

![Dark Theme](https://github.com/BekoSan/ThemesBuilder/blob/master/Images/DarkForm.png)
