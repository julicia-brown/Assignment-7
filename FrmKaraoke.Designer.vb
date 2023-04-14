<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaraoke))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.CmbSelection = New System.Windows.Forms.ComboBox()
        Me.lblInsert = New System.Windows.Forms.Label()
        Me.txtbAmount = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblReturnHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHeader.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeader.Location = New System.Drawing.Point(130, 53)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(668, 86)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Karaoke Music Night"
        '
        'CmbSelection
        '
        Me.CmbSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSelection.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CmbSelection.FormattingEnabled = True
        Me.CmbSelection.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Room ($8.99 per hour)"})
        Me.CmbSelection.Location = New System.Drawing.Point(128, 243)
        Me.CmbSelection.Name = "CmbSelection"
        Me.CmbSelection.Size = New System.Drawing.Size(692, 50)
        Me.CmbSelection.TabIndex = 3
        '
        'lblInsert
        '
        Me.lblInsert.AutoSize = True
        Me.lblInsert.BackColor = System.Drawing.Color.Transparent
        Me.lblInsert.Font = New System.Drawing.Font("Ebrima", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInsert.Location = New System.Drawing.Point(169, 385)
        Me.lblInsert.Name = "lblInsert"
        Me.lblInsert.Size = New System.Drawing.Size(629, 50)
        Me.lblInsert.TabIndex = 4
        Me.lblInsert.Text = "Amount Based on Selected Option:"
        '
        'txtbAmount
        '
        Me.txtbAmount.Font = New System.Drawing.Font("Ebrima", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbAmount.Location = New System.Drawing.Point(415, 486)
        Me.txtbAmount.Name = "txtbAmount"
        Me.txtbAmount.Size = New System.Drawing.Size(109, 55)
        Me.txtbAmount.TabIndex = 5
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTotal.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(128, 593)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(282, 80)
        Me.btnTotal.TabIndex = 6
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(538, 593)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(282, 80)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblReturnHeader
        '
        Me.lblReturnHeader.AutoSize = True
        Me.lblReturnHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReturnHeader.Location = New System.Drawing.Point(151, 739)
        Me.lblReturnHeader.Name = "lblReturnHeader"
        Me.lblReturnHeader.Size = New System.Drawing.Size(422, 37)
        Me.lblReturnHeader.TabIndex = 8
        Me.lblReturnHeader.Text = "Total Cost of Karaoke Night:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblResult)
        Me.Panel1.Controls.Add(Me.lblReturnHeader)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnTotal)
        Me.Panel1.Controls.Add(Me.txtbAmount)
        Me.Panel1.Controls.Add(Me.lblInsert)
        Me.Panel1.Controls.Add(Me.CmbSelection)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Location = New System.Drawing.Point(548, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 846)
        Me.Panel1.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Location = New System.Drawing.Point(595, 739)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(116, 37)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "$XX.xx"
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1445, 831)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents CmbSelection As ComboBox
    Friend WithEvents lblInsert As Label
    Friend WithEvents txtbAmount As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblReturnHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblResult As Label
End Class
