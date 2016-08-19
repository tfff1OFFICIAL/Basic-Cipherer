import os, json, urllib.request
# Properties:
propsLoc = os.path.dirname(os.path.realpath(__file__)) + "\cipherProperties.json"
if os.path.exists(propsLoc) != True:
    print("No properties found, generating a default one.")
    file = open(propsLoc, "w")

    file.write("{")
    file.write('"letters": ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"],')
    file.write('"dummies": [" "],') #Dummies are characters that are ignored in reading, and in writing are randomly placed throughout the document.
    file.write('"isMultiLine": true')
    file.write("}")
    file.close()
    print("Done!")
valueLetters = [""]

#Read Properties:
with open(propsLoc) as file:
        properties = json.load(file)
        print("Successfully loaded properties with %s letters and %s dummies. Multiline Input is %s"%(len(properties["letters"]), len(properties["dummies"]), properties["isMultiLine"]))

for letter in properties["letters"]:
    valueLetters.append(letter)
isMultiLine = properties["isMultiLine"]
print("To execute commands, enter /COMMAND <command> instead of the movementNumber")

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
    if prevLine == " ":
        prevLine = n
    elif isMultiLine == False:
        prevLine = n
    n = str(input())
    if n != "":
        if prevLine.isdigit() == True and len(n) > 0:
            delayedLine = ""
            for letter in n:
                if valueLetters.index(letter) != -1:
                    #If the letter is an allowed character then:
                    delayedLine += getLetter(count(getNumber(letter), int(prevLine)))
                elif letter.isdigit() == True:
                    delayedLine += letter
                #Do some fancy prevLine stuff:
                if int(prevLine) + 1 > len(valueLetters) - 1:
                    prevLine = str(1)
                else:
                    prevLine = str(int(prevLine) + 1)
                #print("PrevLine is: %s"%prevLine)
            delayedOut.append(delayedLine)
        elif len(n) > 0:
            try:
                n.index("/COMMAND")
                print("HEY! It's a command!")
            except:
                if n.isdigit == False:
                    print("Unrecognised Input!")

for line in delayedOut:
    print(line)
