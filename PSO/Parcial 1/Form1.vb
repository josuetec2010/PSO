Imports System.IO

Public Class Form1
    Dim arregloUnidades() As DriveInfo
    Dim listaDiscos As New List(Of Disco)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUnidades()
    End Sub

    Sub CargarUnidades()
        arregloUnidades = DriveInfo.GetDrives()
        cboUnidades.Items.Clear()
        listaDiscos.Clear()

        Dim totalGB As Integer
        Dim disponibleGB As Integer

        For Each unidad As DriveInfo In arregloUnidades
            If unidad.IsReady Then
                ' Calcular TotalGB y DisponibilidadGB
                totalGB = unidad.TotalSize / 1024 / 1024 / 1024
                disponibleGB = unidad.AvailableFreeSpace / 1024 / 1024 / 1024

                Dim dsk As New Disco With
                {
                    .EspacioDisponible = disponibleGB,
                    .EspacioTotal = totalGB,
                    .Etiqueta = unidad.VolumeLabel,
                    .Formato = unidad.DriveFormat,
                    .Nombre = unidad.Name,
                    .TipoDisco = unidad.DriveType
                }

                listaDiscos.Add(dsk)
                cboUnidades.Items.Add(unidad.Name)
            End If
        Next
    End Sub

    Private Sub BtnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        CargarUnidades()
    End Sub

    Private Sub CboUnidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidades.SelectedIndexChanged
        ' Expresiones Lambda: Busquedas
        Dim dskSel As Disco = listaDiscos.Find(Function(d) d.Nombre = cboUnidades.Text)

        Dim usado As Integer = ((dskSel.EspacioTotal - dskSel.EspacioDisponible) / dskSel.EspacioTotal) * 100
        barEspacioUsado.Value = usado
    End Sub
End Class
