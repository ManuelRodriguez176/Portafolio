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
        Dim lbl_Superior As System.Windows.Forms.Label
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Inferior = New System.Windows.Forms.Label()
        Me.txt_Inferior = New System.Windows.Forms.TextBox()
        Me.txt_Superior = New System.Windows.Forms.TextBox()
        Me.lbl_Computadora = New System.Windows.Forms.Label()
        Me.txt_Computadora = New System.Windows.Forms.TextBox()
        Me.lbl_Intentos = New System.Windows.Forms.Label()
        Me.txt_Intentos = New System.Windows.Forms.TextBox()
        Me.btn_Alto = New System.Windows.Forms.Button()
        Me.btn_Bajo = New System.Windows.Forms.Button()
        Me.btn_Correcto = New System.Windows.Forms.Button()
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        lbl_Superior = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Superior
        '
        lbl_Superior.AutoSize = True
        lbl_Superior.Location = New System.Drawing.Point(305, 111)
        lbl_Superior.Name = "lbl_Superior"
        lbl_Superior.Size = New System.Drawing.Size(51, 15)
        lbl_Superior.TabIndex = 3
        lbl_Superior.Text = "Superior"
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(291, 34)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(278, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Computadora Adivina"
        '
        'lbl_Inferior
        '
        Me.lbl_Inferior.AutoSize = True
        Me.lbl_Inferior.Location = New System.Drawing.Point(108, 117)
        Me.lbl_Inferior.Name = "lbl_Inferior"
        Me.lbl_Inferior.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Inferior.TabIndex = 1
        Me.lbl_Inferior.Text = "Inferior"
        '
        'txt_Inferior
        '
        Me.txt_Inferior.Location = New System.Drawing.Point(159, 109)
        Me.txt_Inferior.Name = "txt_Inferior"
        Me.txt_Inferior.Size = New System.Drawing.Size(100, 23)
        Me.txt_Inferior.TabIndex = 2
        '
        'txt_Superior
        '
        Me.txt_Superior.Location = New System.Drawing.Point(400, 109)
        Me.txt_Superior.Name = "txt_Superior"
        Me.txt_Superior.Size = New System.Drawing.Size(100, 23)
        Me.txt_Superior.TabIndex = 4
        '
        'lbl_Computadora
        '
        Me.lbl_Computadora.AutoSize = True
        Me.lbl_Computadora.Location = New System.Drawing.Point(114, 164)
        Me.lbl_Computadora.Name = "lbl_Computadora"
        Me.lbl_Computadora.Size = New System.Drawing.Size(81, 15)
        Me.lbl_Computadora.TabIndex = 5
        Me.lbl_Computadora.Text = "Computadora"
        '
        'txt_Computadora
        '
        Me.txt_Computadora.Location = New System.Drawing.Point(234, 156)
        Me.txt_Computadora.Name = "txt_Computadora"
        Me.txt_Computadora.Size = New System.Drawing.Size(100, 23)
        Me.txt_Computadora.TabIndex = 6
        '
        'lbl_Intentos
        '
        Me.lbl_Intentos.AutoSize = True
        Me.lbl_Intentos.Location = New System.Drawing.Point(118, 211)
        Me.lbl_Intentos.Name = "lbl_Intentos"
        Me.lbl_Intentos.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Intentos.TabIndex = 7
        Me.lbl_Intentos.Text = "Intentos"
        '
        'txt_Intentos
        '
        Me.txt_Intentos.Location = New System.Drawing.Point(208, 203)
        Me.txt_Intentos.Name = "txt_Intentos"
        Me.txt_Intentos.Size = New System.Drawing.Size(100, 23)
        Me.txt_Intentos.TabIndex = 8
        '
        'btn_Alto
        '
        Me.btn_Alto.Location = New System.Drawing.Point(142, 260)
        Me.btn_Alto.Name = "btn_Alto"
        Me.btn_Alto.Size = New System.Drawing.Size(75, 23)
        Me.btn_Alto.TabIndex = 9
        Me.btn_Alto.Text = "Alto"
        Me.btn_Alto.UseVisualStyleBackColor = True
        '
        'btn_Bajo
        '
        Me.btn_Bajo.Location = New System.Drawing.Point(259, 260)
        Me.btn_Bajo.Name = "btn_Bajo"
        Me.btn_Bajo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Bajo.TabIndex = 10
        Me.btn_Bajo.Text = "Bajo"
        Me.btn_Bajo.UseVisualStyleBackColor = True
        '
        'btn_Correcto
        '
        Me.btn_Correcto.Location = New System.Drawing.Point(379, 261)
        Me.btn_Correcto.Name = "btn_Correcto"
        Me.btn_Correcto.Size = New System.Drawing.Size(75, 23)
        Me.btn_Correcto.TabIndex = 11
        Me.btn_Correcto.Text = "Correcto"
        Me.btn_Correcto.UseVisualStyleBackColor = True
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(379, 157)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 12
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.btn_Correcto)
        Me.Controls.Add(Me.btn_Bajo)
        Me.Controls.Add(Me.btn_Alto)
        Me.Controls.Add(Me.txt_Intentos)
        Me.Controls.Add(Me.lbl_Intentos)
        Me.Controls.Add(Me.txt_Computadora)
        Me.Controls.Add(Me.lbl_Computadora)
        Me.Controls.Add(Me.txt_Superior)
        Me.Controls.Add(lbl_Superior)
        Me.Controls.Add(Me.txt_Inferior)
        Me.Controls.Add(Me.lbl_Inferior)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Inferior As Label
    Friend WithEvents txt_Inferior As TextBox
    Friend WithEvents txt_Superior As TextBox
    Friend WithEvents lbl_Computadora As Label
    Friend WithEvents txt_Computadora As TextBox
    Friend WithEvents lbl_Intentos As Label
    Friend WithEvents txt_Intentos As TextBox
    Friend WithEvents btn_Alto As Button
    Friend WithEvents btn_Bajo As Button
    Friend WithEvents btn_Correcto As Button
    Friend WithEvents btn_Iniciar As Button
End Class
