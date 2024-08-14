Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

' Represents a product entity in the application.
Public Class Product
    ' Unique identifier for the product.
    ' Typically an auto-incremented integer value.
    Public Property ProductID As Integer

    ' Product's name.
    ' This property is required and must not exceed 100 characters.
    ' Validation:
    ' - Ensures that the product name is provided.
    ' - Limits the length of the name to a maximum of 100 characters.
    ' Error messages are displayed if the validation fails.
    <Required(ErrorMessage:="Name is required.")>
    <StringLength(100, ErrorMessage:="Name cannot be longer than 100 characters.")>
    Public Property Name As String

    ' Product's category.
    ' This property is required and must not exceed 50 characters.
    ' Validation:
    ' - Ensures that the category is provided.
    ' - Limits the length of the category to a maximum of 50 characters.
    ' Error messages are displayed if the validation fails.
    <Required(ErrorMessage:="Category is required.")>
    <StringLength(50, ErrorMessage:="Category cannot be longer than 50 characters.")>
    Public Property Category As String

    ' Product's price.
    ' This property must be greater than 0.
    ' Validation:
    ' - Ensures that the price is a positive number.
    ' - Error message is displayed if the price is not greater than 0.
    <Range(0.01, Double.MaxValue, ErrorMessage:="Price must be greater than 0")>
    Public Property Price As Decimal

    ' Product's stock quantity.
    ' This property must be greater than or equal to 0.
    ' Validation:
    ' - Ensures that the stock is a non-negative integer.
    ' - Error message is displayed if the stock is less than 0. 
    <Range(0, Integer.MaxValue, ErrorMessage:="Stock must be greater than 0")>
    Public Property Stock As Integer

    ' Date when the product was launched.
    ' This property is displayed in a date format.
    ' Validation:
    ' - Provides a user-friendly name for the property in UI (e.g., forms).
    ' - Formats the date in `dd/MM/yyyy` format for display and edit modes.
    <DisplayName("Launch Date")>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
    <DataType(DataType.Date)>
    Public Property LaunchDate As Date

End Class