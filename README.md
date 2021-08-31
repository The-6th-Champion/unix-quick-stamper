# QuickUnix
a unix timestamp generating app

Can be used along side Discord, where it generates the <t:times:R> syntax for you. 

This is not affiliated with discord in any way

## How to use this app
Alright, So basically there is no correct way to use it. ~~which just means there is but I won't say it outloud.~~

The purpose of the app was to generate the timestamps as fast as possible, so the method I am about to show will explan how to do it.

### My way ~~best way~~

1. Download the app from the [Releases page](https://github.com/The-6th-Champion/unix-quick-stamper/releases)

2. Go through the installer.

3. You should now have shortcuts in your Desktop and Start Menu.
![](assets\images\Desktop-view.png)
![](assets\images\SMenu-view.png)

4. Go to the desktop Icon, and right click it.
![](assets\images\RC-Menu.png)

5. Click Properties at the bottom, and then go to the Shortcut tab in the popup.
![](assets\images\Properties-window.png)

6. Set the `Shortcut key` option to whatever you wish. For example, `Ctrl + Alt + T`. Then click `Apply` and `OK`
![](assets\images\Properties-window-apply.png)

7. Close the window, and input the shortcut key  you just made. If all goes well, the app should pop up.
![](assets\images\Complete.png)

### Afterwards

To use this, can input a string of text to make a timestamp. Formats below:
```py
now     # this will give the current time's TS
HH:mm     # this will give the specified time of the current day's TS (24hr time)
HH:mm     # this will give the specified time of the current day's TS (24hr time)
yyyy-MM-dd     # this will give the specified date's TS at 0:00
yyyy-MM-ddTHH:mm     # this will give the specified date and time's TS (you literally type the T EX) 2021-08-30T21:20 )
yyyy-MM-ddTHH:mm:ss     # this will give the specified date and time's TS (you literally type the T EX) 2021-08-30T21:20:59 )
yyyy-MM-ddTHH:mmzzz     # this will give the specified date and time's TS (you literally type the T EX) 2021-08-30T21:20 )
yyyy-MM-ddTHH:mm:sszzz     # this will give the specified date and time's TS (you literally type the T EX) 2021-08-30T21:20:59 )


# BUGGY
todays day. EX) monday, mon     # this will give the the start of the day's TS, either full name or three leter abbrv.
HH:mmZ     # this will give the specified time in UTC of the lats day's TS (24hr time) basically if you input 2:50Z, it will give you yesterday's 2:50+0000 timestamp. Weird to use
HH:mm:ssZ     # this will give the specified time in UTC of the lats day's TS (24hr time) basically if you input 2:50Z, it will give you yesterday's 2:50+0000 timestamp. Weird to use
```