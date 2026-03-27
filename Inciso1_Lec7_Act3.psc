Algoritmo Dias_Meses
	Definir dia, mes Como Entero
	Escribir "Ingrese el número del día (1-31):"
	Leer dia
	Escribir "Ingrese el número del mes (1-12):"
	Leer mes
	
	Si (mes == 1 o mes == 2) o (mes == 3 y dia < 21) o (mes == 12 y dia >= 21) Entonces
		Escribir "Invierno"
	SiNo
		Si (mes == 4 o mes == 5) o (mes == 3 y dia >= 21) o (mes == 6 y dia < 21) Entonces
			Escribir "Primavera"
		SiNo
			Si (mes == 7 o mes == 8) o (mes == 6 y dia >= 21) o (mes == 9 y dia < 21) Entonces
				Escribir "Verano"
			SiNo
				Si (mes == 10 o mes == 11) o (mes == 9 y dia >= 21) o (mes == 12 y dia < 21) Entonces
					Escribir "Otoño"
				SiNo
					Escribir "Fecha no válida"
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo