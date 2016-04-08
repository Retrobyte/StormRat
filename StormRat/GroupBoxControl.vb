'Creator: Aeonhack
'Date: 4/23/2011
'Site: www.elitevs.net
'Version: 1.4
'Note: This code only contains part (33%) of the full ThemeBase.

Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Runtime.InteropServices

MustInherit Class ThemeContainerControl
    Inherits ContainerControl

#Region " Initialization "

    Protected G As Graphics, B As Bitmap
    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)
        B = New Bitmap(1, 1)
        G = Graphics.FromImage(B)
    End Sub

    Sub AllowTransparent()
        SetStyle(ControlStyles.Opaque, False)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

#End Region

#Region " Convienence "

    MustOverride Sub PaintHook()
    Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Width = 0 OrElse Height = 0 Then Return
        PaintHook()
        e.Graphics.DrawImage(B, 0, 0)
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If Not Width = 0 AndAlso Not Height = 0 Then
            B = New Bitmap(Width, Height)
            G = Graphics.FromImage(B)
            Invalidate()
        End If
        MyBase.OnSizeChanged(e)
    End Sub

    Private _NoRounding As Boolean
    Property NoRounding() As Boolean
        Get
            Return _NoRounding
        End Get
        Set(ByVal v As Boolean)
            _NoRounding = v
            Invalidate()
        End Set
    End Property

    Private _Rectangle As Rectangle
    Private _Gradient As LinearGradientBrush

    Protected Sub DrawCorners(ByVal c As Color, ByVal rect As Rectangle)
        If _NoRounding Then Return
        B.SetPixel(rect.X, rect.Y, c)
        B.SetPixel(rect.X + (rect.Width - 1), rect.Y, c)
        B.SetPixel(rect.X, rect.Y + (rect.Height - 1), c)
        B.SetPixel(rect.X + (rect.Width - 1), rect.Y + (rect.Height - 1), c)
    End Sub

    Protected Sub DrawBorders(ByVal p1 As Pen, ByVal p2 As Pen, ByVal rect As Rectangle)
        G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1)
        G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3)
    End Sub

    Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
        _Rectangle = New Rectangle(x, y, width, height)
        _Gradient = New LinearGradientBrush(_Rectangle, c1, c2, angle)
        G.FillRectangle(_Gradient, _Rectangle)
    End Sub
#End Region

End Class

Class GroupBox
    Inherits ThemeContainerControl

    Sub New()
        AllowTransparent()
        _Border1 = New Pen(Color.FromArgb(90, Color.Black))
        _Border2 = New Pen(Color.FromArgb(14, Color.White))
    End Sub

    Private _Border1 As Pen
    Property Border1() As Color
        Get
            Return _Border1.Color
        End Get
        Set(ByVal v As Color)
            _Border1 = New Pen(v)
            Invalidate()
        End Set
    End Property

    Private _Border2 As Pen
    Property Border2() As Color
        Get
            Return _Border2.Color
        End Get
        Set(ByVal v As Color)
            _Border2 = New Pen(v)
            Invalidate()
        End Set
    End Property

    Private _FillColor As Color = Color.Transparent
    Property FillColor() As Color
        Get
            Return _FillColor
        End Get
        Set(ByVal v As Color)
            _FillColor = v
            Invalidate()
        End Set
    End Property

    Overrides Sub PaintHook()
        G.Clear(_FillColor)
        DrawBorders(_Border1, _Border2, ClientRectangle)
        DrawCorners(BackColor, ClientRectangle)
    End Sub

End Class