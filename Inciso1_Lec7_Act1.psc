Algoritmo Calcular_promedio
	Escribir "Promedio de notas"
	Definir n1,n2,n3,n4,n5 Como Entero
	Escribir "Escribir el nombre de la materia: "
	Leer materia
	Escribir "Dime la primera nota: "
	Leer n1
	Escribir "Dime la segunda nota: "
	Leer n2
	Escribir "Dime la tercera nota: "
	Leer n3
	Escribir "Dime la cuarta nota: "
	Leer n4
	Escribir "Dime la quinta nota: "
	Leer n5
	p = (n1+n2+n3+n4+n5)/5
	escribir "El promedio de la materia: "+ materia +" es de," p
	
	si p >= 70 Entonces
		Escribir "aprobaste"
	SiNo
		Escribir "perdiste"
	FinSi
FinAlgoritmo
