Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class MyPolicy
    Implements ICertificatePolicy

    Public Function CheckValidationResult(srvPoint As ServicePoint, certificate As X509Certificate, request As WebRequest, certificateProblem As Integer) As Boolean Implements ICertificatePolicy.CheckValidationResult

        If (certificateProblem = 0 OrElse              '//正常 
        　　　certificateProblem = -2146762487 OrElse    '//信頼されてない？ 
        　　　certificateProblem = -2146762495 OrElse    '//期限切れ 
        　　　certificateProblem = -2146762481) Then      '//名前不正？ 
            Return True
        Else
            Return False
        End If

    End Function
    '{ 
    'Public bool CheckValidationResult( 
    '　ServicePoint srvPoint,
    'System.Security.Cryptography.X509Certificates.X509Certificate certificate, 
    '　WebRequest request, int certificateProblem) 
    '{ 
    '　If (certificateProblem == 0 || //正常 
    '　　　certificateProblem == -2146762487 || //信頼されてない？ 
    '　　　certificateProblem == -2146762495 || //期限切れ 
    '　　　certificateProblem == -2146762481) //名前不正？ 
    '　　Return True; 
    '　Else
    '    Return False; 
    '} 
    '} 
End Class
