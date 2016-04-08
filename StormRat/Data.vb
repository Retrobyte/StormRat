Imports System.Runtime.Serialization, System.IO

<Serializable()> Public Class Data
    Implements ISerializable
    Private data As String
    Private bytes() As Byte
    Public Sub New(ByVal s As String, ByVal b() As Byte)
        data = s : bytes = b
    End Sub
    Public Sub New(ByVal info As SerializationInfo, ByVal ctxt As StreamingContext)
        data = DirectCast(info.GetValue("data", GetType(String)), String)
        bytes = DirectCast(info.GetValue("bytes", GetType(Byte())), Byte())
    End Sub
    Public Sub GetObjectData(ByVal info As SerializationInfo, ByVal ctxt As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("data", data) : info.AddValue("bytes", bytes)
    End Sub
    Public Function GetData() As String
        Return data
    End Function
    Public Function GetImage() As Image
        Dim ms As MemoryStream = New MemoryStream(bytes)
        Return Image.FromStream(ms)
    End Function
    Public Function GetBytes() As Byte()
        Return bytes
    End Function
End Class