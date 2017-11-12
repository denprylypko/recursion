def sum(x):
    if x == 0:
        return 0
    else:
        return x + sum(x-1)

def factorial(x):
    if x == 0:
        return 1
    else:
        return x*factorial(x-1)

def fibonachi(x):
    if x == 0:
        return 0
    elif x == 1:
        return 1
    else:
        return fibonachi(x-1) + fibonachi (x-2)

number = int(input('Input number: '))
print('sum(x) = ', sum(number))  
print('factorial(x) = ', factorial(number))
print('fibonachi(x) = ', fibonachi(number))