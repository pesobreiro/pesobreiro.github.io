-------------------------------------------------------------------
Active Directory Remote Control Add-On  
-------------------------------------------------------------------

Author: Yossi Saharon, Microsoft
Version: 1.0d
Last Update: Mar. 21, 2003

Email your comments to: yossis@microsoft.com

-----------------
License Agreement
-----------------
All software is provided by contributors "AS IS" and any express or implied warranties, including, but not limited to, the implied warranties of merchantability and fitness for a particular purpose are disclaimed. In no event shall Microsoft and its employees, or anyone on their behalf, be liable for any direct, indirect, incidental, special, exemplary, or consequential damages (including, but not limited to, procurement of substitute goods or services; loss of use, data or profits; or business interruption) however caused and on any theory of liability, whether in contract, strict liability, or tort (including negligence or otherwise) arising in any way out of the use of these software(s), even if advised of the possibility of such damage.

---------
CONTENTS
---------

1. Required Files

2. Application Description

3. How it works

4. How to Install 'Remote Control'

5. Known Issues 

------------------
1. Required files
------------------

Make sure you have the following files:

- Readme_first.txt (this file)
- rControl.exe (the Remote Control application/add-on)
- rControl_Setup.exe (The AD MMC extensions installation/Removal program)

----------------------------
2. APPLICATION DESCRIPTION
----------------------------

This tool opens a Remote Desktop connection from Active Directory MMC snap-ins to computers running Windows 2003 Server or Windows 2000/2003 Terminal Servers Or Windows XP Professional. Active Directory Remote Control Add-On (RControlAD) makes it easier for administrators to remotely administer servers.

This add-on adds the option to right-click a computer account in the Active Directory MMC and choose 'Remote Control' as an action on that computer, by opening a Terminal/Remote Desktop connection to that machine.

'Remote Control' relays on the Remote Desktop Connection application which is
built-in with Windows XP Professional and Windows 2003 Servers only, but can 
be added and installed separately for Windows 9x/NT/2000.


-----------------
3. How it works
-----------------

'Remote Control' reads the computer's host name from the AD MMC
and runs the mstsc.exe application to connect to that computer.

-----------------------------------
4. How to Install 'Remote Control'
-----------------------------------

In order to run the application you need to perform 2 steps:
1. Add the appropriate display extension to AD MMC (Done only Once by the setup program)
2. Put the rControl.exe tool in a locatable path (In every machine you wish to use this add-on from)

To add the appropriate display extension, just run rControl_Setup.exe,
and choose 'Install'. This Install needs to be done ONCE and affects the AD
MMC Snap-Ins in all the AD forest. It does not extend the AD schema. 

Then, you should put the rControl.exe tool in a locatable path on EVERY machine 
from which you're going to use the 'Remote Control' action inside the AD MMCs.
You can simply copy it to the systemroot (\WINNT), for example.

----------------
5. Known Issues 
----------------

Version 1.0c fixes an issue when controlling Windows 2003 post-RC2 accounts.

There are no known technical issues. For basic troubleshooting steps, 
please read and understand the following:
A) The Setup program (rControl_Setup.exe) needs to be run by a Domain administrator.
B) The option to Remote Control the computer from right-click will be available for ANY
client that connects to AD Users & Computers MMC after you ran the setup once, BUT it can 
only be USED by clients/Servers that:
1) Have ADSI installed (DSCLient in Win9x/NT4 or built-in for Win2000 and above).
2) Have mstsc.exe installed (Latest Remote Desktop client, built in for XP and above).
2) Have rControl.exe copied to their local path drive (e.g. systemroot).

-Yossi