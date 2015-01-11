Imports System.Runtime.InteropServices

Module Util
    Public CodigoMedico As String = System.Configuration.ConfigurationManager.AppSettings.Get("CodigoMedico")
    Public CodigoFarmaceutico As String = System.Configuration.ConfigurationManager.AppSettings.Get("CodigoFarmaceutico")

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

End Module
