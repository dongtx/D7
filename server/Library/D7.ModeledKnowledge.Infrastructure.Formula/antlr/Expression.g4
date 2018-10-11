grammar Expression;

program 
    : ID op=ASSIGN statement #Assign
	| statement #ParenthesisProgram
	;

statement	
    : orexpr
	;
			
orexpr 
    : andexpr #ParenthesisORExpr
	| orexpr op=OR andexpr  #Or
	;

andexpr 
    : bexpr #ParenthesisANDExpr
	| andexpr op=AND bexpr #And
    ;

bexpr 
    : expression #ParenthesisBExpr
	| bexpr op=(EQUALS|NOT_EQUALS|GTE|GT|LTE|LESS) expression #Equal
	;

expression  
    : term #ParenthesisExpr
	| expression op=( PLUS | MINUS ) term #Add
    ;
            
term
    : unary #ParenthesisTerm
	| term op=( MULT | DIVIDE ) unary #Mult
    ;

unary
    : op=( PLUS | MINUS )? factor #Plus
    ;

factor      
    : value
    ;
            
value
    : literal
    ;

arguments   
    : orexpr? #Parameter
	| arguments COMMA orexpr #ParameterList
    ;

literal     
    : ID #Variable
	| ID LPAREN arguments RPAREN #Method
	| INT #Int
    | FLOAT #Float
    | STRING #String
    | LPAREN orexpr RPAREN #OrExpr
    ;

WS			: [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines

LPAREN		: '(' ;
RPAREN		: ')' ;

MULT		: '*' ;
DIVIDE		: '/' ;
DASH		: '^' ;
PLUS		: '+' ;
MINUS		: '-' ;

EQUALS		:'==';
NOT_EQUALS	:'!=';
AND			:'&&';
OR			:'||';
GT			:'>';
LESS		:'<';
GTE			:'>=';
LTE			:'<=';

SEMI		: ';' ;
COMMA		: ',' ;
ASSIGN		: '=' ;

INT	
	:	('0'..'9')+                  
			 (  '.' ('0'..'9')*                      	
	         (('e' | 'E') ('+' | '-')? ('0'..'9')+)? 
	     |   ('e' | 'E') ('+' | '-')? ('0'..'9')+   	
             )?
	;

FLOAT
	:	'.' ('0'..'9')+ (('e' | 'E') ('+' | '-')? ('0'..'9')+)?
    ;

ID
	:	('@'|'$'|'a'..'z'|'A'..'Z'|'_'|'\u4E00'..'\u9FA5') ('a'..'z'|'A'..'Z'|'.'|'_'|'0'..'9'|'\u4E00'..'\u9FA5')*
	;

STRING
    : '"' ( '\\' . | ~('\\'|'"') )* '"'	
    | '\'' ( '\\' . | ~('\\'|'\'') )* '\''  
    ;