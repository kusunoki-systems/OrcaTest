Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function PatientBase() As ActionResult
        ViewData("Message") = "Your application description page."
        Dim args As ArrayList = New ArrayList
        args.Add("/api01rv2/patientgetv2?id=") '患者基本
        args.Add("4")
        Dim patient As New PatientBase
        ViewData("Patient") = patient.Main((From o In args Select DirectCast(o, String)).ToArray)
        'PatientBase.Main(CType(args.ToArray(GetType(String)), String()))
        Return View()
    End Function

    Function SystemInfo() As ActionResult
        ViewData("Message") = "Your application description page."
        Dim args As ArrayList = New ArrayList
        args.Add("/api01rv2/systeminfv2")   'システム情報
        Dim Systeminf As New SystemInfo
        ViewData("SystemInfo") = Systeminf.Main((From o In args Select DirectCast(o, String)).ToArray)
        'PatientBase.Main(CType(args.ToArray(GetType(String)), String()))
        Return View()
    End Function

End Class
