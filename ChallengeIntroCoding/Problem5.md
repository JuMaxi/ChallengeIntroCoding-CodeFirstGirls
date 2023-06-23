## Problem 5
This program will generate a Credit Card random number and will hide the first 12 digits for "X"
showing just the 4 last numbers.

## Flowchart (first part) - Generate a random credit card number
```mermaid
%%{ init: { 'flowchart': { 'curve': 'linear' } } }%%
flowchart TD
    id1([Start])
    id2["CreditCard&lbrack;&rbrack;
    int Position"]
    id3{"Position <
    CreditCard.Length"}
    id4["Random = new Random
	Number = Random(0,10)"]
    id5{"#lpar;#lpar;Position + 1#rpar; % 5#rpar; = 0"}
    id6["CreditCard[Position] = &apos; &apos;"]
    id7["CreditCard[Position] = Number"]
    id8[Position = Position + 1]
    id9[/Return CreditCard/]
    id10([End])
    
    id1 --> id2 --> id3
    id3 -- Yes --> id4 --> id5
    id3 -- No --> id9 --> id10
    id5 -- Yes --> id6 --> id8
    id5 -- No --> id7 --> id8
    id8 --> id3

    style id1 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
    style id10 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
    style id2 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id4 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id6 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id7 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id8 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id9 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id3 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id5 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
 ```
## Pseudo code
```basic
READ CreditCard 
READ int Position = 0
WHILE Position < CreditCard.Length
	Random = new Random
	int Number = Random(0,10)
	IF ((Position + 1) % 5) = 0
		CreditCard[Position] = " "
	ELSE
		CreditCard[Position] = Number
	ENDIF
	Position = Position + 1
ENDWHILE
RETURN CreditCard



