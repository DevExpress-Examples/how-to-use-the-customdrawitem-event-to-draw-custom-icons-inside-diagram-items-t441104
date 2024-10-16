<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585469/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T441104)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraDiagram.CustomDraw/Form1.cs) (VB: [Form1.vb](./VB/XtraDiagram.CustomDraw/Form1.vb))
* [Program.cs](./CS/XtraDiagram.CustomDraw/Program.cs) (VB: [Program.vb](./VB/XtraDiagram.CustomDraw/Program.vb))
<!-- default file list end -->
# How to use the CustomDrawItem event to draw custom icons inside diagram items


This example demonstrates how to use the <strong>CustomDrawItem</strong> event to modify the standard drawing mechanism of diagram items (shapes, connectors, containers, etc.). In this example, a DiagramShape class descendant was created to introduce the Status property. Depending on the Status property value, a custom icon is drawn in the lower right-hand corner of a shape.<br><br><br><strong>Important notes</strong><em>:</em> <em>The <strong>DefaultDraw</strong> method in the event args invokes certain parts of the standard shape drawing mechanism (the method parameter defines which ones). If you don't call this method, shape content, border and background will not be drawn.</em><br><br><em>To apply custom drawing logic defined in the <strong>CustomDrawItem</strong> event handler to your shapes, set the <strong>Handled</strong> property from the event args to true.</em>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-the-customdrawitem-event-to-draw-custom-icons-inside-diagram-items-t441104&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-the-customdrawitem-event-to-draw-custom-icons-inside-diagram-items-t441104&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
