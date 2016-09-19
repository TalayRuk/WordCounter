# _Word Counter_

#### _a website in Nancy that uses a method to return how frequently a word appears in a given string. The user should input both the word and the string of words to check. Check for full word matches only. _

#### By _**Vichitra Pool September 16th, 2016**_

## Description/Specs

| Behavior     | Input1 Example | Input2 Example |Output Example  |
| ------------- |:-------------:| :-----:| :-----:|
|Compare single letter inputs | a | b | 0 match found for "a"
|:The single letter is the most simplest form to detect|
|Compare single letter inputs | a | a | 1 match found for "a"
|:Change input with Uppercase to Lowercase | A | a | 1 match found for "A"
|:Simplest form to change a single letter
|Compare single digit inputs | 0 | 0 | 1 match found for "0"
|:Using 1 digit number is simplest form to find out if the method can also match number
|Compare single digit inputs | 0 | 1 | 0 match found for "0"
|:To confirm that the method will not match to any numbers
|Compare single digit inputs | 0 | o | 0 match found for "0"
|:To further confirm that this will not match number to letter
|Compare to string of 2 letters with space | a | a b | 1 match found for "a"
|:This is the simplest way to check if letter is detect when there is space in the string.
|Compare 2 letter-words that partially different | an | at | 0 match found for "an"
|:Testing 1 partially different letter
|Compare 2 number-words that partially different | 0n | 0t | 0 match found for "0n"
|:Testing 1 partially different number
|Compare partial number and letter inputs | i2 | 2i | 0 match found for "i2"
|:To confirm that number is treated as string, even though same number but different position still not match
|Compare 2 letter-words | an | an | 1 match found for "an"
|:Testing for 2 letters
|Compare 2 numbers | 12 | 12 | 1 match found for "12"
|:Testing for 2 numbers
|Compare 2 letter-number-words | 0n | 0n | 1 match found for "0n"
|:Testing for 2 mix letter and number
|Compare 2 different 3 letter-words | and | pet | 0 match found for "and"
|:I chose "and", "pet" as the inputs because the words are completely different, thus it should be easiest to detect that there are not any matching words found.
|Compare 2 partially same letter words with same length | pet | pen | 0 match found for "pet"
|Compare partially same words | pet | pets | 0 match found for "pet"
|:This test is to prevent partially matching words. I chose to compare "pet" to "pets" because they both exactly the same, but input has 1 more letter than input2. This show that even though words are the same but with one letter different it'll still show as 0 match found
|Compare 2 exactly same words | pet | pet | 1 match found for "pet"
|:I chose this matching word because there are only 3 letters, it should be easy to match the letters
|Compare 2 words; one with Uppercase| PET | pet | 1 match found for "Pet"
|:I chose pet again because I already have the method from the previous spec. Thus, I only need to add one more method to change all uppercase letters to lowercase letters.
|Compare words with same letters but in partially different position| net | ten | 0 Match found for "net"
|:I chose "net", "ten" because the letters are exactly the same but are in different places with only "e" share the same place.
|Compare words with same letters but in different position | near | earn | 0 Match found for "near"
|:I chose "near", "earn" because the letters are exactly the same but are placed entirely in different position.
|Compare word to sentence | pet | "I have 10 pets and I love each pet the same. I pet them everyday, I pet them am & pm." | 2 match found for "pet"
|:I chose "pet" as input and pet in the sentence, because I have chosen the word ten in previous specs. This should make it easy to implement.





## Support and contact details

Please contact the authors if you have any questions or comments.

## Technologies Used

C#, Nancy, Razor, Xunit and cshtml.

### License

Copyright (c) 2016 **_Vichitra Pool_**

This software is licensed under the MIT license.
