# -*- coding: utf-8 -*-
"""
Created on Wed Nov 04 23:38:09 2015

@author: Michael
Code taken from: http://matplotlib.org/1.2.1/examples/pylab_examples/pie_demo.html
"""
from pylab import *

# make a square figure and axes
figure(1, figsize=(6,6))
ax = axes([0.1, 0.1, 0.8, 0.8])

# The slices will be ordered and plotted counter-clockwise.
labels = 'Frogs', 'Hogs', 'Dogs', 'Logs'
fracs = [15, 30, 45, 10]
explode=(0, 0.05, 0, 0)

pie(fracs, explode=explode, labels=labels,
                autopct='%1.1f%%', shadow=True, startangle=90)
                # The default startangle is 0, which would start
                # the Frogs slice on the x-axis.  With startangle=90,
                # everything is rotated counter-clockwise by 90 degrees,
                # so the plotting starts on the positive y-axis.

title('Raining Hogs and Dogs', bbox={'facecolor':'0.8', 'pad':5})

show()