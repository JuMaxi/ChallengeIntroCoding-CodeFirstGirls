## Flowchart (second part) - Hide the first 12 digits

```mermaid
%%{ init: { 'flowchart': { 'curve': 'linear' } } }%%
flowchart TD
    id1([Start])
    id2[/"CreditCard[]"/]
    id3[int Position]
    id4{"Position < 
    CreditCard.Length - 4"}
    id5{"CreditCard[Position] != &apos; &apos;"}
    id6["CreditCard[Position] = X"]
    id7[Position = Position + 1]
    id8[/"Return CreditCard[]"/]
    id9([End])

    id1 --> id2 --> id3 --> id4
    id4 -- Yes --> id5
    id4 -- No --> id8 -->id9
    id5 -- Yes --> id6 --> id7
    id5 -- No --> id7
    id7 --> id4
    
    style id1 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
    style id9 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
    style id8 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id2 fill:#88B5F7,stroke:black,stroke-width:2px,color:black;
    style id3 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id6 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id7 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id4 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id5 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
```

## Pseudo code
```basic
READ CreditCard
Position = 0
WHILE Position < CreditCard.Length - 4
	IF CreditCard[Position] != " "
		CreditCard[Position] = "X"
	ENDIF
	Position = Position + 1
ENDWHILE
RETURN CreditCard
```

## Source Code - C#
**[Click here](./Problem5.cs)** to see the implementation.