Algoritmo Mensaje_de_voz
	Escribir "===MENSAJE DE VOZ==="
	Escribir "Menuprincipal"
	Escribir "1-Recepcion"
	Escribir "2-Vigilancia"
	Escribir "3-Mantentenimiento"
	Escribir "4-salir"
	Escribir Sin Saltar " Digite una opcion:"
	definir numero Como Entero
	Leer numero
	si numero == 1 Entonces
		escribir "Bienvenido al departamento de recepcion"	
		Escribir "Presione una tecla para salir"
		Esperar Tecla 
		Limpiar Pantalla 
		Esperar 3 Segundos
	FinSi
	si numero == 2 Entonces
		escribir "Bienvenido al departamento de Vigilancia"	
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si numero == 3 Entonces
		escribir "Bienvenido al departamento de Mantenimiento"	
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si numero <> 1 o numero <> 2 y numero <> 3
		Escribir "Saliendo del sistema"
		Escribir "Presione tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
FinAlgoritmo
