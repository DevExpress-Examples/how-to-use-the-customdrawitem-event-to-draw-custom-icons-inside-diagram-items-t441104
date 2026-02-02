Imports DevExpress.Diagram.Core
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraDiagram
Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace XtraDiagram.CustomDraw

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            RegisterShapes()
            diagramControl1.CreateRibbon()
            diagramControl1.CreateDocking()
        End Sub

        Public Sub RegisterShapes()
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
            Dim stencil = New DiagramStencil("customShapes", "Custom Shapes")
            stencil.RegisterTool(New FactoryItemTool("activeTaskShape", Function() "Active Task", Function(diagram) New DiagramShapeEx With {.Content = "Active Task", .Status = Status.Active}, New Windows.Size(150, 100), False))
            stencil.RegisterTool(New FactoryItemTool("inactiveTaskShape", Function() "Inactive Task", Function(diagram) New DiagramShapeEx With {.Content = "Inactive Task", .Status = Status.Inactive}, New Windows.Size(150, 100), False))
            DiagramToolboxRegistrator.RegisterStencil(stencil)
            diagramControl1.OptionsBehavior.SelectedStencils = StencilCollection.Parse("customShapes")
        End Sub

        Private Sub diagramControl1_CustomGetEditableItemProperties(ByVal sender As Object, ByVal e As DiagramCustomGetEditableItemPropertiesEventArgs)
            e.Properties.Add(TypeDescriptor.GetProperties(GetType(DiagramShapeEx))("Status"))
        End Sub

        Private Sub diagramControl1_CustomDrawItem(ByVal sender As Object, ByVal e As CustomDrawItemEventArgs)
            Dim shape = TryCast(e.Item, DiagramShapeEx)
            If shape Is Nothing Then Return
            e.DefaultDraw()
            Dim imagePath = If(shape.Status = Status.Active, "images/actions/apply_16x16.png", "images/actions/cancel_16x16.png")
            Dim image = DevExpress.Images.ImageResourceCache.Default.GetImage(imagePath)
            Dim margin = 3F
            e.Graphics.DrawImage(image, New RectangleF(shape.Width - image.Width - margin, shape.Height - image.Height - margin, image.Width, image.Height))
            e.Handled = True
        End Sub
    End Class

    Public Class DiagramShapeEx
        Inherits DiagramShape

        <XtraSerializableProperty, Category("Info")>
        Public Property Status As Status
    End Class

    Public Enum Status
        Active
        Inactive
    End Enum
End Namespace
