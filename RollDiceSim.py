import random


def dice1():
    print("-----------")
    print("|         |")
    print("|    0    |")
    print("|         |")
    print("-----------")


def dice2():
    print("-----------")
    print("|       0 |")
    print("|         |")
    print("| 0       |")
    print("-----------")


def dice3():
    print("-----------")
    print("|       0 |")
    print("|    0    |")
    print("| 0       |")
    print("-----------")


def dice4():
    print("-----------")
    print("| 0     0 |")
    print("|         |")
    print("| 0     0 |")
    print("-----------")


def dice5():
    print("-----------")
    print("| 0     0 |")
    print("|    0    |")
    print("| 0     0 |")
    print("-----------")


def dice6():
    print("-----------")
    print("| 0     0 |")
    print("| 0     0 |")
    print("| 0     0 |")
    print("-----------")


print("Roll 2 dice simulator\n")
x = 'y'
while x == 'y':
    n1 = random.randint(1, 6)
    n2 = random.randint(1, 6)
    if n1 == 1:
        dice1()
    if n1 == 2:
        dice2()
    if n1 == 3:
        dice3()
    if n1 == 4:
        dice4()
    if n1 == 5:
        dice5()
    if n1 == 6:
        dice6()
    if n2 == 1:
        dice1()
    if n2 == 2:
        dice2()
    if n2 == 3:
        dice3()
    if n2 == 4:
        dice4()
    if n2 == 5:
        dice5()
    if n2 == 6:
        dice6()

    x = input("Press 'y' to roll again:\n")
