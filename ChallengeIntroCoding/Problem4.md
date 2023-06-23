## Problem 4
This program will calculate the number of a factorial between 0 and 25, and
if the factorial have already calculated in the actual execution of the program it will 
return the factorial already calculated, without calculate it again.

Note, the limit of the numbers was limited until 25, because a greater number would overflow a variable of type long in C#. Using an integer this number would be less yet.

## Flowchart
```mermaid
%%{ init: { 'flowchart': { 'curve': 'linear' } } }%%
flowchart TD
id1([Start])
id2["LookUpTable&lbrack;&rbrack;
int Factorial"]
id3[/Input Number/]
id4{Number != E}
id5{LookUpTable Contains Number}
id7{"Number < 0 ||
 Number > 25"}
id8[/"Return Exception: 
The Number must be 
greater than 0 and
less or equal 25."/]
id9{Number = 0}
id10["Factorial = 1
LookUpTable += Factorial"]
id11[int N = Number - 1]
id12{N >= 1}
id13["Number = Number * N
N = N - 1"]
id14["Factorial = Number
LookUpTable += Factorial"]
id15[/Print Factorial/]
id16([End])

id1 --> id2 --> id3 --> id4
id4 -- Yes --> id5
id5 -- Yes --> id15
id5 -- No --> id7
id7 -- Yes --> id8
id7 -- No --> id9
id9 -- Yes --> id10
id10 --> id15
id15 --> id3
id9 -- No --> id11 --> id12
id12 -- Yes --> id13
id13 --> id12
id12 -- No --> id14 --> id15
id4 -- No --> id16
id8 --> id16

style id1 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
style id3 fill:#88B5F7,stroke:black,stroke-width:2px,color:black;
style id16 fill:#5AE08D,stroke:black,stroke-width:2px,color:black
style id15 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
style id8 fill:#FF8380,stroke:black,stroke-width:2px,color:black;
style id2 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id10 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id11 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id13 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id14 fill:#DCCD8F,stroke:black,stroke-width:2px,color:black;
style id4 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id5 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id7 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id9 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
style id12 fill:#CA70E0,stroke:black,stroke-width:2px,color:black;
```

## Pseudo code
```basic
READ LookUpTable
READ int Factorial
READ NumberInput
WHILE NumberInput!= "E"
	IF LookUpTable Contains NumberInput
		WRITE Factorial
	ELSE
		IF 	NumberInput < 0 or NumberInput > 25
			RETURN Exception "The NumberInput must be greater than 0 and less or equal 25"
		ENDIF
		IF NumberInput = 0
			int Factorial = 1
			LookUpTable += Factorial
		ELSE
			N = NumberInput - 1
			WHILE N >= 1
				NumberInput = NumberInput * N	
				N = N - 1
			ENDWHILE
		int Factorial = NumberInput
		ENDIF
	LookUpTable += Factorial
	WRITE Factorial
	READ NumberInput
ENDWHILE
```




