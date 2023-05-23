def autokennzeichen(users_choice, data):
    print(f'Das Kennzeichen {users_choice} steht für:', ', '.join(data[users_choice]))


def read_data():
    liste = []
    for line in open('kfz-kennz-d-788.csv'):
        x = line.strip().split(',')
        liste.append(x)
    listeDict = {}
    for item in liste:
        if item[0] in listeDict:
            listeDict[item[0]].extend(item[1:])
        else:
            listeDict[item[0]] = item[1:]
    return listeDict


users_choice = input('Willkommen beim Kennzeichen-Erkenner!\nBitte geben Sie das Auto-Kennzeichen ein:\n').upper()
data = read_data()
autokennzeichen(users_choice, data)
