Imports System

Module Program
    Sub Main()
        ' Langsung pakai nilai default
        Dim a As Integer = 10
        Dim b As Integer = 3

        ' Operasi aritmatika
        Dim penjumlahan As Integer = Math.Abs(a + b)
        Dim perkalian As Integer = Math.Abs(a * b)
        Dim pembagian As String = If(b <> 0, Math.Abs(a \ b).ToString(), "Tidak bisa (bagi nol)")
        Dim modulus As String = If(b <> 0, Math.Abs(a Mod b).ToString(), "Tidak bisa (bagi nol)")

        ' Output hasil
        Console.WriteLine("Bilangan pertama: " & a)
        Console.WriteLine("Bilangan kedua  : " & b)
        Console.WriteLine(vbCrLf & "Hasil Operasi Aritmatika:")
        Console.WriteLine("Penjumlahan : " & penjumlahan)
        Console.WriteLine("Perkalian   : " & perkalian)
        Console.WriteLine("Pembagian   : " & pembagian)
        Console.WriteLine("Modulus     : " & modulus)
    End Sub
End Module
