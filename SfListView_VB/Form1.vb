Imports System.Collections.ObjectModel

Public Class Form1

    Dim countryInfoCollection As ObservableCollection(Of CountryInfo) = New ObservableCollection(Of CountryInfo)()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SfListView1.DataSource = GetDataSource()
        SfListView1.ShowCheckBoxes = True

        SfListView1.DisplayMember = "CountryName"

    End Sub

    Public Function GetDataSource() As ObservableCollection(Of CountryInfo)

        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "China",
        .Continent = "Asia"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "India",
        .Continent = "Asia"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Japan",
        .Continent = "Asia"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Malaysia",
        .Continent = "Asia"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "UnitedSates",
        .Continent = "NorthAmerica"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Canada",
        .Continent = "NorthAmerica"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Germany",
        .Continent = "Europe"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "UnitedKingdom",
        .Continent = "Europe"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Italy",
        .Continent = "Europe"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "NewZealand",
        .Continent = "PacificIsland"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Australia",
        .Continent = "PacificIsland"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Finland",
        .Continent = "Europe"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Sweden",
        .Continent = "Europe"
    })
        countryInfoCollection.Add(New CountryInfo() With {
        .CountryName = "Netherland",
        .Continent = "Asia"
    })
        Return countryInfoCollection
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item In countryInfoCollection
            If item.CountryName = "Canada" OrElse item.CountryName = "Germany" OrElse item.Continent = "Europe" Then
                SfListView1.CheckedItems.Add(item)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item In countryInfoCollection
            If item.Continent = "Europe" Then
                SfListView1.CheckedItems.Remove(item)
            End If
        Next
    End Sub
End Class

Public Class CountryInfo
    Public Property CountryName As String
    Public Property Continent As String
End Class
