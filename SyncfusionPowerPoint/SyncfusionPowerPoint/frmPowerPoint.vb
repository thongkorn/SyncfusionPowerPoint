#Region "About"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com/webboard
' /
' / Purpose: PowerPoint with Syncfusion Community License Free.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports Syncfusion.Pdf
Imports Syncfusion.Presentation
Imports Syncfusion.PresentationToPdfConverter
Imports Syncfusion.OfficeChartToImageConverter
Imports Syncfusion.Windows.Forms

Public Class frmPowerPoint
    '// Project Path 
    Dim strPath As String = MyPath(Application.StartupPath)
    '// Get the PowerPoint Filename and save it same name to PDF.
    Dim PptFileName As String()

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(ByVal AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

    ' / S T A R T ...................... H E R E
    Private Sub frmSpreadExcel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Convert PowerPoint to PDF.
    ' / https://www.syncfusion.com/kb/9644/how-to-convert-powerpoint-to-pdf-using-c-and-vb-net
    ' / --------------------------------------------------------------------------------
    Private Sub btnbtnPPTtoPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnPPTtoPDF.Click
        If txtFileName.Text.Trim.Length = 0 Then
            MessageBox.Show("You did not load the PowerPoint file.", "Report status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Try
            '/ Opens a PowerPoint Presentation
            Dim presentationDocument As IPresentation = Presentation.Open(txtFileName.Text)
            '/ Converts the PowerPoint Presentation into PDF document
            Dim pdfDocument As PdfDocument = PresentationToPdfConverter.Convert(presentationDocument)
            '/ Saves the PDF document ... PptFileName(0) = "Syncfusion Presentation" (Get Only Filename from PowerPoint)
            pdfDocument.Save(strPath + PptFileName(0) + ".pdf")
            '/ Closes the Presentation
            presentationDocument.Close()
            '/ Show PDF on PDFViewerControl of Syncfusion.
            Me.PdfViewerControl1.Load(strPath + PptFileName(0) + ".pdf", "")
            '/ This will open the PDF file so, the result will be seen in default PDF viewer.
            'System.Diagnostics.Process.Start(strPath + PptFileName(0) + ".pdf")
            pdfDocument.Dispose()
            presentationDocument.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Convert PowerPoint File to Image Files.
    ' / https://help.syncfusion.com/file-formats/presentation/presentation-to-image
    ' / --------------------------------------------------------------------------------
    Private Sub btnbtnPPTtoImage_Click(sender As System.Object, e As System.EventArgs) Handles btnPPTtoImage.Click
        If txtFileName.Text.Trim.Length = 0 Then
            MessageBox.Show("You did not load the PowerPoint file.", "Report status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        '/ Create a folder "Image", if it doesn't exist.
        If Not System.IO.Directory.Exists(strPath & "Image") Then System.IO.Directory.CreateDirectory(strPath & "Image")
        '/
        Try
            '/ Loads the PowerPoint Presentation.
            Dim pptxDoc As IPresentation = Presentation.Open(txtFileName.Text)
            '/ Creates instance of ChartToImageConverter.
            pptxDoc.ChartToImageConverter = New ChartToImageConverter()
            '/ Sets the scaling mode as best.
            pptxDoc.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best
            '/ Converts entire Presentation to images.
            Dim images As Image() = pptxDoc.RenderAsImages(Syncfusion.Drawing.ImageType.Metafile)
            '/
            '/ Set page numbers for each slide.
            Dim pg As Integer = 0
            For Each image As Image In images
                '/ Saves the image.
                image.Save(strPath & "Image\" & (pg + 1) & ".png")
                pg += 1
            Next
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016
            MessageBoxAdv.MessageFont = New Font("Tahoma", 12, FontStyle.Regular)
            MessageBoxAdv.Show("Convert PowerPoint to Images complete.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '/ Open Folder Image.
            Process.Start(strPath & "Image")
            pptxDoc.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Browse PowerPoint File.
    ' / --------------------------------------------------------------------------------
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        '/ Declare Open File Dialog @ Run Time.
        Dim dlgOpenFile As OpenFileDialog = New OpenFileDialog()
        Try
            ' / Initialize Open File Dialog.
            With dlgOpenFile
                .InitialDirectory = strPath
                .Title = "Select Presentation PowerPoint"
                .Filter = "PowerPoint Files (*.pptx;*.ppt)|*.pptx;*ppt"
                .FilterIndex = 1
                .RestoreDirectory = True
            End With
            '/ If the OK button is selected.
            If dlgOpenFile.ShowDialog() = DialogResult.OK Then
                '// Ex. "Syncfusion Presentation.pptx"
                txtFileName.Text = dlgOpenFile.FileName
                '// PptFileName(0) = "Syncfusion Presentation"
                '// PptFileName(1) = "pptx"
                PptFileName = Split(dlgOpenFile.SafeFileName, ".")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub txtFileName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFileName.KeyPress
        '/ Protect key press.
        e.Handled = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSpreadExcel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class