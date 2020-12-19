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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picPlanets = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYourWeight = New System.Windows.Forms.Label()
        Me.txtUserWeight = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblConvertedWeightValue = New System.Windows.Forms.Label()
        Me.lblConvertedWeight = New System.Windows.Forms.Label()
        Me.lblPlanetSelect = New System.Windows.Forms.Label()
        Me.radMars = New System.Windows.Forms.RadioButton()
        Me.radVenus = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLbs = New System.Windows.Forms.Label()
        Me.lblKgs = New System.Windows.Forms.Label()
        Me.lblConvertedKgs = New System.Windows.Forms.Label()
        CType(Me.picPlanets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlanets
        '
        Me.picPlanets.Image = CType(resources.GetObject("picPlanets.Image"), System.Drawing.Image)
        Me.picPlanets.Location = New System.Drawing.Point(12, 12)
        Me.picPlanets.Name = "picPlanets"
        Me.picPlanets.Size = New System.Drawing.Size(469, 467)
        Me.picPlanets.TabIndex = 0
        Me.picPlanets.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(34, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(329, 41)
        Me.lblTitle.TabIndex = 100
        Me.lblTitle.Text = "Planetary Weight"
        '
        'lblYourWeight
        '
        Me.lblYourWeight.AutoSize = True
        Me.lblYourWeight.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourWeight.Location = New System.Drawing.Point(3, 76)
        Me.lblYourWeight.Name = "lblYourWeight"
        Me.lblYourWeight.Size = New System.Drawing.Size(231, 27)
        Me.lblYourWeight.TabIndex = 99
        Me.lblYourWeight.Text = "Enter your weight:"
        '
        'txtUserWeight
        '
        Me.txtUserWeight.Location = New System.Drawing.Point(261, 76)
        Me.txtUserWeight.Name = "txtUserWeight"
        Me.txtUserWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtUserWeight.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblConvertedKgs)
        Me.Panel1.Controls.Add(Me.lblKgs)
        Me.Panel1.Controls.Add(Me.lblLbs)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnConvert)
        Me.Panel1.Controls.Add(Me.lblConvertedWeightValue)
        Me.Panel1.Controls.Add(Me.lblConvertedWeight)
        Me.Panel1.Controls.Add(Me.lblPlanetSelect)
        Me.Panel1.Controls.Add(Me.radMars)
        Me.Panel1.Controls.Add(Me.radVenus)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.txtUserWeight)
        Me.Panel1.Controls.Add(Me.lblYourWeight)
        Me.Panel1.Location = New System.Drawing.Point(508, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 467)
        Me.Panel1.TabIndex = 4
        '
        'lblConvertedWeightValue
        '
        Me.lblConvertedWeightValue.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedWeightValue.Location = New System.Drawing.Point(161, 271)
        Me.lblConvertedWeightValue.Name = "lblConvertedWeightValue"
        Me.lblConvertedWeightValue.Size = New System.Drawing.Size(100, 27)
        Me.lblConvertedWeightValue.TabIndex = 102
        '
        'lblConvertedWeight
        '
        Me.lblConvertedWeight.AutoSize = True
        Me.lblConvertedWeight.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedWeight.Location = New System.Drawing.Point(92, 244)
        Me.lblConvertedWeight.Name = "lblConvertedWeight"
        Me.lblConvertedWeight.Size = New System.Drawing.Size(237, 27)
        Me.lblConvertedWeight.TabIndex = 101
        Me.lblConvertedWeight.Text = "Converted weights:"
        '
        'lblPlanetSelect
        '
        Me.lblPlanetSelect.AutoSize = True
        Me.lblPlanetSelect.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetSelect.Location = New System.Drawing.Point(36, 157)
        Me.lblPlanetSelect.Name = "lblPlanetSelect"
        Me.lblPlanetSelect.Size = New System.Drawing.Size(172, 27)
        Me.lblPlanetSelect.TabIndex = 98
        Me.lblPlanetSelect.Text = "Select planet:"
        '
        'radMars
        '
        Me.radMars.AutoSize = True
        Me.radMars.Location = New System.Drawing.Point(240, 167)
        Me.radMars.Name = "radMars"
        Me.radMars.Size = New System.Drawing.Size(48, 17)
        Me.radMars.TabIndex = 3
        Me.radMars.Text = "Mars"
        Me.radMars.UseVisualStyleBackColor = True
        '
        'radVenus
        '
        Me.radVenus.AutoSize = True
        Me.radVenus.Checked = True
        Me.radVenus.Location = New System.Drawing.Point(240, 143)
        Me.radVenus.Name = "radVenus"
        Me.radVenus.Size = New System.Drawing.Size(55, 17)
        Me.radVenus.TabIndex = 2
        Me.radVenus.TabStop = True
        Me.radVenus.Text = "Venus"
        Me.radVenus.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(26, 356)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(112, 83)
        Me.btnConvert.TabIndex = 103
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(160, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 83)
        Me.btnClear.TabIndex = 104
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(294, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 83)
        Me.btnExit.TabIndex = 105
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLbs
        '
        Me.lblLbs.AutoSize = True
        Me.lblLbs.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLbs.Location = New System.Drawing.Point(102, 271)
        Me.lblLbs.Name = "lblLbs"
        Me.lblLbs.Size = New System.Drawing.Size(53, 27)
        Me.lblLbs.TabIndex = 106
        Me.lblLbs.Text = "Lbs"
        Me.lblLbs.Visible = False
        '
        'lblKgs
        '
        Me.lblKgs.AutoSize = True
        Me.lblKgs.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgs.Location = New System.Drawing.Point(107, 298)
        Me.lblKgs.Name = "lblKgs"
        Me.lblKgs.Size = New System.Drawing.Size(42, 27)
        Me.lblKgs.TabIndex = 107
        Me.lblKgs.Text = "Kg"
        Me.lblKgs.Visible = False
        '
        'lblConvertedKgs
        '
        Me.lblConvertedKgs.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedKgs.Location = New System.Drawing.Point(161, 298)
        Me.lblConvertedKgs.Name = "lblConvertedKgs"
        Me.lblConvertedKgs.Size = New System.Drawing.Size(100, 27)
        Me.lblConvertedKgs.TabIndex = 108
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 489)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picPlanets)
        Me.Name = "frmMain"
        Me.Text = "Planetary Weight"
        CType(Me.picPlanets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlanets As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblYourWeight As Label
    Friend WithEvents txtUserWeight As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblConvertedWeightValue As Label
    Friend WithEvents lblConvertedWeight As Label
    Friend WithEvents lblPlanetSelect As Label
    Friend WithEvents radMars As RadioButton
    Friend WithEvents radVenus As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblLbs As Label
    Friend WithEvents lblConvertedKgs As Label
    Friend WithEvents lblKgs As Label
End Class
