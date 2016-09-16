# _Word Count_

#### _a website in Nancy that uses a method to return how frequently a word appears in a given string. The user should input both the word and the string of words to check. Check for full word matches only. _

#### By _**Vichitra Pool September 16th, 2016**_

## Description/Specs

| Behavior     | Input1 Example | Input2 Example |Output Example  |
| ------------- |:-------------:| :-----:| :-----:|
|When the user has 2 inputs that are exactly different words, the result is displayed | and | pet | 0 "No Matching Word to "and""
|I chose "and", "pet" as the inputs because the words are completely different, thus it should be easiest to detect that there are not any matching words.
|When the user has 2 inputs that have similar letters in both words, the result is displayed | and | ant | 0 "No Matching Words to "and""
|I chose "and", "ant" as the inputs to test that both words are partially the same but with 1 different letter. The words is not complicated and should not be complicated to dectect that the words are not matching.  
|When the user has 2 inputs are exactly the same word, the result is displayed | and | and | 1 match found to "and"
|I chose this matching word because there are only 3 letters, it should be easy to match the letters



## Support and contact details

Please contact the authors if you have any questions or comments.

## Technologies Used

C#, Nancy, Razor, Xunit and cshtml.

### License

Copyright (c) 2016 **_Vichitra Pool_**

This software is licensed under the MIT license.
