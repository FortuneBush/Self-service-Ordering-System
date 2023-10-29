Public Class OrderingSystem
    Dim TotalTime As Integer = 0
    Dim TotalPrice As Integer = 0
    Public mMenuList As MenuListClass = MenuListClass.Instance
    Dim Balance As Integer = Form1.IdBase(Form1.IdNumber).Balance
    Dim freq As Boolean = True

    Private Sub MenuSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBalance.Text = Balance.ToString
        For Each element In mMenuList.foodList
            dgvMenu.Rows.Add(element.Name, element.Specification, element.Kind, element.Price, element.Time)
        Next
        dgvMenu.ClearSelection()
        lblBalance1.BackColor = Color.Transparent
        lblBalance2.BackColor = Color.Transparent
        lblPrice1.BackColor = Color.Transparent
        lblPrice2.BackColor = Color.Transparent
        lblTime1.BackColor = Color.Transparent
        lblTime2.BackColor = Color.Transparent
    End Sub

    '通过“添加”按钮点餐
    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim i As Integer
            Dim time As Integer
            Dim price As Integer
            Dim food As String

            i = e.RowIndex
            food = dgvMenu.Rows(i).Cells(0).Value
            price = dgvMenu.Rows(i).Cells(3).Value
            time = dgvMenu.Rows(i).Cells(4).Value

            dgvOrder.ClearSelection()
            dgvOrder.Rows.Add(food, 1)
            TotalPrice += price
            TotalTime += time
            txtPrice.Text = TotalPrice.ToString
            txtTime.Text = TotalTime.ToString

            dgvMenu.ClearSelection()
            dgvOrder.ClearSelection()
        End If

        '将余额提醒设置为只提醒一次，方便顾客的继续点餐
        If TotalPrice > Balance And freq = True Then
            MessageBox.Show("您的余额不足以支付当前所点菜品，请及时续费~", "温馨提醒")
            freq = False
        End If
    End Sub

    '防止误触，设置双击为选择菜品
    Private Sub dgvMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentDoubleClick
        Dim i As Integer
        Dim time As Integer
        Dim price As Integer
        Dim food As String

        i = dgvMenu.CurrentRow.Index
        food = dgvMenu.Rows(i).Cells(0).Value
        price = dgvMenu.Rows(i).Cells(3).Value
        time = dgvMenu.Rows(i).Cells(4).Value

        dgvOrder.ClearSelection()
        dgvOrder.Rows.Add(food， 1)
        TotalPrice += price
        TotalTime += time
        txtPrice.Text = TotalPrice.ToString
        txtTime.Text = TotalTime.ToString
        dgvOrder.ClearSelection()
        dgvMenu.ClearSelection()

        '将余额提醒设置为只提醒一次，方便顾客的继续点餐
        If TotalPrice > Balance And freq = True Then
            MessageBox.Show("您的余额不足以支付当前所点菜品，请及时续费~", "温馨提醒")
            freq = False
        End If
    End Sub


    '提交订单，重新计算余额，计时器开始计时
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Balance >= TotalPrice Then
            MessageBox.Show("订单提交完成！请耐心等候~", "温馨提醒")
            Timer1.Enabled = True
            Timer1.Interval = 60 * 1000 * TotalTime
            Balance -= TotalPrice
            txtBalance.Text = Balance.ToString
        Else
            MessageBox.Show("抱歉，您的余额不足以支付餐费，请充值后再次提交订单~", "温馨提醒")
        End If
    End Sub

    '订单完成时弹窗提醒
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        MessageBox.Show("您的订单已完成！请及时取餐~", "温馨提醒")
        dgvOrder.Rows.Clear()
        TotalPrice = 0
        TotalTime = 0
        txtPrice.Text = TotalPrice.ToString
        txtTime.Text = TotalTime.ToString
    End Sub

    '删除已选产品
    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim SelectedFood As String
            Dim delPrice As Integer
            Dim delTime As Integer
            SelectedFood = dgvOrder.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value
            For Each element In mMenuList.foodList
                If SelectedFood = element.Name Then
                    delPrice = element.Price
                    delTime = element.Time
                    Exit For
                End If
            Next

            TotalPrice -= delPrice
            TotalTime -= delTime
            dgvOrder.Rows.RemoveAt(e.RowIndex)
            txtPrice.Text = TotalPrice.ToString
            txtTime.Text = TotalTime.ToString
        End If
    End Sub

End Class