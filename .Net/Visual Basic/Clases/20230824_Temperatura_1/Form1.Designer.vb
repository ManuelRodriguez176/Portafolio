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
        lbl_C = New Label()
        txt_C = New TextBox()
        lbl_F = New Label()
        txt_F = New TextBox()
        btn_CF = New Button()
        btn_FC = New Button()
        rb_C = New RadioButton()
        rb_F = New RadioButton()
        btn_Calcular = New Button()
        hsb_Valor = New HScrollBar()
        vsb_Valor = New VScrollBar()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 15)
        Label1.TabIndex = 0
        Label1.Text = "Convertir Temperatura"
        ' 
        ' lbl_C
        ' 
        lbl_C.AutoSize = True
        lbl_C.Location = New Point(159, 83)
        lbl_C.Name = "lbl_C"
        lbl_C.Size = New Size(20, 15)
        lbl_C.TabIndex = 1
        lbl_C.Text = "°C"
        ' 
        ' txt_C
        ' 
        txt_C.Location = New Point(218, 76)
        txt_C.Name = "txt_C"
        txt_C.Size = New Size(100, 23)
        txt_C.TabIndex = 2
        ' 
        ' lbl_F
        ' 
        lbl_F.AutoSize = True
        lbl_F.Location = New Point(164, 133)
        lbl_F.Name = "lbl_F"
        lbl_F.Size = New Size(18, 15)
        lbl_F.TabIndex = 3
        lbl_F.Text = "°F"
        ' 
        ' txt_F
        ' 
        txt_F.Location = New Point(218, 125)
        txt_F.Name = "txt_F"
        txt_F.Size = New Size(100, 23)
        txt_F.TabIndex = 4
        ' 
        ' btn_CF
        ' 
        btn_CF.Location = New Point(389, 75)
        btn_CF.Name = "btn_CF"
        btn_CF.Size = New Size(75, 23)
        btn_CF.TabIndex = 5
        btn_CF.Text = "°C a °F"
        btn_CF.UseVisualStyleBackColor = True
        ' 
        ' btn_FC
        ' 
        btn_FC.Location = New Point(389, 124)
        btn_FC.Name = "btn_FC"
        btn_FC.Size = New Size(75, 23)
        btn_FC.TabIndex = 6
        btn_FC.Text = "°F a °C"
        btn_FC.UseVisualStyleBackColor = True
        ' 
        ' rb_C
        ' 
        rb_C.AutoSize = True
        rb_C.Checked = True
        rb_C.Location = New Point(104, 83)
        rb_C.Name = "rb_C"
        rb_C.Size = New Size(38, 19)
        rb_C.TabIndex = 7
        rb_C.TabStop = True
        rb_C.Text = "°C"
        rb_C.UseVisualStyleBackColor = True
        ' 
        ' rb_F
        ' 
        rb_F.AutoSize = True
        rb_F.Location = New Point(106, 131)
        rb_F.Name = "rb_F"
        rb_F.Size = New Size(36, 19)
        rb_F.TabIndex = 8
        rb_F.TabStop = True
        rb_F.Text = "°F"
        rb_F.UseVisualStyleBackColor = True
        ' 
        ' btn_Calcular
        ' 
        btn_Calcular.Location = New Point(221, 188)
        btn_Calcular.Name = "btn_Calcular"
        btn_Calcular.Size = New Size(75, 23)
        btn_Calcular.TabIndex = 9
        btn_Calcular.Text = "Calcular"
        btn_Calcular.UseVisualStyleBackColor = True
        ' 
        ' hsb_Valor
        ' 
        hsb_Valor.LargeChange = 1
        hsb_Valor.Location = New Point(134, 247)
        hsb_Valor.Name = "hsb_Valor"
        hsb_Valor.Size = New Size(307, 34)
        hsb_Valor.TabIndex = 10
        ' 
        ' vsb_Valor
        ' 
        vsb_Valor.LargeChange = 1
        vsb_Valor.Location = New Point(537, 75)
        vsb_Valor.Maximum = 0
        vsb_Valor.Minimum = -100
        vsb_Valor.Name = "vsb_Valor"
        vsb_Valor.Size = New Size(17, 206)
        vsb_Valor.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(569, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 12
        Label2.Text = "100"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(573, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 13
        Label3.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(vsb_Valor)
        Controls.Add(hsb_Valor)
        Controls.Add(btn_Calcular)
        Controls.Add(rb_F)
        Controls.Add(rb_C)
        Controls.Add(btn_FC)
        Controls.Add(btn_CF)
        Controls.Add(txt_F)
        Controls.Add(lbl_F)
        Controls.Add(txt_C)
        Controls.Add(lbl_C)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_C As Label
    Friend WithEvents txt_C As TextBox
    Friend WithEvents lbl_F As Label
    Friend WithEvents txt_F As TextBox
    Friend WithEvents btn_CF As Button
    Friend WithEvents btn_FC As Button
    Friend WithEvents rb_C As RadioButton
    Friend WithEvents rb_F As RadioButton
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents hsb_Valor As HScrollBar
    Friend WithEvents vsb_Valor As VScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
