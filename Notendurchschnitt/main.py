with open('noten.txt') as f:
    with open('aufgabe.txt', 'w') as aufgabe:
        for x in f:
            if x == '1\n':
                aufgabe.write('sehr gut\n')
            elif x == '2\n':
                aufgabe.write('gut\n')
            elif x == '3\n':
                aufgabe.write('befriedigend\n')
            elif x == '4\n':
                aufgabe.write('ausreichend\n')
            elif x == '5\n':
                aufgabe.write('mangelhaft\n')
            elif x == '6\n':
                aufgabe.write('ungenügend\n')
            else:
                aufgabe.write('Fehler\n')
durchschnitt = open('noten.txt', 'r')
data = durchschnitt.read()
data = [line for line in data if line != '\n']
a = (data.count('1') * 1)
b = (data.count('2') * 2)
c = (data.count('3') * 3)
d = (data.count('4') * 4)
e = (data.count('5') * 5)
f = (data.count('6') * 6)
g = (a + b + c + d + e + f)
h = len(data)
i = g/h
f = open('aufgabe.txt', 'r')
inhalt = [f.read()]
inhalt.insert(0, 'Durchschnitt:')
inhalt.insert(1, i)
print(inhalt)
noten = {note: data.count(str(note)) for note in range(1, 7)}
mean = sum([note * anzahl for note, anzahl in noten.items()]) / sum(noten.values())
print(mean)
durchschnitt.close()
