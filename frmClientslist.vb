Public Class frmClientslist

    Private Sub frm_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtg_listClients.Rows.Clear()
            findthis("Select * from tbl_clients WHERE Status='Active'")
            LoadData(dtg_listClients, "loadclient")
            dtg_listClients.Columns(0).Visible = False
            If lbl_id.Text = "id" Then
                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        lbl_id.Text = "id"
        Call frm_adduser_Load(sender, e)
        txt_name.Clear()
        txt_phone.Clear()


    End Sub

    Private Sub btn_saveuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveuser.Click

        If txt_name.Text = "" Or txt_phone.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Exclamation)
        Else
            result = saveInsert("insert into tbl_clients (`ClientName`, `PhoneNumber`, `Status`) " _
             & "values('" & txt_name.Text & "','" & txt_phone.Text _
             & "','Active')")
            If result = True Then
                MsgBox("Client has been saved in the database.")
            End If
        End If
        Call btn_close_Click(sender, e)

    End Sub
    Dim result As Boolean
    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Try
            If txt_name.Text = "" Or txt_phone.Text = "" Then
                MsgBox("All fields are required", MsgBoxStyle.Exclamation)
            Else
                result = UpdateSave("update tbl_clients set clientName = '" & txt_name.Text & "',phoneNumber= '" & txt_phone.Text _
                            & "'   where clientID = " & lbl_id.Text)
                If result = True Then
                    MsgBox("Client has been updated in the database.")
                End If

                Call btn_close_Click(sender, e)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try

            If MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                'result = deletes("delete from tbluseraccounts where UserId = '" & lbl_id.Text & "'")
                result = UpdateSave("update tbluseraccounts set Status='NotActive' where UserId = " & lbl_id.Text)
                If result = True Then
                    MessageBox.Show("User has been deleted in the database.", "Success", MessageBoxButtons.OK)
                End If
                'Call frm_adduser_Load(sender, e)

                Call btn_close_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtg_listUser_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_listClients.CellClick

    End Sub

    Private Sub dtg_listUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listClients.Click
        Try
            With dtg_listClients.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_phone.Text = .Cells(2).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtg_listUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listClients.DoubleClick
        Try
            With dtg_listClients.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_phone.Text = .Cells(2).Value
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub lbl_id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_id.TextChanged
        Try
            If lbl_id.Text = "id" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cbo_type_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dtg_listClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_listClients.CellContentClick

    End Sub
End Class