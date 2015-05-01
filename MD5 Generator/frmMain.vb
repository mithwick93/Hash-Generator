Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Public Class frmMain

#Region " Functions "
	Delegate Sub get_md5_Delegate(ByVal fileName As String)
	Delegate Sub get_sha1_Delegate(ByVal fileName As String)
	Delegate Sub get_sha256_Delegate(ByVal fileName As String)


	Private Sub disableUI()
		Me.Cursor = Cursors.WaitCursor
		lblMD5.Enabled = False
		lblSHA1.Enabled = False
		lblSHA256.Enabled = False
		txtHashMD5.Text = "Calculating ,Please wait ...."
		txtHashSHA1.Text = ""
		txtHashSHA256.Text = ""
		btnGenerate.Enabled = False
		txtFile.Enabled = False
		txtHashMD5.Enabled = False
		txtHashSHA1.Enabled = False
		txtHashSHA256.Enabled = False
	End Sub

	Private Sub enableUI()
		Me.Cursor = Cursors.Default
		lblMD5.Enabled = True
		lblSHA1.Enabled = True
		lblSHA256.Enabled = True
		btnGenerate.Enabled = True
		txtFile.Enabled = True
		txtHashMD5.Enabled = True
		txtHashSHA1.Enabled = True
		txtHashSHA256.Enabled = True
	End Sub

	Private Sub openFile()
		openFileDialog.Filter = "All Files (*.*)|*.*"
		If (openFileDialog.ShowDialog() = DialogResult.OK) Then
			txtFile.Text = openFileDialog.FileName
		Else
			Exit Sub
		End If
		If openFileDialog.FileName = "" Then Exit Sub
		disableUI()

		Dim threadGetHash_md5 As get_md5_Delegate = AddressOf get_md5
		threadGetHash_md5.BeginInvoke(openFileDialog.FileName.ToString, Nothing, Nothing)

		Dim threadGetHash_sha1 As get_sha1_Delegate = AddressOf get_sha1
		threadGetHash_sha1.BeginInvoke(openFileDialog.FileName.ToString, Nothing, Nothing)

		Dim threadGetHash_sha256 As get_sha256_Delegate = AddressOf get_sha256
		threadGetHash_sha256.BeginInvoke(openFileDialog.FileName.ToString, Nothing, Nothing)
	End Sub

	Private Sub get_md5(ByVal fileName As String)
		Dim hashMD5 = MD5.Create	
		Dim hashValueMD5() As Byte
		Dim fileStream As FileStream = File.OpenRead(fileName)
		fileStream.Position = 0
		hashValueMD5 = hashMD5.ComputeHash(fileStream)
		fileStream.Close()
		If Me.InvokeRequired Then
			Me.Invoke(New get_md5_Delegate(AddressOf get_md5), fileName)
		Else
			txtHashMD5.Text = byteArrayToString(hashValueMD5)
			enableUI()
		End If
	End Sub

	Private Sub get_sha1(ByVal fileName As String)
		Dim hashSHA1 = SHA1.Create()
		Dim hashValueSHA1() As Byte
		Dim fileStream As FileStream = File.OpenRead(fileName)
		fileStream.Position = 0
		hashValueSHA1 = hashSHA1.ComputeHash(fileStream)
		fileStream.Close()
		If Me.InvokeRequired Then
			Me.Invoke(New get_sha1_Delegate(AddressOf get_sha1), fileName)
		Else
			txtHashSHA1.Text = byteArrayToString(hashValueSHA1)
			enableUI()
		End If
	End Sub

	Private Sub get_sha256(ByVal fileName As String)
		Dim hashSHA256 = SHA256.Create()
		Dim hashValueSHA256() As Byte
		Dim fileStream As FileStream = File.OpenRead(fileName)
		fileStream.Position = 0
		hashValueSHA256 = hashSHA256.ComputeHash(fileStream)
		fileStream.Close()

		If Me.InvokeRequired Then
			Me.Invoke(New get_sha256_Delegate(AddressOf get_sha256), fileName)
		Else
			txtHashSHA256.Text = byteArrayToString(hashValueSHA256)
			enableUI()
		End If
	End Sub

	Public Function byteArrayToString(ByVal array() As Byte) As String
		Dim hexValue As String = ""
		Dim i As Integer
		For i = 0 To array.Length - 1
			hexValue += array(i).ToString("X2")
		Next i
		Return hexValue.ToLower
	End Function

	Private Function getPlatformBit() As String
		If IntPtr.Size > 4 Then
			Return "x64"
		End If
		Return "x86"
	End Function
#End Region

#Region " Form "
	Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Me.Icon = My.Resources.FileHash
		Me.Text = Me.Text + " " + getPlatformBit()
	End Sub
#End Region

#Region " GUI "
	Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
		openFile()
	End Sub

	Private Sub txtFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile.DoubleClick
		openFile()
	End Sub
#End Region

End Class