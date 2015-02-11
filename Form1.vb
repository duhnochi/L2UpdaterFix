Public Class Form1

    Dim lineage_folder As String
    Dim lineage_source As String
    Dim lineage_target As String
    Dim lineage_execut As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadConfiguration()
        checkConfiguration(lineage_folder, lineage_source, lineage_target, lineage_execut)

        label_l2path.Text = lineage_folder
        textbox_l2source.Text = lineage_source
        textbox_l2target.Text = lineage_target
        textbox_l2exec.Text = lineage_execut
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim select_path_dialog_result = FolderBrowserDialog1.ShowDialog()

        If (select_path_dialog_result = DialogResult.OK) Then
            lineage_folder = FolderBrowserDialog1.SelectedPath
            label_l2path.Text = lineage_folder
        End If

    End Sub

    Private Sub runGameButton_Click(sender As Object, e As EventArgs) Handles runGameButton.Click

        lineage_execut = textbox_l2exec.Text
        lineage_source = textbox_l2source.Text
        lineage_target = textbox_l2target.Text

        Dim l2_process As Process
        Try

            l2_process = System.Diagnostics.Process.Start(lineage_folder + "\" + lineage_execut)
            Do While Not l2_process.HasExited
                ' ничего не делаем 
            Loop
            l2_process.WaitForExit()

            My.Computer.FileSystem.CopyDirectory(lineage_folder + "\" + lineage_source, lineage_folder + "\" + lineage_target, True)

        Catch ex As Exception
            MessageBox.Show("Не могу запустить Lineage по пути " + lineage_folder + "\" + lineage_execut + " или скопировать файлы с путями: " + lineage_folder + "\" + lineage_source + " " + lineage_folder + "\" + lineage_target, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    '''     Check, if given path is valid (file or folder exists)
    ''' </summary>
    ''' <param name="path">Path to file or folder</param>
    ''' <returns>True if path is valid, False otherwise</returns>
    ''' <remarks></remarks>
    Function isValid(ByRef path As String)
        If (Not System.IO.Directory.Exists(path) And Not System.IO.File.Exists(path)) Then
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    '''     Checks if programm have saved configuration.
    '''     If have, then do validation of all paths, if any path is incorrect, then shows error message
    ''' </summary>
    ''' <param name="l2_path">Path to Lineage II Folder</param>
    ''' <param name="l2_source">Name of Lineage II new files folder</param>
    ''' <param name="l2_target">Name of Lineage II originals files folder</param>
    ''' <param name="l2_executable">Name of executable file, for run Lineage II game</param>
    ''' <remarks></remarks>
    Private Sub checkConfiguration(ByRef l2_path As String, ByRef l2_source As String, ByRef l2_target As String, ByRef l2_executable As String)
        Dim saved_configs As Microsoft.Win32.RegistryKey
        saved_configs = My.Computer.Registry.CurrentUser.OpenSubKey("Lineage2ChatFix", True)

        If saved_configs Is Nothing Then
            Return
        End If

        If (Not (isValid(l2_path) And isValid(l2_path + "\" + l2_source) And isValid(l2_path + "\" + l2_target) And isValid(l2_path + "\" + l2_executable))) Then
            MessageBox.Show("Не все пути корректны. Произведите повторную настройку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''' <summary>
    '''     Loads saved configuration if it exists
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub loadConfiguration()
        Try
            lineage_folder = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineagePath", "C:\lineage")
            lineage_source = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineageSource", "!chat")
            lineage_target = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineageTarget", "evilblades")
            lineage_execut = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineageExecutable", "evilblades.exe")
        Catch ex As Exception
            MessageBox.Show("Не могу получить права на сохранение. Запустите от имени администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    '''     Save configuration to registry in Lineage2ChatFix sub key
    ''' </summary>
    ''' <param name="l2_path"></param>
    ''' <param name="l2_source"></param>
    ''' <param name="l2_target"></param>
    ''' <param name="l2_executable"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function saveConfiguration(ByRef l2_path As String, ByRef l2_source As String, ByRef l2_target As String, ByRef l2_executable As String)

        If (Not (isValid(l2_path) And isValid(l2_path + "\" + l2_source) And isValid(l2_path + "\" + l2_target) And isValid(l2_path + "\" + l2_executable))) Then
            Return False
        End If

        Try
            My.Computer.Registry.CurrentUser.CreateSubKey("Lineage2ChatFix")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineagePath", l2_path)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineageSource", l2_source)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineageTarget", l2_target)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Lineage2ChatFix", "LineageExecutable", l2_executable)
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

End Class
