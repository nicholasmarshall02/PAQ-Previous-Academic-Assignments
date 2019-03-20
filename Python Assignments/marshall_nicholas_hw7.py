#Nicholas Marshall ITEC 2270
#before we get started a side note saying these characters and quirks are from My Hero Academia. 

#first thing we want to create is our superclass
#we will create a constructor that gives the characters 4 variables
#name hp triat and a quirk

#we will also create a action function
class Character():
  def __init__(self,newname,hp,trait,quirk):
      self.newname=newname
      self.hp=hp
      self.trait=trait
      self.quirk=quirk
  def action(self):
      self.counter=0
      print(self.newname, 'action counter is', self.counter)

  def Stats(self):
      return self.newname + ", " + self.hp + ", " + self.trait + ", " + self.quirk

  
#create sub class where the character class is inherited
    #create action function that will override the one inherited for actions on attacking
    #create stats function to hold characteristics of character here for later use.
class Warrior(Character):
    def __init__(self,newname,hp,trait,quirk,special):
        super().__init__(newname,hp,trait,quirk)
        self.special=special
        self.counter = 0
    def action(self): 
        self.counter += 1
        print(self.newname, 'action counter is' ,self.counter,)
         
    def stats(self):
      return self.Stats() + ", " + self.special
    
        
#use classes previously created by creating characters
#then having characters battle with exchanging attacks
  #this creates simple character stats and exchanging blows thorugh print functions
hero1 = Warrior('Midoryia', '6500', 'Good', 'One for All','Deleware Smash')
villian1 = Warrior('Stain', '6200','Evil', 'Bloodcurdle', 'Paralysis') 
#put created characters to use by having them duel 
print(hero1.newname, 'is', hero1.trait)
print(hero1.newname, 'takes action:')
print(hero1.newname, 'quick combo\'s!')
print(hero1.newname, 'activates quirk', hero1.quirk, 'to dash and use,', hero1.special, 'on', villian1.newname)
hero1.action()
print()

#this is where the villian attacks
print(villian1.newname, 'is', villian1.trait)
print(villian1.newname, 'takes action:')
print(villian1.newname, 'slashes sword!')
print(villian1.newname, 'activates quirk', villian1.quirk, 'after slashing,', hero1.newname, ',this activates', villian1.special)  
villian1.action()
print()

#counterattacks after initial attacks
print(hero1.newname, 'takes action again:')
print(hero1.newname, 'quick combo\'s!')
print(hero1.newname, 'activates quirk', hero1.quirk, 'to leap forward and use,', hero1.special, 'on', villian1.newname)
hero1.action()
print()


print(villian1.newname, 'takes action:')
print(villian1.newname, 'slashes sword!')
print(villian1.newname, 'misses slash for', villian1.quirk, 'takes defense tactic on', hero1.newname, 'then throws smoke to retreat...')  
villian1.action()
print()
