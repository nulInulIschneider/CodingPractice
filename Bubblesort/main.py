# Bubblesort

import random
import copy

def bubbleSort(l):

    list_numbers = l.copy()
    check = len(list_numbers)
    changes = True

    while changes:
        changes = False
        for i in range(check - 1):
            if list_numbers[i] > list_numbers[i + 1]:
                list_numbers[i], list_numbers[i + 1] = list_numbers[i + 1], list_numbers[i]
                changes = True

    return list_numbers

print(' '.join(str(e) for e in bubbleSort([int(x) for x in input('Beliebige Zahlen: ').split()])))

