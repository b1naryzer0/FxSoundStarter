# FxSoundStarter
I really like FxSound and use it as equalizer under Windows 11.

Unfortunately, I have more than one sound card and FxSounds 
reliably fails to remind the one I want to use. So I start 
a taskjob with this EXE when logging in or unlocking my box.

This tiny app (128kb optimized, dependent on NET 8) 
- checks for fxsound.exe
- kills it (hits on it multiple times with a hammer until there is nothing left)
- waits a bit
- then restarts fxsound.exe with a chosen audio device as attribute.


