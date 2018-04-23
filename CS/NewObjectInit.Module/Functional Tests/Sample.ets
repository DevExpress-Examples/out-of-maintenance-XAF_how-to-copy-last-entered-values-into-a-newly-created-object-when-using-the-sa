;#DropDB NewObjectInitEasyTest

#Application NewObjectInitWin
#Application NewObjectInitWeb

*Action Navigation(User)

*ProcessRecord
 Full Name = ''

#IfDef NewObjectInitWeb
*Action Edit
#EndIf
 
*FillForm
 Full Name = Test User
 
*Action Cancel

#IfDef NewObjectInitWin
*HandleDialog
 Respond = Yes
#EndIf

*CheckFieldValues
 Full Name = ''
