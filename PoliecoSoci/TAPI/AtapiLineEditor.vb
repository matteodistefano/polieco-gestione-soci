Imports System.Drawing.Design
Public Class AtapiLineEditor
    Inherits UITypeEditor

    Public Overrides Function GetEditStyle(context As System.ComponentModel.ITypeDescriptorContext) As System.Drawing.Design.UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overrides Function EditValue(context As System.ComponentModel.ITypeDescriptorContext, provider As System.IServiceProvider, value As Object) As Object
        Dim F As New dlgEditAtapi

        Dim v As Integer? = F.Edit(value)
        If Not v.HasValue Then Return value
        Return v.Value
        
    End Function



End Class
