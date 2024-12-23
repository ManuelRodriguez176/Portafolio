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
        lbl_Titulo = New Label()
        btn_Crear = New Button()
        txt_Creado = New TextBox()
        btn_Varios = New Button()
        SuspendLayout()
        ' 
        ' lbl_Titulo
        ' 
        lbl_Titulo.AutoSize = True
        lbl_Titulo.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Titulo.Location = New Point(287, 36)
        lbl_Titulo.Name = "lbl_Titulo"
        lbl_Titulo.Size = New Size(183, 37)
        lbl_Titulo.TabIndex = 0
        lbl_Titulo.Text = "Crear Botones"
        ' 
        ' btn_Crear
        ' 
        btn_Crear.Location = New Point(120, 67)
        btn_Crear.Name = "btn_Crear"
        btn_Crear.Size = New Size(75, 23)
        btn_Crear.TabIndex = 1
        btn_Crear.Text = "Crear"
        btn_Crear.UseVisualStyleBackColor = True
        ' 
        ' txt_Creado
        ' 
        txt_Creado.Location = New Point(120, 110)
        txt_Creado.Name = "txt_Creado"
        txt_Creado.Size = New Size(100, 23)
        txt_Creado.TabIndex = 2
        ' 
        ' btn_Varios
        ' 
        btn_Varios.Location = New Point(120, 206)
        btn_Varios.Name = "btn_Varios"
        btn_Varios.Size = New Size(75, 23)
        btn_Varios.TabIndex = 3
        btn_Varios.Text = "Varios"
        btn_Varios.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_Varios)
        Controls.Add(txt_Creado)
        Controls.Add(btn_Crear)
        Controls.Add(lbl_Titulo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents btn_Crear As Button
    Friend WithEvents txt_Creado As TextBox
    Friend WithEvents btn_Varios As Button
End Class
