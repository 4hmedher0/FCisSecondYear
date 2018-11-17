
; You may customize this and other start-up templates; 
; The location of this template is c:\emu8086\inc\0_com_template.txt

org 100h
; print code using int 10h
mov al,49 
mov ah,0eh;         
;*************** text Indentation using int 10h ******
mov dl,3;colums
mov dh,5; rows
mov al,'A'
mov ah,2
int 10h;
;you have done text Indentation next do print int
mov ah,0eh
int 10h  
; print code using int 21h 
mov dl,'D'; data of int 21h put in dl   
mov ah,2
int 21h           
; print array 
lea dx,arr      ; 
mov ah,9      ; specifiy sub int
int 21h          
;************** recive from user , the data stored in al 

mov ah,1
 int 21h 
ret          

arr db "sunrise $"




