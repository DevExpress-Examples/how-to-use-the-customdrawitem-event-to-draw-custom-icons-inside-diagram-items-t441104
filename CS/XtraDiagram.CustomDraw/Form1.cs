using DevExpress.Diagram.Core;
using DevExpress.Utils.Serializing;
using DevExpress.XtraDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtraDiagram.CustomDraw {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            RegisterShapes();
            diagramControl1.CreateRibbon();
            diagramControl1.CreateDocking();
        }

        public void RegisterShapes() {
            DiagramControl.ItemTypeRegistrator.Register(typeof(DiagramShapeEx));
            var stencil = new DiagramStencil("customShapes", "Custom Shapes");
            stencil.RegisterTool(new FactoryItemTool("activeTaskShape", () => "Active Task", diagram => new DiagramShapeEx { Content = "Active Task", Status = Status.Active }, new System.Windows.Size(150, 100), false));
            stencil.RegisterTool(new FactoryItemTool("inactiveTaskShape", () => "Inactive Task", diagram => new DiagramShapeEx { Content = "Inactive Task", Status = Status.Inactive }, new System.Windows.Size(150, 100), false));
            DiagramToolboxRegistrator.RegisterStencil(stencil);
            diagramControl1.OptionsBehavior.SelectedStencils = StencilCollection.Parse("customShapes");
        }

        private void diagramControl1_CustomGetEditableItemProperties(object sender, DiagramCustomGetEditableItemPropertiesEventArgs e) {
            e.Properties.Add(TypeDescriptor.GetProperties(typeof(DiagramShapeEx))["Status"]);
        }

        private void diagramControl1_CustomDrawItem(object sender, CustomDrawItemEventArgs e) {
            var shape = e.Item as DiagramShapeEx;
            if (shape == null)
                return;
            e.DefaultDraw();
            var imagePath = shape.Status == Status.Active ? "images/actions/apply_16x16.png" : "images/actions/cancel_16x16.png";
            var image = DevExpress.Images.ImageResourceCache.Default.GetImage(imagePath);
            var margin = 3f;
            e.Graphics.DrawImage(image, new RectangleF(shape.Width - image.Width - margin, shape.Height - image.Height - margin, image.Width, image.Height));
            e.Handled = true;
        }
    }

    public class DiagramShapeEx : DiagramShape {

        [XtraSerializableProperty, Category("Info")]
        public Status Status { get; set; }
    }

    public enum Status { Active, Inactive }
}
