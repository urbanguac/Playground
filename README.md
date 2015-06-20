Stuff:

To use the source:
1) Without a network (in Unity)
In the Euphoriatic Main scene, find UserSpawns object. Disable the two network scripts on it.
Inside UserSpawns, find Spawn 5. There's a player inside it. Disable the two network scripts on the player.
On the player object, also disable NetworkEnabled in the MovePlain component.

2) With a network (.exe)
In the Euphoriatic Main scene, find UserSpawns object. Enable the two network scripts on it.
Inside UserSpawns, find Spawn 5. There's a player inside it. Enable the two network scripts on the player.
On the player object, also enable NetworkEnabled in the MovePlain component.
Open Build Settings. Check off Menu, WaitRoom, and Euphoriatic Main scenes. Build it.
The .exe should work now.

To use multiplayer:
1) Finish your edits. Push back to GitHub, or if you're unintelligible send it to Priansh in a zip or something.
2) I'll compile the server scene and send it to the server we have. The server runs continuously forever and ever.
3) You will then be able to join the beta room the server is hosting.
