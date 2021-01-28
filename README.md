# PlaylistEditor
A db-based app configured with Entity Framework.

To start your project, download all the files and the backup file for the database. 
Restore the database in your db-manager.
Run the project and build it, then run it from VS if you like, or from the .exe file in your pathfolder.

Explanation on the different views: 
"CREATE PLAYLIST" - Where you create new playlist, only enter the title you want, and save. 'Cancel' takes you back to the "Home" view.

"EDIT PLAYLISTS" - Here the main thing is to add existing tracks to existing playlists. The tracks are displayed by genre.
Playlist can be deleted from here, tracks will remain in database. 

"ADD ARTIST" - This simple view let's you add a new Artist to the database. It will tell you if the artist already exists.
'Cancel' takes you back to the "Home" view.

"ADD ALBUM" - This is where you add new Albums to existing artists. Click on the artists name, and enter the title of the Album you
wish to add. You may also delete artists from here. This will delete all albums and tracks related to that artist, this is probably also the
best way to delete data in general. --- SEE 'KNOWN BUGS' FOR MORE INFO ---

"ADD TRACKS" - Here you can view existing tracks in albums already added to the database. Or you can add new tracks
to albums. There is also a possibilty to edit track titles and the length of the tracks in the Data Grid View.
You may delete tracks directly from the Data Grid View by selecting the row end press 'Delete' on your keyboard.
There is a possibilty to delete full albums from here, this will delete all tracks related to that album. 
I do advice you not to delete album-data this way. --- SEE 'KNOWN BUGS' FOR MORE INFO ---

-----

KNOWN BUGS

ISSE WITH DELETING ALBUM FROM "ADD TRACK" - If you delete album and its tracks from the "Add Tracks" view and procceed to delete the 'Artist' from
the 'Add Album' view, a concurrency exception will happen. I do not know how to resolve this atm, so for it to work properly,
delete artist directly instead of deleting albums. Tracks can be deletet from the "ADD TRACKS" view without issues. 

DESIGN BUG: Design of the application may vary. I ran it on my laptop, and some controls look really wierd. I have no sulotion for this atm.


LOADING TIMES - Some times the loaded data don't load directly when the control is focused. But if you switch around a bit in the menu, and come back
to the desired control, that usually fixes the issue. If not, reaload the app is the only way I have managed to get around it.

