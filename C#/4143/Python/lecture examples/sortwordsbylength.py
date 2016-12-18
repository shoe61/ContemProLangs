#sort a list of words by length in descending order
def sort_by_length (words):
    #build a list of tuples
    t = list()
    for word in words:
        t.append((len(word), word))
        
    #sort the list of tuples
        #if two words the same length, 2nd element in tuple-words are compared 
    t.sort(reverse=True)
    
    #extract the words from the sorted list of tuples
    res = list()
    for length, word in t:
        res.append(word)
    return res
    
#initialize, sort, and print
words = ('a', 'brown', 'cow', 'jumped', 'over', 'the', 'moon', 'architecture')
res = sort_by_length(words)
for r in res:
    print (r)

