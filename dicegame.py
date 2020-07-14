chosen =0
chosen2=0
player = input('Enter your player name ')
print('Welcome' + '  '+ player +'  ' + 'to Huzys dicegame')
input()
print("the rules are: the player rolls two dice, a win is on a roll of 7 or 11")
input()
#first dice
from random import randint
chosen = randint(1,6)
print("press enter to roll the first dice ")
input()
print('you have rolled', + chosen)

input()

#second dice
from random import randint
chosen2 = randint(1,6)
print("press enter to roll the second dice ")
input()
print('you have rolled', + chosen2)

#total
input()
print('your combined dice number is',  + chosen+chosen2)

input()

total = chosen+chosen2
if (total==7) or (total==11):
	print('CONGRATULATIONS! You Win')
else:
	print('you lose')