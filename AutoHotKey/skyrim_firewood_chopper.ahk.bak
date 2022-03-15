/*
#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

mehet=true

^!p:: ;Ctrl + Alt + p
;print mouse position
	MouseGetPos, xpos, ypos 
	Click 500, 500, 1
	MsgBox moved, %xpos%, %ypos%
	MsgBox %mehet%
return


^b::
	mehet = false
	MsgBox %mehet%
return

^!c::
	i = 0
	while mehet
		msgbox %i%, %mehet%
		%i% = (%i%+1)
	MsgBox ciklus
return

*/
#NoEnv
#SingleInstance force
#UseHook
#InputLevel 0
#IfWinActive ahk_exe SkyrimSE.exe
global mehet = true
;sidenote: futasidoben boolean erteket szamkent(0,1) tarol

[:: ; start chopping
	;msgbox %mehet%
	MouseMove, 0, 10, 50, R
	send e
	while mehet == true {
		MouseMove, 0, 10, 50, R
		send e
		Sleep 34000
	}
	
Return

]:: ; stop chopping
	;msgbox %mehet%
	mehet = 0
Return 

\:: ; restart 
	;msgbox %mehet%
	mehet = 1
return
#IfWinActive