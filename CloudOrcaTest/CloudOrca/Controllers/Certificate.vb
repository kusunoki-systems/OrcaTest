Imports System.IO
Imports System.Net.Http
Imports System.Security.Cryptography.X509Certificates

Public Class Certificate

    Public Sub MainProc(ByVal args() As String)
        'Dim url As var = "http://hogefuga.com/"
        'Dim certPath As var = "C:\certFileName.p12"  ' クライアント証明書ファイルへのパス
        'Dim certPassword As var = "password"  ' クライアント証明書ファイルのパスワード

        '' クライアント証明書付きのハンドラを生成
        'Dim handler As WebRequestHandler = Me.CreateRequestHandler(certPath, certPassword)

        'Imports (HttpClient client = New HttpClient(handler))
        '    {
        '        Dim response As HttpResponseMessage = client.GetAsync(url).Result
        '        ' :
        '    }
    End Sub

    Public Function CreateRequestHandler(ByVal certPath As String, ByVal certPassword As String) As WebRequestHandler

        ' クライアント証明書読み込み
        Dim x509 As X509Certificate2 = New X509Certificate2(Me.ReadFileAsBytes(certPath),
                                                     certPassword,
                                                     X509KeyStorageFlags.MachineKeySet)

        Dim handler As WebRequestHandler = New WebRequestHandler()
        handler.ClientCertificates.Add(x509)

        Return handler
    End Function

    Private Function ReadFileAsBytes(ByRef fileName As String) As Byte()

        Using fs As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)

            Dim bs(fs.Length - 1) As Byte
            'ファイルの内容をすべて読み込む
            fs.Read(bs, 0, bs.Length)
            '閉じる
            fs.Close()
            Return bs

            'Dim rowData() As Byte = Nothing
            'stream.Read(rowData, 0, stream.Length)
            'Return rowData

        End Using

    End Function





    '----------------------------------------------------------------
    ' Converted from C# to VB .NET using CSharpToVBConverter(1.2).
    ' Developed by: Kamal Patel (http://www.KamalPatel.net) 
    '----------------------------------------------------------------
End Class