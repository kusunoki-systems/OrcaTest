Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security

Public Class PatientBase

    Public Function Main(ByVal args() As String) As String
        Dim HOST As String = "sms.orca-ng.org"
        Dim PORT As String = "9201" '"8000" '
        Dim USER As String = "ormaster"
        Dim PASSWD As String = "5a8ed0b2de73b1d5f5f4bd6043540e3547e03152ae7470a6f329f27f1c737061"
        Dim ID As String = "0"
        Dim URL As String = String.Empty
        If (args.Length > 0) Then
            URL = args(0)
            ID = args(1)
        End If
        Dim rtn As String = String.Empty
        ' Version4.7
        Dim FULLURL As String = "https://" + HOST + ":" + PORT + URL + ID
        Dim P12 As String = "bin/Controllers/api857.p12"
        Dim P12PW As String = "nAVEBoz9GwocKqCD"
        'Dim P12 As String = "bin/Controllers/api858.p12"
        'Dim P12PW As String = "5RMshLTjNqCDHk8f"
        'Dim P12 As String = "bin/Controllers/client855.p12"
        'Dim P12PW As String = "9xAM9bEcmqX2FagF"
        'Dim P12 As String = "bin/Controllers/client856.p12"
        'Dim P12PW As String = "iVdSLQJLTJ3Mi9vm"
        Dim certPath As String = Path.Combine(HttpContext.Current.Server.MapPath("~/"), P12)  ' クライアント証明書ファイルへのパス
        Dim certPassword As String = P12PW  ' クライアント証明書ファイルのパスワード

        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf OnRemoteCertificateValidationCallback)
        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim req As HttpWebRequest = CType(HttpWebRequest.Create(FULLURL), HttpWebRequest)
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")
        req.Credentials = New NetworkCredential(USER, PASSWD)

        ' クライアント証明書付きのハンドラを生成
        'Dim Cert As New Certificate
        'Dim handler As WebRequestHandler = Cert.CreateRequestHandler(certPath, certPassword)
        Dim x509 As New X509Certificate2
        x509 = New X509Certificate2(certPath, certPassword, X509KeyStorageFlags.MachineKeySet)
        req.ClientCertificates.Add(x509)

        'Using client As HttpClient = New HttpClient(handler)

        '    Dim response As HttpResponseMessage = client.GetAsync(FULLURL).Result
        '    If response.StatusCode <> HttpStatusCode.OK Then
        '        rtn += response.ReasonPhrase
        '    End If
        'End Using

        'req.ProtocolVersion = HttpVersion.Version11;
        req.Method = "GET"
        '<post>
        'req.Method = "POST"
        ''文字コードを指定する
        ''Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
        ''Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")
        ''POST送信する文字列を作成
        ''Dim postData As String = "inlang=ja&word=" + System.Web.HttpUtility.UrlEncode("<data><private_objects type=""record""><Request_Date type=""String"">2018-11-12</Request_Date><Request_Time type=""String"">15:10:43:00</Request_Time></private_objects></data>", enc)
        'Dim postData As String = System.Web.HttpUtility.UrlEncode("<data><private_objects type=""record""><Request_Date type=""String"">2018-11-12</Request_Date><Request_Time type=""String"">15:10:43:00</Request_Time></private_objects></data>", enc)
        ''バイト型配列に変換
        'Dim postDataBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(postData)
        'req.ContentType = "application/xml"
        'req.ContentLength = postDataBytes.Length
        ''データをPOST送信するためのStreamを取得
        'Dim reqStream As System.IO.Stream = req.GetRequestStream()
        ''送信するデータを書き込む
        'reqStream.Write(postDataBytes, 0, postDataBytes.Length)
        'reqStream.Close()
        '<post>

        'req.Credentials = New NetworkCredential(USER, PASSWD)
        Dim res As HttpWebResponse = Nothing
        Try
            res = CType(req.GetResponse, HttpWebResponse)
            'Console.WriteLine(res.ResponseUri)
            'Console.WriteLine("Response server => {0}", res.Server)
            'Console.WriteLine(res.StatusDescription)
            rtn = res.ResponseUri.ToString
            rtn += String.Format("Response server => {0}", res.Server)
            rtn += res.StatusDescription

            ''応答データを受信するためのStreamを取得
            'Dim resStream As System.IO.Stream = res.GetResponseStream()
            ''受信して表示
            'Dim sr As New System.IO.StreamReader(resStream, enc)
            'rtn += sr.ReadToEnd()
            ''閉じる
            'sr.Close()

        Catch wex As WebException
            If (wex.Status = WebExceptionStatus.ProtocolError) Then
                Dim err As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                Dim errcode As Integer = CType(err.StatusCode, Integer)
                rtn += err.ResponseUri.ToString
                rtn += String.Format("Response server => {0}", err.Server)
                rtn += String.Format("{0}:{1}", errcode, err.StatusDescription)
                'Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")
                Dim sr As New System.IO.StreamReader(err.GetResponseStream, enc)
                rtn += sr.ReadToEnd()
                err.Close()
            Else
                Console.WriteLine(wex.Message)
            End If

        End Try

        If (Not (res) Is Nothing) Then
            Dim str As Stream = res.GetResponseStream
            Dim strread As StreamReader = New StreamReader(str)
            rtn += strread.ReadToEnd
            'Dim FILE_NAME As String = "foo.xml"
            'File.WriteAllText(FILE_NAME, strread.ReadToEnd)
            strread.Close()
            str.Close()
            res.Close()
        End If
        Return rtn
    End Function

    Private Function OnRemoteCertificateValidationCallback(sender As Object, certificate As X509Certificate, chain As X509Chain, SslPolicyErrors As SslPolicyErrors) As Boolean
        '信用したことにする
        Return True
    End Function
End Class

