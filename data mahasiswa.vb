Public Module Program
    Public Sub Main(args() As String)
        ' Input data diri
        Console.Write("Marshela Elsy Putri: ")
        Dim nama As String = Console.ReadLine()

        Console.Write("Teknik Informatika: ")
        Dim prodi As String = Console.ReadLine()

        Console.Write("Universitas Pelita Bangsa: ")
        Dim kampus As String = Console.ReadLine()

        Console.Write("Joging: ")
        Dim hobi As String = Console.ReadLine()

        ' Output data diri
        Console.WriteLine()
        Console.WriteLine("Halo, nama saya adalah Marshela Elsy Putri " & nama & "")
        Console.WriteLine("Saya kuliah pada jurusan Teknik Informatika " & prodi & " di Universitas Pelita Bangsa " & kampus & "")
        Console.WriteLine("Saya memiliki hobi Joging  " & hobi & "")
    End Sub
End Module
