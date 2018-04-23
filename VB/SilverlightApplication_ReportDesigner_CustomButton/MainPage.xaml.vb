Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace SilverlightApplication_ReportDesigner_CustomButton
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			DataContext = New MainPageViewModel()
		End Sub
	End Class
End Namespace
