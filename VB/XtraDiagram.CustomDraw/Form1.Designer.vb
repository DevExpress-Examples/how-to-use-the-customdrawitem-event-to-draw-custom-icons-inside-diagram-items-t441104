Namespace XtraDiagram.CustomDraw
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
            DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' diagramControl1
            ' 
            Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.diagramControl1.Name = "diagramControl1"
            Me.diagramControl1.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl1.Size = New System.Drawing.Size(907, 580)
            Me.diagramControl1.TabIndex = 0
            Me.diagramControl1.Text = "diagramControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(907, 580)
            Me.Controls.Add(Me.diagramControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents diagramControl1 As DevExpress.XtraDiagram.DiagramControl
    End Class
End Namespace

