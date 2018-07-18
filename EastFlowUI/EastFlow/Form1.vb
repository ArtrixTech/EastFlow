﻿Public Class Form1

    Dim allBlocks(64) As Block

    Dim blocksCoor(8, 8) As Block

    Function generateCommandInput()

        Dim returnStr = ""

        For y = 0 To 7
            For x = 0 To 7
                If Not x = 7 Then
                    returnStr += CStr(blocksCoor(x, y).colorID)
                    returnStr += " "
                Else
                    returnStr += CStr(blocksCoor(x, y).colorID)
                End If
            Next
            returnStr += vbCrLf
        Next

        Return returnStr

    End Function

    Private Sub Load_Timer(sender As Object, e As EventArgs) Handles LoadTimer.Tick

        LoadTimer.Stop()

        allBlocks = {Block1, Block2, Block3, Block4, Block5, Block6, Block7, Block8, Block9, Block10, Block11, Block12, Block13, Block14, Block15, Block16, Block17, Block18, Block19, Block20, Block21, Block22, Block23, Block24, Block25, Block26, Block27, Block28, Block29, Block30, Block31, Block32, Block33, Block34, Block35, Block36, Block37, Block38, Block39, Block40, Block41, Block42, Block43, Block44, Block45, Block46, Block47, Block48, Block49, Block50, Block51, Block52, Block53, Block54, Block55, Block56, Block57, Block58, Block59, Block60, Block61, Block62, Block63, Block64}

        Dim visitedX() As Boolean = {False, False, False, False, False, False, False, False}

        For Each block As Block In allBlocks
            blocksCoor(block.xIndex, block.yIndex) = block
        Next

    End Sub


    Private Sub Calculate(sender As Object, e As EventArgs) Handles FlatButton4.MouseDown

        imgCalc.Show()
        lblCalc.Show()

        Dim p As New ShellOperation("EastFlowAlgo.exe")

        p.run()
        p.input(generateCommandInput())
        Dim result As String = p.getOutput()
        RichTextBox2.Text = result
        'MessageBox.Show(result)

        Try
            Dim x = 0, y = 0
            Dim resultCoor(8, 8) As Integer

            For Each line In result.Split(vbNewLine)
                If line.Length > 2 Then
                    Dim data = line.Split(" ")
                    For x = 0 To 7
                        resultCoor(x, y) = data(x)
                    Next
                    y += 1
                End If

            Next

            For y = 0 To 7
                For x = 0 To 7
                    If blocksCoor(x, y).colorID = resultCoor(x, y) Then
                        resultCoor(x, y) = -1
                    End If
                Next
            Next

            For y = 0 To 7
                For x = 0 To 7
                    If resultCoor(x, y) >= 0 Then
                        blocksCoor(x, y).colorID = resultCoor(x, y)
                        blocksCoor(x, y).isCastle = False

                        'blocksCoor(x, y).isResultBlock = True
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

        imgCalc.Hide()
        lblCalc.Hide()


    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        For Each block As Block In allBlocks
            block.resetColor()
        Next
    End Sub

    Private Sub btnGenerate(sender As Object, e As EventArgs) Handles FlatButton2.Click
        RichTextBox2.Text = generateCommandInput()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If RichTextBox1.TextLength = 128 Or RichTextBox1.TextLength = 127 Then
            loadFromText(sender, e)
        End If
    End Sub

    Private Sub loadFromText(sender As Object, e As EventArgs) Handles FlatButton3.Click

        Try
            Dim x = 0, y = 0

            For Each line In RichTextBox1.Lines
                If line.Length > 2 Then
                    Dim data = line.Split(" ")
                    For x = 0 To 7
                        blocksCoor(x, y).colorID = data(x)
                        blocksCoor(x, y).isCastle = True
                    Next
                    y += 1
                End If

            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FlatButton1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Load_1(sender As Object, e As EventArgs) Handles FlatButton1.Load

    End Sub

    Private Sub Calculate(sender As Object, e As MouseEventArgs) Handles FlatButton4.MouseDown

    End Sub
End Class