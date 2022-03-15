#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

InputStream := []

#!e:: ; Win + Alt + e
;start recorded input 
;input type 1: one click 	2: drag mouse		3: Ctrl + c 	4:Ctrl + v
	global InputStream
	for index in InputStream 
	{
			selectAction(index)
			Sleep 100
			MsgBox % index . ", " . InputStream[index][1] . ", " . InputStream[index][2] . ", " . InputStream[index][3]
	}
return
 
#!c:: ; Win + Alt + c
;insert mouse position
	global InputStream
	MouseGetPos, x,y
	input := [x,y,1]
	InputStream.Push(input)
return

#!v:: ; Win + Alt + v
;drag mouse and move to position
	global InputStream
	MouseGetPos, x,y
	input := [x,y,2]
	InputStream.Push(input)
return
	
^#c:: ;Ctrl + Win + c
;insert Ctrl + c 
	global InputStream
	input := [0,0,3]
	InputStream.Push(input)
return

^#v:: ;Ctrl + Win + v
;insert Ctrl + v
	global InputStream
	input := [0,0,4]
	InputStream.Push(input)
return

#!x:: ; Ctrl + Win + x
;clear stream
	global InputStream
	InputStream.RemoveAt(InputStream.MaxIndex())
return


selectAction(i){
	global InputStream
	if(InputStream[i][3] = 1)
	{
		
		x = % InputStream[i][1]
		y = % InputStream[i][2]
		Click %x% , %y% , 1
	}
	else if(InputStream[i][3] = 2)
	{
		Click Down
		x = % InputStream[i][1]
		y = % InputStream[i][2]
		Click %x%,%y% , Up
	}
	else if(InputStream[i][3] = 3)
	{
		Send ^c
	}
	else if(InputStream[i][3] = 4)
	{
		Send ^v
	}
}