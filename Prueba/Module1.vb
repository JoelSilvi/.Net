Module Module1

    Sub Main()
        Dim resto As Double = 8 Mod 3
        Console.WriteLine(resto)

        Dim aumento As Double = 5
        aumento += 2
        Console.WriteLine(aumento)

        Dim decremento As Double = 20
        decremento -= 2
        Console.WriteLine(decremento)

        Dim condicion As Boolean = -14 < 2 And 3 > 6
        Console.WriteLine(condicion)

        Dim negacion As Double = Not 14 < 8
        Console.WriteLine(negacion)

        Dim saludo As String = "Hola escribe tu nombre: "
        Console.Write(saludo)
        Dim pedirNombre As String = Console.ReadLine()
        Console.WriteLine("Bienvedio " & pedirNombre)


        Console.Write("Escribe un numero: ")
        Dim num1 As Integer = Console.ReadLine()

        Console.WriteLine("Tu numero es " & num1)

        Dim mayorQue As Boolean = 7 > 8

        If mayorQue Then
            Console.WriteLine("Hola el numero 7 es mayor a 5")
        Else
            Console.WriteLine("Hola el numero 7 no es mayor")
        End If

        Console.Write("Cuando dinero tienes ahorrado: ")
        Dim dineroEstudiante As Double = Console.ReadLine()

        If dineroEstudiante >= 600 Then
            Console.WriteLine(pedirNombre & " Con " & dineroEstudiante & " Puedes pagar la Universidad y estudiar")
        Else
            Console.WriteLine(pedirNombre & " Con " & dineroEstudiante & " No puedes pagar la universidad y estudiar")
        End If
    End Sub



End Module
