## Problem 3
This program will search a number in a sorted matrix and report the exact location of this number. 
If the number is not in the matrix will return the number was not found.

My first attempt in solve this challenge I passed one by one of the number until find the positions.
However the challenge description said there were more clever ways to solve, then I searched on the internet
and found a binary search algorithm. So, I applied this new way to my resolution.

## Flowchart
```mermaid
%%{ init: { 'flowchart': { 'curve': 'linear' } } }%%
flowchart TD
id1([Start])
id2["Matrix&lbrack;&rbrack;
int Row = 0
int Column = Matrix.RowLength - 1
bool Found = false"]
id3[/Input Number/]
id4{"Row < Matrix.RowLength
&& Column >= 0"}
id5{"Number == Matrix&lbrack;Row, Column&rbrack;"}
id6["Found = true
break"]
id7{"Number < Matrix&lbrack;Row, Column&rbrack;"}
id8[Column = Column - 1]
id9[Row = Row + 1]
id10{Found = true}
id11[/"Print &lbrack;Row, Column&rbrack;"/]
id12[/"Print Number 
was not found 
in this matrix."/]
id13([End])

id1 --> id2 --> id3 --> id4
id4 -- Yes --> id5
id4 -- No --> id10
id5 -- Yes --> id6
id5 -- No --> id7
id7 -- Yes --> id8
id7 -- No --> id9
id8 --> id4
id9 --> id4
id10 -- Yes --> id11
id10 -- No -->id12
id6 --> id10
id11 --> id13
id12 --> id13

style id1 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
style id13 fill:#5AE08D,stroke:black,stroke-width:2px,color:black;
style id3 fill:#88B5F7,stroke:black,stroke-width:2px,color:black;
style id2 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id6 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id8 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id9 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id4 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id5 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id7 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id10 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id11 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
style id12 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
```
## Pseudo code
```basic
READ Matrix
READ Number
Row = 0
Column = Matrix.ColumnLength - 1
Found = false
WHILE Row < Matrix.RowLength
and Column >= 0
	IF Number = Matrix[Row, Column]	
		Found = true
		break
	ELSE
		IF Number < Matrix[Row, Column]
			Column = Column - 1
		ELSE
			Row = Row + 1
		ENDIF
	ENDIF
ENDWHILE
IF Found = true
	WRITE "Row, Column"
ELSE
	WRITE "The typed number was not found in this matrix."
ENDIF
```

