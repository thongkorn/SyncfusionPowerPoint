<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPowerPoint
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
        Me.components = New System.ComponentModel.Container()
        Dim MessageBoxSettings2 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings()
        Dim PdfViewerPrinterSettings2 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPowerPoint))
        Dim TextSearchSettings2 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Me.btnPPTtoImage = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnExit = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnPPTtoPDF = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.PdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.TabPageAdv2.SuspendLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPPTtoImage
        '
        Me.btnPPTtoImage.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnPPTtoImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnPPTtoImage.BeforeTouchSize = New System.Drawing.Size(167, 29)
        Me.btnPPTtoImage.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnPPTtoImage.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnPPTtoImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPPTtoImage.ForeColor = System.Drawing.Color.White
        Me.btnPPTtoImage.KeepFocusRectangle = False
        Me.btnPPTtoImage.Location = New System.Drawing.Point(288, 36)
        Me.btnPPTtoImage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPPTtoImage.Name = "btnPPTtoImage"
        Me.btnPPTtoImage.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnPPTtoImage.Size = New System.Drawing.Size(167, 29)
        Me.btnPPTtoImage.TabIndex = 3
        Me.btnPPTtoImage.Text = "PowerPoint to Images"
        Me.btnPPTtoImage.ThemeName = "Metro"
        Me.btnPPTtoImage.UseVisualStyle = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnExit.BeforeTouchSize = New System.Drawing.Size(167, 29)
        Me.btnExit.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnExit.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.KeepFocusRectangle = False
        Me.btnExit.Location = New System.Drawing.Point(928, 36)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.MetroColor = System.Drawing.Color.Coral
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnExit.Size = New System.Drawing.Size(167, 29)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.ThemeName = "Metro"
        Me.btnExit.UseVisualStyle = True
        '
        'btnPPTtoPDF
        '
        Me.btnPPTtoPDF.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnPPTtoPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnPPTtoPDF.BeforeTouchSize = New System.Drawing.Size(167, 29)
        Me.btnPPTtoPDF.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnPPTtoPDF.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnPPTtoPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPPTtoPDF.ForeColor = System.Drawing.Color.White
        Me.btnPPTtoPDF.KeepFocusRectangle = False
        Me.btnPPTtoPDF.Location = New System.Drawing.Point(115, 36)
        Me.btnPPTtoPDF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPPTtoPDF.Name = "btnPPTtoPDF"
        Me.btnPPTtoPDF.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnPPTtoPDF.Size = New System.Drawing.Size(167, 29)
        Me.btnPPTtoPDF.TabIndex = 2
        Me.btnPPTtoPDF.Text = "PowerPoint to PDF"
        Me.btnPPTtoPDF.ThemeName = "Metro"
        Me.btnPPTtoPDF.UseVisualStyle = True
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.Controls.Add(Me.PdfViewerControl1)
        Me.TabPageAdv2.Image = Nothing
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 28)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(1092, 535)
        Me.TabPageAdv2.TabIndex = 4
        Me.TabPageAdv2.Text = "View PDF"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'PdfViewerControl1
        '
        Me.PdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
        Me.PdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewerControl1.EnableContextMenu = True
        Me.PdfViewerControl1.EnableNotificationBar = True
        Me.PdfViewerControl1.HorizontalScrollOffset = 0
        Me.PdfViewerControl1.IsBookmarkEnabled = True
        Me.PdfViewerControl1.IsTextSearchEnabled = True
        Me.PdfViewerControl1.IsTextSelectionEnabled = True
        Me.PdfViewerControl1.Location = New System.Drawing.Point(0, 0)
        MessageBoxSettings2.EnableNotification = True
        Me.PdfViewerControl1.MessageBoxSettings = MessageBoxSettings2
        Me.PdfViewerControl1.MinimumZoomPercentage = 50
        Me.PdfViewerControl1.Name = "PdfViewerControl1"
        Me.PdfViewerControl1.PageBorderThickness = 1
        PdfViewerPrinterSettings2.Copies = 1
        PdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings2.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings2.PrintLocation"), System.Drawing.PointF)
        PdfViewerPrinterSettings2.ShowPrintStatusDialog = True
        Me.PdfViewerControl1.PrinterSettings = PdfViewerPrinterSettings2
        Me.PdfViewerControl1.ReferencePath = Nothing
        Me.PdfViewerControl1.ScrollDisplacementValue = 0
        Me.PdfViewerControl1.ShowHorizontalScrollBar = True
        Me.PdfViewerControl1.ShowToolBar = True
        Me.PdfViewerControl1.ShowVerticalScrollBar = True
        Me.PdfViewerControl1.Size = New System.Drawing.Size(1092, 535)
        Me.PdfViewerControl1.SpaceBetweenPages = 8
        Me.PdfViewerControl1.TabIndex = 0
        Me.PdfViewerControl1.Text = "PdfViewerControl1"
        TextSearchSettings2.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings2.HighlightAllInstance = True
        TextSearchSettings2.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PdfViewerControl1.TextSearchSettings = TextSearchSettings2
        Me.PdfViewerControl1.ThemeName = "Default"
        Me.PdfViewerControl1.VerticalScrollOffset = 0
        Me.PdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.[Default]
        Me.PdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(1095, 565)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.FocusOnTabClick = False
        Me.TabControlAdv1.Location = New System.Drawing.Point(2, 73)
        Me.TabControlAdv1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.Size = New System.Drawing.Size(1095, 565)
        Me.TabControlAdv1.TabIndex = 5
        Me.TabControlAdv1.ThemeName = "TabRenderer3D"
        Me.TabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = CType(resources.GetObject("resource.DisabledNextPageImage"), System.Drawing.Image)
        Me.TabControlAdv1.ThemeStyle.PrimitiveButtonStyle.NextPageImage = CType(resources.GetObject("resource.NextPageImage"), System.Drawing.Image)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PowerPoint File:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.Location = New System.Drawing.Point(1072, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(25, 25)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(115, 6)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(957, 23)
        Me.txtFileName.TabIndex = 1
        Me.txtFileName.TabStop = False
        '
        'frmPowerPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 639)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Controls.Add(Me.btnPPTtoPDF)
        Me.Controls.Add(Me.btnPPTtoImage)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1114, 678)
        Me.Name = "frmPowerPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PowerPoint with Syncfusion - coDe bY: Thongkorn Tubtimkrob"
        Me.TabPageAdv2.ResumeLayout(False)
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnPPTtoImage As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnExit As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnPPTtoPDF As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents PdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
End Class
