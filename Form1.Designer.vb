<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.runGameButton = New System.Windows.Forms.Button()
        Me.textbox_l2exec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textbox_l2target = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_l2source = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label_l2path = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(141, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Evil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(197, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 37)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Blades"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.runGameButton)
        Me.Panel1.Controls.Add(Me.textbox_l2exec)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.textbox_l2target)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.textbox_l2source)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.label_l2path)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 204)
        Me.Panel1.TabIndex = 12
        '
        'runGameButton
        '
        Me.runGameButton.Location = New System.Drawing.Point(248, 168)
        Me.runGameButton.Name = "runGameButton"
        Me.runGameButton.Size = New System.Drawing.Size(192, 23)
        Me.runGameButton.TabIndex = 19
        Me.runGameButton.Text = "Сохранить и запустить игру"
        Me.runGameButton.UseVisualStyleBackColor = True
        '
        'textbox_l2exec
        '
        Me.textbox_l2exec.Location = New System.Drawing.Point(248, 122)
        Me.textbox_l2exec.Name = "textbox_l2exec"
        Me.textbox_l2exec.Size = New System.Drawing.Size(192, 20)
        Me.textbox_l2exec.TabIndex = 18
        Me.textbox_l2exec.Text = "evilblades.exe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Имя файла для запуска Updater'а :"
        '
        'textbox_l2target
        '
        Me.textbox_l2target.Location = New System.Drawing.Point(248, 92)
        Me.textbox_l2target.Name = "textbox_l2target"
        Me.textbox_l2target.Size = New System.Drawing.Size(192, 20)
        Me.textbox_l2target.TabIndex = 16
        Me.textbox_l2target.Text = "evilblades"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Название папки ""system"" :"
        '
        'textbox_l2source
        '
        Me.textbox_l2source.Location = New System.Drawing.Point(248, 62)
        Me.textbox_l2source.Name = "textbox_l2source"
        Me.textbox_l2source.Size = New System.Drawing.Size(192, 20)
        Me.textbox_l2source.TabIndex = 14
        Me.textbox_l2source.Text = "!chat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Название папки с новыми файлами :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Изменить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label_l2path
        '
        Me.label_l2path.AutoSize = True
        Me.label_l2path.BackColor = System.Drawing.Color.Transparent
        Me.label_l2path.Location = New System.Drawing.Point(249, 15)
        Me.label_l2path.Name = "label_l2path"
        Me.label_l2path.Size = New System.Drawing.Size(169, 13)
        Me.label_l2path.TabIndex = 11
        Me.label_l2path.Text = "C:\Programm Files\NCsoft\lineage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Путь к папке Lineage II : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 292)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 331)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(464, 331)
        Me.Name = "Form1"
        Me.Text = "Lineage2_UpdaterFix"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents runGameButton As System.Windows.Forms.Button
    Friend WithEvents textbox_l2exec As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textbox_l2target As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textbox_l2source As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents label_l2path As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
