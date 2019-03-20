#Nicholas Marshall ITEC 2270 Final Project for giving, recieving, and carrying out orders given by senior officer
#The classes and characters are based on an anime called Naruto Shippuden.

#super class or general class that has its attributes inherited by Kage and Jonin classes
class Shinobi():
    def __init__(self,name):
        self.name=name

class Kage(Shinobi):
    def __init__(self,name,exp,skill):
        super().__init__(name)
        self.exp=exp
        self.skill=skill
    #function for sending order to recieving jonin
    #by calling a function that is hosted by the jonin object
    def giveOrder(self,subordinate):
        order='visit the other 4 Great Nations for the 5 Kage Summit'
        subordinate.recieveOrder(order)

class Jonin(Shinobi):
    def __init__(self,name,trait,attribute):
        super().__init__(name)
        self.trait=trait
        self.attribute=attribute
    #function designed to recieve and carry out the order that was give by the function in the Kage class
    #this is done by recieving a function call
    def recieveOrder(self,order):
        print('This is ',self.name,'I recieved an order to,', order, 'it will be completed')
        print('I shall get started right away.')

#apply classes by creating character to give and recieve orders
shin=Shinobi=('Jiraiya')
kage=Kage('Naruto Uzimaki','31','Six Paths Sage Mode')
jonin = Jonin('Sasuke','Sharingan','Genjustu')

#give order from kage object to jonin object
kage.giveOrder(jonin)

#created object for us to use in the database for the table and later print out
jonin = [Jonin('Sasuke','Sharingan','Genjustu')]

#this lets us import the sqlite3 library for python to use
import sqlite3

#this command opens our connection to the database, creates a file, and names it for us
databaseConnection = sqlite3.connect('Naruto')

#this creates the table where we input the information
#we then want to add exception handling in case we have already entered the same data or already have a table names what we desire
try: 
  databaseConnection.execute("create table jonin(name,trait)")
except sqlite3.OperationalError as sqoe:
  print('Your create table command caused an sqlite error: probably that your table already exists. We\'ll ignore it and move on to use the database')
  print('The detailed error info is: ',str(sqoe))

#this will allow us to insert data into ourdatabase 
myCursor=databaseConnection.cursor()
myCursor.execute("insert into Jonin(name,trait) values (?,?)", (jonin[0].name,jonin[0].trait))        
databaseConnection.commit()

#now we want to retrieve out data
myListOfDatabaseRecords = myCursor.execute("select name,trait from jonin")
#create for loop that loops each element in the table and prints it out in order
for Jonin in myListOfDatabaseRecords:
  print(Jonin)

#next we will close the connection since we have no other commands that need to run
databaseConnection.close()
