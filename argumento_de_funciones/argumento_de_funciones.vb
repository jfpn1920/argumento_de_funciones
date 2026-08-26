Imports System
Module argumento_de_funciones
    Function Sumar(primerArgumento As Double, segundoArgumento As Double) As Double
        Return primerArgumento + segundoArgumento
    End Function
    Function Restar(primerArgumento As Double, segundoArgumento As Double) As Double
        Return primerArgumento - segundoArgumento
    End Function
    Function Multiplicar(primerArgumento As Double, segundoArgumento As Double) As Double
        Return primerArgumento * segundoArgumento
    End Function
    Function Dividir(primerArgumento As Double, segundoArgumento As Double) As Double
        Return primerArgumento / segundoArgumento
    End Function
    Function Potenciar(primerArgumento As Double, segundoArgumento As Double) As Double
        Return Math.Pow(primerArgumento, segundoArgumento)
    End Function
    Function Promediar(primerArgumento As Double, segundoArgumento As Double) As Double
        Return (primerArgumento + segundoArgumento) / 2
    End Function
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim tiposFunciones(9) As String
        Dim primerosArgumentos(9) As Double
        Dim segundosArgumentos(9) As Double
        Dim resultados(9) As Double
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-------------------------------------------'
        '--|menu_principal_argumento_de_funciones|--'
        '-------------------------------------------'
        Do
            Console.WriteLine("menu principal argumento de funciones")
            Console.WriteLine("1) Registrar ejercicio")
            Console.WriteLine("2) Editar ejercicio")
            Console.WriteLine("3) Listar ejercicios")
            Console.WriteLine("4) Buscar ejercicio")
            Console.WriteLine("5) Eliminar ejercicio")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-------------------------'
                '--|registrar_ejercicio|--'
                '-----.-------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas ejercicios.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre del ejercicio: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Tipo de funcion: ")
                        tiposFunciones(cantidad) = Console.ReadLine()
                        Console.Write("Primer argumento: ")
                        primerosArgumentos(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Segundo argumento: ")
                        segundosArgumentos(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Select Case tiposFunciones(cantidad).ToLower()
                            Case "suma"
                                resultados(cantidad) = Sumar(primerosArgumentos(cantidad), segundosArgumentos(cantidad))
                            Case "resta"
                                resultados(cantidad) = Restar(primerosArgumentos(cantidad), segundosArgumentos(cantidad))
                            Case "multiplicacion"
                                resultados(cantidad) = Multiplicar(primerosArgumentos(cantidad), segundosArgumentos(cantidad))
                            Case "division"
                                If segundosArgumentos(cantidad) <> 0 Then
                                    resultados(cantidad) = Dividir(primerosArgumentos(cantidad), segundosArgumentos(cantidad))
                                Else
                                    Console.WriteLine("No se puede dividir entre cero.")
                                    Continue Do
                                End If
                            Case "potencia"
                                resultados(cantidad) = Potenciar(primerosArgumentos(cantidad), segundosArgumentos(cantidad))
                            Case "promedio"
                                resultados(cantidad) = Promediar(primerosArgumentos(cantidad), segundosArgumentos(cantidad))
                            Case Else
                                Console.WriteLine("Tipo de funcion no valido.")
                                Continue Do
                        End Select
                        estados(cantidad) = "Calculado"
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Ejercicio registrado correctamente.")
                    End If
                '----------------------'
                '--|editar_ejercicio|--'
                '----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen ejercicios registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Tipo de funcion: " & tiposFunciones(i) & " | Primer argumento: " & primerosArgumentos(i) & " | Segundo argumento: " & segundosArgumentos(i) & " | Resultado: " & resultados(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del ejercicio a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre del ejercicio: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nuevo tipo de funcion: ")
                            tiposFunciones(posicion) = Console.ReadLine()
                            Console.Write("Nuevo primer argumento: ")
                            primerosArgumentos(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nuevo segundo argumento: ")
                            segundosArgumentos(posicion) = Convert.ToDouble(Console.ReadLine())
                            Select Case tiposFunciones(posicion).ToLower()
                                Case "suma"
                                    resultados(posicion) = Sumar(primerosArgumentos(posicion), segundosArgumentos(posicion))
                                Case "resta"
                                    resultados(posicion) = Restar(primerosArgumentos(posicion), segundosArgumentos(posicion))
                                Case "multiplicacion"
                                    resultados(posicion) = Multiplicar(primerosArgumentos(posicion), segundosArgumentos(posicion))
                                Case "division"
                                    If segundosArgumentos(posicion) <> 0 Then
                                        resultados(posicion) = Dividir(primerosArgumentos(posicion), segundosArgumentos(posicion))
                                    Else
                                        Console.WriteLine("No se puede dividir entre cero.")
                                        Continue Do
                                    End If
                                Case "potencia"
                                    resultados(posicion) = Potenciar(primerosArgumentos(posicion), segundosArgumentos(posicion))
                                Case "promedio"
                                    resultados(posicion) = Promediar(primerosArgumentos(posicion), segundosArgumentos(posicion))
                                Case Else
                                    Console.WriteLine("Tipo de funcion no valido.")
                                    Continue Do
                            End Select
                            estados(posicion) = "Calculado"
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Ejercicio actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|listar_ejercicios|--'
                '-----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen ejercicios registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Tipo de funcion: " & tiposFunciones(i) & " | Primer argumento: " & primerosArgumentos(i) & " | Segundo argumento: " & segundosArgumentos(i) & " | Resultado: " & resultados(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '----------------------'
                '--|buscar_ejercicio|--'
                '----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen ejercicios registrados.")
                    Else
                        Console.Write("Ingrese el ID del ejercicio a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Tipo de funcion: " & tiposFunciones(posicion) & " | Primer argumento: " & primerosArgumentos(posicion) & " | Segundo argumento: " & segundosArgumentos(posicion) & " | Resultado: " & resultados(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------'
                '--|eliminar_ejercicio|--'
                '------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen ejercicios registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Tipo de funcion: " & tiposFunciones(i) & " | Primer argumento: " & primerosArgumentos(i) & " | Segundo argumento: " & segundosArgumentos(i) & " | Resultado: " & resultados(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del ejercicio a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                tiposFunciones(i) = tiposFunciones(i + 1)
                                primerosArgumentos(i) = primerosArgumentos(i + 1)
                                segundosArgumentos(i) = segundosArgumentos(i + 1)
                                resultados(i) = resultados(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Ejercicio eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen ejercicios registrados.")
                    Else
                        Dim sumas As Integer = 0
                        Dim restas As Integer = 0
                        Dim multiplicaciones As Integer = 0
                        Dim divisiones As Integer = 0
                        Dim potencias As Integer = 0
                        Dim promedios As Integer = 0
                        Dim resultadoTotal As Double = 0
                        Dim resultadoMayor As Double = resultados(0)
                        Dim resultadoMenor As Double = resultados(0)
                        For i As Integer = 0 To cantidad - 1
                            resultadoTotal += resultados(i)
                            If resultados(i) > resultadoMayor Then
                                resultadoMayor = resultados(i)
                            End If
                            If resultados(i) < resultadoMenor Then
                                resultadoMenor = resultados(i)
                            End If
                            Select Case tiposFunciones(i).ToLower()
                                Case "suma"
                                    sumas += 1
                                Case "resta"
                                    restas += 1
                                Case "multiplicacion"
                                    multiplicaciones += 1
                                Case "division"
                                    divisiones += 1
                                Case "potencia"
                                    potencias += 1
                                Case "promedio"
                                    promedios += 1
                            End Select
                        Next
                        Dim promedioGeneral As Double = resultadoTotal / cantidad
                        Console.WriteLine("Ejercicios: " & cantidad & " | Calculados: " & cantidad & " | Sumas: " & sumas & " | Restas: " & restas & " | Multiplicaciones: " & multiplicaciones & " | Divisiones: " & divisiones & " | Potencias: " & potencias & " | Promedios: " & promedios & " | Resultado mayor: " & resultadoMayor & " | Resultado menor: " & resultadoMenor & " | Promedio general: " & promedioGeneral)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Argumento de Funciones.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module