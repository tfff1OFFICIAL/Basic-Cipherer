valueLetters = ["", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']

def getNumber(letter):
    return valueLetters.index(letter)

def count(value, toCount):
    out = value
    count = toCount
    while count > 0:
        if out != 1:
            out -= 1
        else:
            out = len(valueLetters) - 1
        count -= 1
    #print(out)
    return out

def getLetter(number):
    return valueLetters[number]

delayedOut = []

n = " "
prevLine = " "
while n != "":
    prevLine = n
    n = str(input())
    if n != "":
        if prevLine.isdigit() == True and len(n) > 0:
            delayedLine = ""
            for letter in n:
                if valueLetters.index(letter) != -1:
                    #If the letter is an allowed character then:
                    delayedLine += getLetter(count(getNumber(letter), int(prevLine)))
                #Do some fancy prevLine stuff:
                if int(prevLine) + 1 > len(valueLetters) - 1:
                    prevLine = str(1)
                else:
                    prevLine = str(int(prevLine) + 1)
                #print("PrevLine is: %s"%prevLine)
            delayedOut.append(delayedLine)

for line in delayedOut:
    print(line)
