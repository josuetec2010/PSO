<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboUnidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barEspacioUsado = New System.Windows.Forms.ProgressBar()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboUnidades
        '
        Me.cboUnidades.FormattingEnabled = True
        Me.cboUnidades.Location = New System.Drawing.Point(298, 68)
        Me.cboUnidades.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.Size = New System.Drawing.Size(310, 37)
        Me.cboUnidades.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unidades"
        '
        'barEspacioUsado
        '
        Me.barEspacioUsado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barEspacioUsado.Location = New System.Drawing.Point(0, 186)
        Me.barEspacioUsado.Name = "barEspacioUsado"
        Me.barEspacioUsado.Size = New System.Drawing.Size(899, 15)
        Me.barEspacioUsado.TabIndex = 2
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRefrescar.Location = New System.Drawing.Point(617, 66)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(169, 37)
        Me.btnRefrescar.TabIndex = 3
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 201)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.barEspacioUsado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUnidades)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboUnidades As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents barEspacioUsado As ProgressBar
    Friend WithEvents btnRefrescar As Button
End Class
