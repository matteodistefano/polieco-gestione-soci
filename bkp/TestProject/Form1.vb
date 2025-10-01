Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim PathXsl As String = My.Application.Info.DirectoryPath & "\quote.xl.xsl"
            Dim PathXml As String = My.Application.Info.DirectoryPath & "\quote.xml"

            Dim PathXmlData As String = My.Application.Info.DirectoryPath & "\dsquote.xml"

            Dim PathXls As String = My.Application.Info.DirectoryPath & "\quote.xls"



            Using Conn As New System.Data.SqlClient.SqlConnection("server=.\ss2008; initial catalog=SociPolieco; User Id=intuser; Password=intuser")

                Dim ds As New DataSet("report")
                Dim tbPar As New DataTable("parametro")
                tbPar.Columns.Add("nome")
                tbPar.Columns.Add("valore")
                tbPar.Rows.Add(New Object() {"Anno", "2013"})
                tbPar.Rows.Add(New Object() {"Categoria", "A"})
                tbPar.Rows.Add(New Object() {"Categoria", "B"})
                tbPar.Rows.Add(New Object() {"Categoria", "C"})
                tbPar.Rows.Add(New Object() {"Categoria", "D"})
                tbPar.Rows.Add(New Object() {"Categoria", "E"})
                ds.Tables.Add(tbPar)





                Dim tbAnalisi As New DataTable("analisi")
                Dim cmd As SqlClient.SqlCommand = Conn.CreateCommand
                cmd.CommandText = "getAnalisiQuote"
                cmd.Parameters.AddWithValue("Anno", 2013)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(tbAnalisi)
                ds.Tables.Add(tbAnalisi)

                For Each tb As DataTable In ds.Tables
                    For Each c As DataColumn In tb.Columns
                        c.ColumnMapping = MappingType.Attribute
                    Next
                Next
                ds.WriteXml(PathXmlData, XmlWriteMode.IgnoreSchema)
            End Using

            'Return
            'Dim ds As New DataSet
            'ds.ReadXml(PathXml)

            '    Dim xdd As New Xml.XmlDataDocument(ds)
            Dim xt As New Xml.Xsl.XslCompiledTransform(True)
            xt.Load(PathXsl)
            xt.Transform(PathXmlData, PathXls)
            MsgBox("Ok")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        


    End Sub
End Class
