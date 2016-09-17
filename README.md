# _Word Count_

#### _a website in Nancy that uses a method to return how frequently a word appears in a given string. The user should input both the word and the string of words to check. Check for full word matches only. _

#### By _**Vichitra Pool September 16th, 2016**_

## Description/Specs

| Behavior     | Input1 Example | Input2 Example |Output Example  |
| ------------- |:-------------:| :-----:| :-----:|
|When inputs2 has entirely different letters from input1, the result is displayed | and | pet | 0 match found for "and"
|I chose "and", "pet" as the inputs because the words are completely different, thus it should be easiest to detect that there are not any matching words found.
|When 2 inputs' are exactly the same word, the result is displayed | pet | pet | 1 match found for "pet"
|I chose this matching word because there are only 3 letters, it should be easy to match the letters
|When 2 inputs are exactly the same word but input1 or input2 may have capital letter, the result is displayed | Pet | pet | 1 match found for "Pet"
|I chose pet again because I already have the method from the previous spec. Thus, I only need to add one more method to change all uppercase letters to lowercase letters.
|When input2 has same letters but are placed differently than input1 | near | earn | 0 Match found for "near"
|I chose "near", "earn" because the letters are exactly the same but are placed entirely in different position.
|When input2 has same letters but are placed differently than input1 | net | ten | 0 Match found for "net"
|I chose "net", "ten" because the letters are exactly the same but are in different places with only "e" share the same place.
|When input2 has same letters as input1 but input2's word length maybe longer or shorter | pet | pets | 0 match found for "pet"
|This test is to prevent partially matching words. I chose to compare "pet" to "pets" because they both exactly the same, but input has 1 more letter than input2. This show that even though words are the same but with one letter different it'll still show as 0 match
|When input2 has string of words | pet | "I have 10 pets and I love each pet the same and I pet them everyday." | 2 match found for "pet"
|I chose "pet" as input and pet in the sentence, because I have chosen the word ten in previous specs. This should make it easy to implement.
|When input2 has more than 1 word | pets | "Pets are good companion, the pets I love the most are my dogs and I pet them everyday."  | 2 matches found for "pets"
|I chose to use the same pets input because I already have previous methods to check the same word so with the comma in between should be easy to add the method to find the match, if I need it!

//|when input1 has number mix with word | 7up | 3up | 0 match found for "7up"
//|when input1 has number mix with word | 7up | 7up | 1 match found for "7up"




## Support and contact details

Please contact the authors if you have any questions or comments.

## Technologies Used

C#, Nancy, Razor, Xunit and cshtml.

### License

Copyright (c) 2016 **_Vichitra Pool_**

This software is licensed under the MIT license.
