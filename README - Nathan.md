Hi Nelnet,

A few notes on the coding exercise...

- I understand what the code all the code is doing and I understand how the objects interact with each other

- I was able to finish requirements 1 and 2 by adding a findWeightClass function and a PetWeight enumerated type similar to those previously defined

- I was NOT able to finish requirements 3-5.

- The word "overridable" really gave me problems. I got stuck deciding whether I needed to use the "override" keyword somewhere in my code, or if the word was simply being used for its English definition. 

- If I was supposed to use the keyword in my code... I am familiar with method overriding, but I was confused how to apply that to enumerated types. I know that a method in a parent class can have a different usage in each of its child classes, but I do not know how to make enumerated types override each other. My best guess is that the PersonModel class should somehow be a parent to the PetType, PetClassification, and PetWeight types, since the PersonModel class is where the preferences are defined.

- If "overridable" was purely meant for its English meaning... I would have just edited the isGood method with an if/else that compared type first, classification second, and weight third, but I saw problems with that. First, how would I default to the type, classification, or weight on the person object? That wouldn't make sense. Next, what does it mean to have an unlimited number of overrides? Would I have to loop through every possible option somehow? And finally, how would I handle pet oppositions when the only information I have is about pet preferences?

- I think I'm either missing something or I simply didn't have the skill to understand the entire exercise, but I did the best that I could with the knowledge that I have and I'd be happy to discuss it further.
