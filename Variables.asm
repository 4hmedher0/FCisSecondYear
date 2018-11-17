
; You may customize this and other start-up templates; 
; The location of this template is c:\emu8086\inc\0_com_template.txt

org 100h

; add your code here
m db 5+3
m2 db 15h
mov al,m 
mov bl,m2
cons equ 90h
mov cl,cons 
db 20h
w db ?  ; empty      
lea bx,m
arr db "welcome 0 $",0h  
arr2 db 2h,3h,1h,0h
arr3 db 4 dup (2,4)  
mov al,arr2[2]

ret




