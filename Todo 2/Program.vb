Module Program
    Sub Main()
        Dim seleccion As Integer

        Console.WriteLine("Seleccione algun punto de la guia")
        Console.WriteLine("1. Generar y rellenar un arreglo unidimensional, pedir la longitud del arreglo al usuario y debe contener valores pares partiendo desde el 2")
        Console.WriteLine("2. Generar y rellenar un arreglo unidimensional, los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario")
        Console.WriteLine("3. Generar y rellenar una matriz cuadrada de dimensión o longitud dada por el usuario, llenarla con número impares")
        Console.WriteLine("4. Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición")
        Console.WriteLine("5. Generar una matriz cuadrada mostrar solo la diagonal principal con elementos 0(DP)")
        Console.WriteLine("6. Generar una matriz cuadrada mostrar solo la diagonal trasversa con elementos 0 (DT)")
        Console.WriteLine("7. Generar una matriz cuadrada mostrar solo la diagonal principal y trasversa")
        Console.WriteLine("8. Generar una matriz cuadrada mostrar solo las puntas de la matriz con elementos 0")
        Console.WriteLine("9. Generar una matriz cuadrada dibujar un cuadrado con 0")
        Console.WriteLine("10. Generar una matriz cuadrada NxN(solo valores impares y mayores a 3) y generar el sgte relleno: N=5")

        seleccion = Console.ReadLine()

        Select Case seleccion
            Case 1
                primero()
            Case 2
                segundo()
            Case 3
                tercero()
            Case 4
                cuarto()
            Case 5
                quito()
            Case 6
                sexto()
            Case 7
                septimo()
            Case 8
                octavo()
            Case 9
                noveno()
            Case 10
                'decimo()
        End Select


    End Sub


    Function primero()
        'Generar y rellenar unidimencional, pedir la longityd del arreglo al usuario y debe tener contener valores pares partiendo desde el 2

        Dim longi As Integer

        Console.WriteLine("Digite el tamaño del arreglo")
        longi = Console.ReadLine()

        If longi < 2 Then
            Do
                Console.WriteLine("Digite el tamaño del arreglo")
                longi = Console.ReadLine()
            Loop Until longi >= 2
        End If

        Dim arreglo(longi) As Integer
        Dim relleno As Integer
        relleno = 2

        For i = 1 To arreglo.GetUpperBound(0)

            arreglo(i) += relleno
            relleno += 2

        Next

        For i = 1 To arreglo.GetUpperBound(0)

            Console.Write(arreglo(i) & " ")

        Next

        Return 0
    End Function

    Function segundo()
        'Generar y rellenar un arreglo unidimensional, los valores a llenar será el resultado de la tabla de multiplicar delque desee el usuario

        Dim multiplo As Double
        Dim arreglo(10) As Integer

        Console.Write("Digite la tabla de multiplicar que desea saber")
        multiplo = Console.ReadLine()


        For i = 0 To arreglo.GetUpperBound(0)

            arreglo(i) = multiplo * (i)

        Next

        For i = 0 To arreglo.GetUpperBound(0)

            Console.WriteLine(multiplo & " x " & i & " = " & arreglo(i))

        Next

        Return 0
    End Function

    Function tercero()
        'Generar y rellenar un matriz cauadrada de dimencsion o logitud dada por el usuario, llenarla con números impares

        Dim c As Integer
        Dim r As Integer


        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Digite las filas y columnas de una matriz cuadrada")
        Console.WriteLine()
        Console.WriteLine()

        Console.Write("Digire la cantidad de filas: ")
        r = Console.ReadLine()

        Console.Write("Digite la cantidad de columnas: ")
        c = Console.ReadLine()

        If (r <> c) Then
            Do
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("Vuelva y digite, Recuerde que es un matriz cuadrada por lo cual debe haber la misma cantidad de filas que columnas")
                Console.WriteLine()
                Console.WriteLine()

                Console.Write("Digire la cantidad de filas: ")
                r = Console.ReadLine()

                Console.Write("Digite la cantidad de columnas: ")
                c = Console.ReadLine()
            Loop Until (r = c)
        End If

        Dim matriz(r, c) As Integer
        Dim relleno As Integer

        relleno = 1

        For i = 0 To matriz.GetUpperBound(0) Step 1
            For j = 0 To matriz.GetUpperBound(1) Step 1

                matriz(i, j) = relleno
                relleno += 2

                Console.Write(matriz(i, j) & " ")

            Next
            Console.WriteLine()
        Next

        Return 0
    End Function

    Function cuarto()

        'Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición

        Dim c As Integer
        Dim r As Integer

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Digite las filas y columnas de una matriz")
        Console.WriteLine()
        Console.WriteLine()

        Console.Write("Digire la cantidad de filas: ")
        r = Console.ReadLine()

        Console.Write("Digite la cantidad de columnas: ")
        c = Console.ReadLine()

        If (r And c) < 1 Then
            Do
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("Vuelva y digite, Recuerde que es un matriz cuadrada por lo cual debe haber la misma cantidad de filas que columnas")
                Console.WriteLine()
                Console.WriteLine()

                Console.Write("Digire la cantidad de filas: ")
                r = Console.ReadLine()

                Console.Write("Digite la cantidad de columnas: ")
                c = Console.ReadLine()
            Loop Until (r And c) >= 1
        End If

        Dim matriz(r, c) As Integer
        Dim relleno As Integer

        relleno = 1

        For i = 0 To matriz.GetUpperBound(0) Step 1
            For j = 0 To matriz.GetUpperBound(1) Step 1

                matriz(i, j) = relleno * i & relleno * j

                Console.Write(matriz(i, j) & " ")

            Next
            Console.WriteLine()
        Next


    End Function

    Function quito()

        'Generar una matriz cuadrada mostrar solo la diagonal principal con elementos 0(DP)


        Dim matriz(3, 3) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = j) Then
                    matriz(i, j) = " 0 "
                End If

                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Return 0
    End Function

    Function sexto()

        Dim matriz(3, 3) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = " 0 "
                End If

                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Return 0
    End Function

    Function septimo()

        Dim matriz(3, 3) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1

                If (i = j) Then
                    matriz(i, j) = "0"
                ElseIf (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = "0"

                End If
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next


        Return 0
    End Function

    Function octavo()


        Dim matriz(3, 3) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1

                If (i = 0 Or i = matriz.GetUpperBound(0) - 1) And (j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                End If
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next


        Return 0

    End Function

    Function noveno()
        'Generar una matriz cuadrada dibujar cuadrado con 0

        Dim matriz(3, 3) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1

                If (i = 0 Or i = matriz.GetUpperBound(0) - 1 Or j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = " "
                End If
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Return 0

    End Function

End Module
