## Problem 2
This program will sort an array of integers in ascending order.

## Flowchart
```mermaid
%%{ init: { 'flowchart': { 'curve': 'linear' } } }%%
flowchart TD    
    id1([Start])
    id2["int NumArray&lbrack;&rbrack;
     int FirstIndex"]

    id3{"FirstIndex <
    NumArray.Length"}

    id4[int SecIndex]

    id5{"SecIndex < 
    &lpar;NumArray.Length - 1&rpar;
    - FirstIndex"}

    id6{"NumArray&lbrack;SecIndex&rbrack; > 
    NumArray&lbrack;SecIndex + 1&rbrack;"}

    id7["Number = NumArray&lbrack;SecIndex&rbrack; 
    NumArray&lbrack;SecIndex&rbrack; = NumArray&lbrack;SecIndex + 1&rbrack;
    NumArray&lbrack;SecIndex + 1&rbrack; = Number"]
    
    id10[SecIndex = SecIndex + 1]
    id11[FirstIndex = FirstIndex + 1]
    id12[/"Return NumArray&lbrack;&rbrack;"/]
    id13([End])

    id1 --> id2 --> id3
    id3 -- Yes --> id4 --> id5
    id3 -- No --> id12 --> id13
    id5 -- Yes --> id6
    id5 -- No --> id11 --> id3
    id6 -- Yes --> id7 --> id10 --> id5
    id6 -- No --> id10

    style id12 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id1 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
    style id13 fill:#5AE08D,stroke:black,stroke-width:2px,color:black;
    style id2 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id4 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id10 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id3 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id6 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id5 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id7 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id10 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id11 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;

```
## Pseudo code 
```basic
READ NumArray[]
FirstIndex = 0
WHILE FirstIndex < NumArray.Length
	SecIndex = 0
	WHILE SecIndex < (NumArray.Length - 1) - FirstIndex
		IF NumArray[SecIndex] > NumArray[SecIndex + 1]	
			Number = NumArray[SecIndex]
			NumArray[SecIndex] = NumArray[SecIndex + 1]
			NumArray[SecIndex + 1] = Number
		ENDIF
		SecIndex = SecIndex + 1
	ENDWHILE
   	FirstIndex = FirstIndex + 1
ENDWHILE
RETURN NumArray
```
## Source Code - C#
**[Click here](./Problem2.cs)** to see the implementation.



    
    