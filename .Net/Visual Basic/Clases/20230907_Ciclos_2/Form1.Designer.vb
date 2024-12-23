<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lst_Valor = New ListBox()
        btn_For1 = New Button()
        btn_For2 = New Button()
        btn_For3 = New Button()
        btn_Limpiar = New Button()
        btn_While1 = New Button()
        btn_While2 = New Button()
        btn_While3 = New Button()
        Button1 = New Button()
        Btn_While4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(287, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 37)
        Label1.TabIndex = 0
        Label1.Text = "Ciclos"
        ' 
        ' lst_Valor
        ' 
        lst_Valor.FormattingEnabled = True
        lst_Valor.ItemHeight = 15
        lst_Valor.Location = New Point(81, 117)
        lst_Valor.Name = "lst_Valor"
        lst_Valor.Size = New Size(120, 154)
        lst_Valor.TabIndex = 1
        ' 
        ' btn_For1
        ' 
        btn_For1.Location = New Point(235, 121)
        btn_For1.Name = "btn_For1"
        btn_For1.Size = New Size(75, 23)
        btn_For1.TabIndex = 2
        btn_For1.Text = "For1"
        btn_For1.UseVisualStyleBackColor = True
        ' 
        ' btn_For2
        ' 
        btn_For2.Location = New Point(235, 162)
        btn_For2.Name = "btn_For2"
        btn_For2.Size = New Size(75, 23)
        btn_For2.TabIndex = 3
        btn_For2.Text = "For 2"
        btn_For2.UseVisualStyleBackColor = True
        ' 
        ' btn_For3
        ' 
        btn_For3.Location = New Point(342, 122)
        btn_For3.Name = "btn_For3"
        btn_For3.Size = New Size(75, 23)
        btn_For3.TabIndex = 4
        btn_For3.Text = "For 10a1"
        btn_For3.UseVisualStyleBackColor = True
        ' 
        ' btn_Limpiar
        ' 
        btn_Limpiar.Location = New Point(88, 73)
        btn_Limpiar.Name = "btn_Limpiar"
        btn_Limpiar.Size = New Size(75, 23)
        btn_Limpiar.TabIndex = 5
        btn_Limpiar.Text = "Limpiar"
        btn_Limpiar.UseVisualStyleBackColor = True
        ' 
        ' btn_While1
        ' 
        btn_While1.Location = New Point(235, 208)
        btn_While1.Name = "btn_While1"
        btn_While1.Size = New Size(75, 23)
        btn_While1.TabIndex = 6
        btn_While1.Text = "While 1"
        btn_While1.UseVisualStyleBackColor = True
        ' 
        ' btn_While2
        ' 
        btn_While2.Location = New Point(235, 248)
        btn_While2.Name = "btn_While2"
        btn_While2.Size = New Size(75, 23)
        btn_While2.TabIndex = 7
        btn_While2.Text = "While 2"
        btn_While2.UseVisualStyleBackColor = True
        ' 
        ' btn_While3
        ' 
        btn_While3.Location = New Point(345, 208)
        btn_While3.Name = "btn_While3"
        btn_While3.Size = New Size(75, 23)
        btn_While3.TabIndex = 8
        btn_While3.Text = "While 3"
        btn_While3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(345, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "For 3"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Btn_While4
        ' 
        Btn_While4.Location = New Point(342, 248)
        Btn_While4.Name = "Btn_While4"
        Btn_While4.Size = New Size(75, 23)
        Btn_While4.TabIndex = 10
        Btn_While4.Text = "While 4"
        Btn_While4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_While4)
        Controls.Add(Button1)
        Controls.Add(btn_While3)
        Controls.Add(btn_While2)
        Controls.Add(btn_While1)
        Controls.Add(btn_Limpiar)
        Controls.Add(btn_For3)
        Controls.Add(btn_For2)
        Controls.Add(btn_For1)
        Controls.Add(lst_Valor)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lst_Valor As ListBox
    Friend WithEvents btn_For1 As Button
    Friend WithEvents btn_For2 As Button
    Friend WithEvents btn_For3 As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_While1 As Button
    Friend WithEvents btn_While2 As Button
    Friend WithEvents btn_While3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_While4 As Button
End Class
