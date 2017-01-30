Imports System.Net.NetworkInformation

Public Class FormLogIn
    Public myDeviceAccessTest As DeviceAccessDS.tblDevicesDataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If (TextBoxUser.Text = "Admin") Then
            AdminScreen.Show()
        Else
            Try
                Dim UserDS As New UsersDSTableAdapters.UsersTableAdapter
                Dim MyUser = UserDS.GetDataBy(TextBoxUser.Text)

                If (TextBoxUser.Text = MyUser(0).USERNAME) Then
                    'failure msg
                    If (MyUser(0).ROLEID = 3) Then
                        Policy.Show()
                        Me.Hide()
                    ElseIf (MyUser(0).ROLEID = 2) Then
                        Form1.Show()
                        Me.Hide()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Well Try Again. You Will get it one day.")
            End Try

        End If

      


    End Sub

    Private Sub FormLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

        MAC.Text = getMacAddress1()

        Mac2.Text = getMacAddress2()
        'Test mAC 1
        Dim SeeIfPCisGood As New DeviceAccessDSTableAdapters.tblDevicesTableAdapter
        myDeviceAccessTest = SeeIfPCisGood.GetDataMACID(MAC.Text)
        Dim MACID1, MACID2 As Integer

        MACID1 = myDeviceAccessTest(0).Authorized

            If MACID1 = 0 Then
                Label11.Text = "Call 440 2265"
                TextBoxUser.Enabled = False
                Label9.Text = "This computer is NOT Authorized to access this system"
            End If
        If MACID1 = 1 Then
            Label9.Text = "Authorized"
            Button1.Enabled = True
        End If

        'Test mac 2
        myDeviceAccessTest = SeeIfPCisGood.GetDataMACID(Mac2.Text)
        MACID2 = myDeviceAccessTest(0).Authorized
        If MACID2 = 0 Then
            TextBoxUser.Enabled = False
            Label10.Text = "This computer is NOT Authorized to access this system"
        End If
        If MACID2 = 1 Then
            Label10.Text = " Authorized "
            Button1.Enabled = True
        End If
        If (MACID1 = 1 Or MACID2 = 1) Then
            TextBoxUser.Enabled = True
            Button1.Enabled = True

        Else
            Label11.Text = "Call 440 2265"
        End If
        Catch ex As Exception

        End Try


    End Sub
    Function getMacAddress1()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Function getMacAddress2()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class