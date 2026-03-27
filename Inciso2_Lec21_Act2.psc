Algoritmo Leccion21_Inciso2
    Definir opcion Como Entero
    
    Escribir "===Buzon de voz==="
    Escribir "MENU PRINCIPAL"
    Escribir "Ingrese el mensaje de voz:"
    Escribir "1-Ventas"
    Escribir "2-Recepción"
    Escribir "3-Dirección"
    Escribir "4-Compras"
    Escribir "digite la opcion que desea: "
    Leer opcion
    
    Si opcion = 1 Entonces
        Limpiar Pantalla
        Escribir "Bienvenido al depto de Ventas"
        Escribir "VentasOrg@gmail.com"
    SiNo
        Si opcion = 2 Entonces
            Limpiar Pantalla
            Escribir "Bienvenido al depto de Recepción"
            Escribir "Recepción@gmail.com"
        SiNo
            Si opcion = 3 Entonces
                Limpiar Pantalla
                Escribir "Bienvenido al depto de Dirección"
                Escribir "Dirección@gmail.com"
            SiNo
                Si opcion = 4 Entonces
                    Limpiar Pantalla
                    Escribir "Bienvenido al depto de 4-Compras"
                    Escribir "4-Compras@gmail.com"
                SiNo
                    Escribir "Saliendo del Sistema"
                    Limpiar Pantalla
                    Escribir "Saliendo del sistema"
                FinSi
            FinSi
        FinSi
    FinSi
    
    Escribir "Presione cualquier tecla para salir"
    Esperar Tecla
FinAlgoritmo