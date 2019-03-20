
from graphics import *
win = GraphWin("Graphics Window", 400, 400)

Text(Point(60,50),'Input Filename:').draw(win)

inputBox = Entry(Point(250,50), 15).draw(win)

inputStr = inputBox.getText()

win.getMouse()
win.close()


key = 9

myfileobject = open('hw4readme.txt','r')
message = myfileobject.read()
print(message)



f = open("cyphertext.txt", "w+")

for ch in message:
    numericVersion = ord(ch)
    ch = numericVersion - key
    letterVersion = chr(ch)
    print(letterVersion, end=" ")
    print(letterVersion, file=f)

f = open("cyphertext.txt","r")
encryption = f.read()

for letterVersion in encryption:
    newNumber = ord(letterVersion)
    letterVersion = newNumber + key
    decrypted = chr(letterVersion)
    print(decrypted, end=" ")
    
    

