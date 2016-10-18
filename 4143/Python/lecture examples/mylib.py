def linecount(fname):
     count = 0
     fin = open(fname)
     for line in fin:
          count = count + 1
     return count
