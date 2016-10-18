vowels = ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U')
words = 'I see eight ugly strange spiders'.split()

lengths = list(map (lambda word: len (word), words))

pigvowel  = lambda word: word + ('way')
    
pignovowel = lambda word: \
    word + ('ay') if word [0] in vowels\
    else pignovowel (word[1:] + word[0])

pigword = lambda word: \
    pigvowel(word) if word[0] in vowels \
    else pignovowel(word)
        
piglatinseq = list(map (lambda word: pigword(word), words))

piglatin = ' '.join(piglatinseq)

print (lengths)
print (piglatin)
