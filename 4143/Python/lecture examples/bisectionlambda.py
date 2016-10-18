from math import sin

#define some math functions using lambda
f = lambda x: 3*x*x - x - 2
    
g = lambda x: sin(x) + 1
 
#find a root to the function passed in the interval [a,b] within tolerance   
def bisection(func,a,b,tol):
    #make sure there is ONE root in the interval
    if (func(a)*func(b) > 1):
        print ('There is NOT ONE root in the interval')
        exit()
        
    #find a root
    c = (a+b)/2.0
    while (b-a)/2.0 > tol:
        if func(c) == 0:
            return c
        elif func(a)*func(c) < 0:
            b = c
        else :
            a = c
        c = (a+b)/2.0
    return c
     

