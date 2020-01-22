Imports System.IO.Ports
Imports System.IO
Public Class Form1

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = ComboBox1.SelectedItem
        SerialPort1.Open()
        Timer1.Start()
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        Timer1.Stop()
    End Sub

    Private Sub btnON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnON.Click
        SerialPort1.Write("G")
    End Sub

    Private Sub btnOFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOFF.Click
        SerialPort1.Write("g")
    End Sub
    Dim rcv As String
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        rcv = SerialPort1.ReadLine()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblValue.Text = rcv
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim port As String
        Dim ports() As String

        ports = System.IO.Ports.SerialPort.GetPortNames
        For Each port In ports
            ComboBox1.Items.Add(port)
        Next
    End Sub
End Class
