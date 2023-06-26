## Problem 1
This program will request a student's grade from the user. 
Depending of the grade, will delivery a message "Failed", either "Passed with Distinction" or "Passed".

## Flowchart
```mermaid
flowchart TD
    id1([Start])
    id2[/Input int Grade/]
    id3{Grade < 40}
    id4[/Print Failed./]
    id5["int NextMultipleFive = #lpar;Grade + 5#rpar; - #lpar;Grade % 5#rpar;"]
    id6{"#lpar;NextMultipleFive - Grade#rpar; < 3"}
    id7[Grade = NextMultipleFive]
    id8{Grade > 80}
    id9[/Print Passed with Distinction!/]
    id10[/Print Passed!/]
    id11([End])

    id1 --> id2 --> id3
    id3 -- Yes --> id4
    id3 -- No --> id5
    id5 --> id6 -- Yes --> id7 --> id8
    id6 -- No --> id8
    id8 -- Yes --> id9
    id8 -- No --> id10
    id4 --> id11
    id9 --> id11
    id10 --> id11
    
    style id1 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
    style id11 fill:#5AE08D,stroke:black,stroke-width:2px,color:black;
    style id2 fill:#88B5F7,stroke:black,stroke-width:2px,color:black;
    style id4 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id9 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id10 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
    style id3 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id6 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id8 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
    style id5 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
    style id7 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;

```
## Pseudo code
```basic
READ Grade
IF Grade < 40
	WRITE "Failed + Grade"
ELSE
	NextMultipleFive = (Grade + 5) - (Grade % 5)
	IF (NextMultipleFive - Grade) < 3
		Grade = NextMultipleFive
	ENDIF
	IF Grade > 80
		WRITE "Passed with Distinction + Grade"
	ELSE
		WRITE "Passed + Grade."
	ENDIF
ENDIF

```
## Source Code - C#
**[Click here](./Problem1.cs)** to see the implementation.