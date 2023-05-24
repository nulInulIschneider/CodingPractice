# Geo-Quiz

import random
import copy

bundesländer_hauptstädte = {
    'Baden-Württemberg': 'Stuttgart',
    'Bayern': 'München',
    'Berlin': 'Berlin',
    'Brandenburg': 'Potsdam',
    'Bremen': 'Bremen',
    'Hamburg': 'Hamburg',
    'Hessen': 'Wiesbaden',
    'Mecklenburg-Vorpommern': 'Schwerin',
    'Niedersachsen': 'Hannover',
    'Nordrhein-Westfalen': 'Düsseldorf',
    'Rheinland-Pfalz': 'Mainz',
    'Saarland': 'Saarbrücken',
    'Sachsen-Anhalt': 'Magdeburg',
    'Sachsen': 'Dresden',
    'Schleswig-Holstein': 'Kiel',
    'Thüringen': 'Erfurt'
}

def quiz():

    quizInput = copy.deepcopy(bundesländer_hauptstädte)
    points = 0
    round = 0
    rounds_max = 3

    print('Willkommen beim Geo-Quiz!')
    users_choice = input('Möchten Sie beginnen? Bitte geben Sie j für ja oder n für nein ein:\n').lower()

    while users_choice == 'j' and round < rounds_max:

        bundesland = random.choice(list(quizInput.keys()))
        antwort_user = input(f'Wie heißt die Hauptstadt von {bundesland}?:\n').lower()
        if antwort_user == quizInput[bundesland].lower():
            points += 1
            print('Die Antwort ist richtig :)')
            print(f'Punkte: {points}/{rounds_max}\n')
        else:
            print('Die Antwort ist leider falsch :(')
            print(f'Die Hauptstadt von {bundesland} ist {quizInput[bundesland]}.')
            print(f'Punkte: {points}/{rounds_max}\n')
        round += 1
        quizInput.pop(bundesland)
        if round < rounds_max:
            users_choice = input('Möchten Sie mit dem Quiz fortfahren? j/n:\n').lower()
        else:
            print('Das Quiz ist beendet.')
            print(f'Sie haben {points} von {rounds_max} Fragen richtig beantwortet.')
        if users_choice != 'n' and users_choice != 'j':
            users_choice = input('Falsche Eingabe! Geben Sie bitte j für weiter oder n für Spielabbruch ein:\n').lower()

    if users_choice == 'n':
        print(f'Sie haben {points} von {round} Fragen richtig beantwortet.')


quiz()