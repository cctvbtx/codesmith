'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Product.vb.
'
'     Template: DynamicRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla

<Serializable()> _
Public Partial Class ProductList 
    Inherits EditableRootListBase(Of Product)
    
    #Region "Properties"
    
    Protected Overrides Function AddNewCore() As Object
        Dim item As Product = PetShop.Business.Product.NewProduct()
        Me.Add(item)
        Return item
    End Function
    
    #End Region

    #Region "Factory Methods"
    
    Public Shared Function NewList() As ProductList
        Return DataPortal.Create(Of ProductList)()
    End Function

    Public Shared Function GetByProductId(ByVal productId As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
		criteria.ProductId = productId

        Return DataPortal.Fetch(Of ProductList)(criteria)
    End Function

    Public Shared Function GetByName(ByVal name As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
		criteria.Name = name

        Return DataPortal.Fetch(Of ProductList)(criteria)
    End Function

    Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
		criteria.CategoryId = categoryId

        Return DataPortal.Fetch(Of ProductList)(criteria)
    End Function

    Public Shared Function GetByCategoryIdName(ByVal categoryId As System.String, ByVal name As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
		criteria.CategoryId = categoryId
		criteria.Name = name

        Return DataPortal.Fetch(Of ProductList)(criteria)
    End Function

    Public Shared Function GetByCategoryIdProductIdName(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String) As ProductList 
        Dim criteria As New ProductCriteria()
		criteria.CategoryId = categoryId
		criteria.ProductId = productId
		criteria.Name = name

        Return DataPortal.Fetch(Of ProductList)(criteria)
    End Function

    Public Shared Function GetAll() As ProductList
        Return DataPortal.Fetch(Of ProductList)(New ProductCriteria())
    End Function

    Private Sub New()
        AllowNew = true
    End Sub

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As ProductCriteria) As Boolean
        Return PetShop.Business.Product.Exists(criteria)
    End Function

    #End Region
End Class