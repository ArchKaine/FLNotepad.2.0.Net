# FLNotepad.2.0.Net
A small and compact text and rtf editor, with additional capabilities. Can create shiparch.ini entries via FLMM 1.4 for the Microsoft Game Freelancer, as well as edit Freelancer save game files.

A brief history of FLNP:

1.0: First release, buggy, but was able to render FL save game files, but not save them properly. Also handled standard text files reasonably well. Had no search functionality at all.

1.5 Added Additional FL savegame file handling functionality, and also added full RTF file support. Still no search functionality. Was written to take advantage of MDI, but it proved to be too much of a bear to code for, so I reverted to SDI in 2.0.

2.0 Full Search added, also enabled search in the about box, just for fun. Future versions will hopefully have faster Search and Replace functionality. But in this form, the search and replace can do Wildcard, Regex, and normal text searches. Version 2.0 is also a total rewrite of the software, restarting from the very beginning. As a result, I believe that it is far faster and more stable even than the previous version, which was also extremely stable.

Future plans:

I plan to expand on 2.0 until I feel that it is fully featured enough to justify an attempt at upgrading to 3.0 with new features and capabilities, so any suggestions are welcome.

3.0 will be written to be renderable on either Windows Vista, using Windows Presentation Foundation (pretty graphics) or XP's normal themed mode. It will also be able to print, and work in either MDI or SDI modes (multiple files at once, or just one at a time). If you have any ideas on what you would like to see included, please let me know. I already plan to try to add BINI decoding and recoding support.

