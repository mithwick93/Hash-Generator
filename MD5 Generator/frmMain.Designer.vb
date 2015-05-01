<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnGenerate = New System.Windows.Forms.Button()
		Me.txtFile = New System.Windows.Forms.TextBox()
		Me.lblMD5 = New System.Windows.Forms.Label()
		Me.txtHashMD5 = New System.Windows.Forms.TextBox()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.txtHashSHA1 = New System.Windows.Forms.TextBox()
		Me.lblSHA1 = New System.Windows.Forms.Label()
		Me.txtHashSHA256 = New System.Windows.Forms.TextBox()
		Me.lblSHA256 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnGenerate
		'
		Me.btnGenerate.Location = New System.Drawing.Point(407, 16)
		Me.btnGenerate.Name = "btnGenerate"
		Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
		Me.btnGenerate.TabIndex = 0
		Me.btnGenerate.Text = "Generate"
		Me.btnGenerate.UseVisualStyleBackColor = True
		'
		'txtFile
		'
		Me.txtFile.Location = New System.Drawing.Point(12, 18)
		Me.txtFile.Name = "txtFile"
		Me.txtFile.Size = New System.Drawing.Size(378, 20)
		Me.txtFile.TabIndex = 1
		'
		'lblMD5
		'
		Me.lblMD5.AutoSize = True
		Me.lblMD5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMD5.Location = New System.Drawing.Point(12, 66)
		Me.lblMD5.Name = "lblMD5"
		Me.lblMD5.Size = New System.Drawing.Size(54, 18)
		Me.lblMD5.TabIndex = 2
		Me.lblMD5.Text = "MD5 : "
		'
		'txtHashMD5
		'
		Me.txtHashMD5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHashMD5.Location = New System.Drawing.Point(86, 63)
		Me.txtHashMD5.Name = "txtHashMD5"
		Me.txtHashMD5.ReadOnly = True
		Me.txtHashMD5.Size = New System.Drawing.Size(393, 26)
		Me.txtHashMD5.TabIndex = 3
		'
		'openFileDialog
		'
		Me.openFileDialog.Title = "Open File"
		'
		'txtHashSHA1
		'
		Me.txtHashSHA1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHashSHA1.Location = New System.Drawing.Point(86, 95)
		Me.txtHashSHA1.Name = "txtHashSHA1"
		Me.txtHashSHA1.ReadOnly = True
		Me.txtHashSHA1.Size = New System.Drawing.Size(393, 26)
		Me.txtHashSHA1.TabIndex = 5
		'
		'lblSHA1
		'
		Me.lblSHA1.AutoSize = True
		Me.lblSHA1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSHA1.Location = New System.Drawing.Point(12, 98)
		Me.lblSHA1.Name = "lblSHA1"
		Me.lblSHA1.Size = New System.Drawing.Size(58, 18)
		Me.lblSHA1.TabIndex = 4
		Me.lblSHA1.Text = "SHA1 :"
		'
		'txtHashSHA256
		'
		Me.txtHashSHA256.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHashSHA256.Location = New System.Drawing.Point(86, 127)
		Me.txtHashSHA256.Name = "txtHashSHA256"
		Me.txtHashSHA256.ReadOnly = True
		Me.txtHashSHA256.Size = New System.Drawing.Size(393, 26)
		Me.txtHashSHA256.TabIndex = 7
		'
		'lblSHA256
		'
		Me.lblSHA256.AutoSize = True
		Me.lblSHA256.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSHA256.Location = New System.Drawing.Point(12, 130)
		Me.lblSHA256.Name = "lblSHA256"
		Me.lblSHA256.Size = New System.Drawing.Size(76, 18)
		Me.lblSHA256.TabIndex = 6
		Me.lblSHA256.Text = "SHA256 :"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(484, 197)
		Me.Controls.Add(Me.txtHashSHA256)
		Me.Controls.Add(Me.lblSHA256)
		Me.Controls.Add(Me.txtHashSHA1)
		Me.Controls.Add(Me.lblSHA1)
		Me.Controls.Add(Me.txtHashMD5)
		Me.Controls.Add(Me.lblMD5)
		Me.Controls.Add(Me.txtFile)
		Me.Controls.Add(Me.btnGenerate)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hash Generator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnGenerate As System.Windows.Forms.Button
	Friend WithEvents txtFile As System.Windows.Forms.TextBox
	Friend WithEvents lblMD5 As System.Windows.Forms.Label
	Friend WithEvents txtHashMD5 As System.Windows.Forms.TextBox
	Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
	Friend WithEvents txtHashSHA1 As System.Windows.Forms.TextBox
	Friend WithEvents lblSHA1 As System.Windows.Forms.Label
	Friend WithEvents txtHashSHA256 As System.Windows.Forms.TextBox
	Friend WithEvents lblSHA256 As System.Windows.Forms.Label

End Class
