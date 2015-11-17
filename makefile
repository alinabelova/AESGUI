all:
	mcs -out:AES.exe Program.cs MyAes.cs AesForm.Designer.cs AesForm.cs /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll