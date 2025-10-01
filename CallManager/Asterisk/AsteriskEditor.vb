Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

Public Class AsteriskEditor
    Inherits UITypeEditor

    Public Overrides Function GetEditStyle(context As System.ComponentModel.ITypeDescriptorContext) As System.Drawing.Design.UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    Public Overrides Function EditValue(context As System.ComponentModel.ITypeDescriptorContext, provider As System.IServiceProvider, value As Object) As Object
        If provider IsNot Nothing Then
            Dim editorService As IWindowsFormsEditorService = DirectCast(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
            If editorService IsNot Nothing Then
                ' Utilizza la tua dialog personalizzata qui
                Using dialog As New dlgEditAsterisk
                    Dim v As AsteriskManager.Configuration = dialog.Edit(value)
                    If v IsNot Nothing Then
                        value = v
                        context.PropertyDescriptor.SetValue(context.Instance, value)
                    End If
                End Using
            End If
        End If
        Return value
    End Function

    Public Overrides Function ToString() As String
        Return "Configurazione ASTERISK"
    End Function


End Class
