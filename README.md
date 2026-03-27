# LoginLogger
A very small console application used for logging when I use my computer.

## Use
This application is very simple and can be activated manually, but I personally use the Windows Task Scheduler ("Shemaläggaren" those of you speaking Swedish) to make sure that it is executed automatically.

### Task Scheduler instructions
I created a new folder for my custom scripts. While having this folder selected you just click "Create action" in the right pane. And add the required information in the different tabs.

#### General Tab info
* Name: What ever you want to call the scheduled item (LogginLogger)
* Location: Folder where you want to place the scheduled task
* Under "Security option" I checked "Run only when the user is logged on".
I had no need to add anything else, but you might need modify more security options.

#### Triggers tab
Add a trigger here (I added one for when the computer is unlocked) and made it run for only my own personal user.

#### Actions tab
Add an action here for starting an application and add the path to the LoginLogger executable
