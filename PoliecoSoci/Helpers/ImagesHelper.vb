Imports DAL
Module ImagesHelper
    Public Function GetStatoIcon(CodStato As String) As Image
        If CodStato = Enums.StatoSocio.ATTIVO Then 'Attivo
            Return My.Resources.Light_Green_Round_16_n_g
        ElseIf CodStato = Enums.StatoSocio.NUOVO Then 'Nuovo
            Return My.Resources.Light_Blue_Round_16_n_g
        ElseIf CodStato = Enums.StatoSocio.USCITO Then 'Uscito
            Return My.Resources.Light_Red_Round_16_n_g
        Else
            'Altro
            Return My.Resources.Light_Yellow_Round_16_n_g
        End If
    End Function

    Public Function GetStatoDicPagIcon(Value As String) As Image
        If Value = Enums.StatoDocumento.OK Then 'Attivo
            Return My.Resources.Light_Green_Round_16_n_g
        ElseIf Value = Enums.StatoDocumento.NO Then 'Nuovo
            Return My.Resources.Light_Red_Round_16_n_g
        ElseIf Value = Enums.StatoDocumento.PARTIAL Then
            Return My.Resources.Light_Yellow_Round_16_n_g
        ElseIf Value = Enums.StatoDocumento.FORCED Then
            Return My.Resources.FORCED
        Else
            Return mdsUtility.GraphicsHelper.EmptyImage
        End If
    End Function

End Module
