Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection
    Public con As SqlConnection

    Public IDUSUARIO As Integer
    Dim cadena As String = ("Data Source = KECH-PC\KECH; Initial Catalog = biblioteca; Integrated Security = True")
    Protected Function conectado()

        Try
            'cnn = New SqlConnection("Data Source=SERVER\PUCHOSERVER;Initial Catalog=biblioteca;Integrated Security=True")
            cnn = New SqlConnection("Data Source = KECH-PC\KECH; Initial Catalog = biblioteca; Integrated Security = True")

            'cnn = New SqlConnection("Data Source = 192.168.1.20,1433; Initial Catalog = biblioteca; user Id=pucho; password=1234;")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub conectar()
        con = New SqlConnection
        con.ConnectionString = cadena

        Try
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub desconectar()
        con.Close()
    End Sub


End Class
