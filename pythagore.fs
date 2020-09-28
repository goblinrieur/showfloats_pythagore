#! /usr/local/bin/gforth

: >segments  		( -- x y -- sqrt[ x²+y² ] )             
	cr ." valeur du premier segment : " 
	pad dup 20 accept >float fdup f*	
	cr ." valeur du second segment : " 
	pad dup 20 accept >float fdup f* 
	f+ 		\ x²+y²
	fsqrt		\ sqrt 
;

: hypotenuse.		( sqrt[ x²+y² -- ) 
	10 set-precision	\ juste pour afficher proprement 10 chiffres dans le nombre
	CR ." 	hypotenuse : " f. 
	CR CR 
;

	\ -- MAIN --

: main
	>segments		\ saisie des cotés de l'angle droit 
	hypotenuse.		\ affiche en précision 10 la longueur de l'hypoténuse
;

main bye 
