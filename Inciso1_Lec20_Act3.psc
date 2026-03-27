Algoritmo Calculo_Semana
    Definir dia Como Entero
    Escribir "Ingrese el número del día (1 al 7):"
    Leer dia
    
    Si dia <= 5 Entonces
        Escribir "Entre semana"
    SiNo
        Si dia == 6 O dia == 7 Entonces
            Escribir "Fin de semana"
        SiNo
            Escribir "numero no válido"
        FinSi
    FinSi
FinAlgoritmo