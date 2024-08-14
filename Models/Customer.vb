Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

' Represents a customer entity in the application.
Public Class Customer
    ' Unique identifier for the customer.
    ' Typically an auto-incremented integer value.
    Public Property CustomerID As Integer

    ' Customer's name.
    ' This property is required and must not exceed 100 characters.
    ' Validation: Ensures that the name is provided and is within the specified length.
    <Required(ErrorMessage:="Name is required.")>
    <StringLength(100, ErrorMessage:="Name cannot be longer than 100 characters.")>
    Public Property Name As String

    ' Customer's email address.
    ' This property is required and must match a valid email format.
    ' Validation: Ensures that the email is provided and is in the correct format.
    <Required(ErrorMessage:="Email is required.")>
    <RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage:="Invalid Email Address")>
    Public Property Email As String

    ' Date when the customer registered.
    ' This property is required and is displayed in a date format.
    ' Validation: Ensures that the registration date is provided and is formatted correctly.
    <Required(ErrorMessage:="Registration Date is required.")>
    <DisplayName("Registration Date")>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
    <DataType(DataType.Date)>
    Public Property RegistrationDate As Date

End Class
