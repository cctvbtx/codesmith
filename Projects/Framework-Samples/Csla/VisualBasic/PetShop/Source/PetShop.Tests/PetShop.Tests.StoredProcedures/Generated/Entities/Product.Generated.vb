﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Product.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Validation
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Tests.StoredProcedures
    <Serializable()> _
    Public Partial Class Product 
        Inherits BusinessBase(Of Product)
    
#Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method 
        End Sub
    
        Friend Sub New(ByVal productId As System.String)
            Using(BypassPropertyChecks)
                _productId = productId
            End Using
        End Sub
    
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
            MarkAsChild()   
        End Sub

#End Region    
    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _productIdProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_productIdProperty, 10))
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _categoryIdProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10))
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_nameProperty, 80))
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_descriptionProperty, 255))
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_imageProperty, 80))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _productIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Product) p.ProductId, String.Empty)
        Private _productId As System.String = _productIdProperty.DefaultValue
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property ProductId() As System.String
            Get 
                Return GetProperty(_productIdProperty, _productId) 
            End Get
            Set (value As System.String)
                SetProperty(_productIdProperty, _productId, value)
            End Set
        End Property

        Private Shared ReadOnly _originalProductIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Product) p.OriginalProductId, String.Empty)
        Private _originalProductId As System.String = _originalProductIdProperty.DefaultValue
        ''' <summary>
        ''' Holds the original value for ProductId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalProductId() As System.String
            Get 
                Return GetProperty(_originalProductIdProperty, _originalProductId) 
            End Get
            Set (value As System.String)
                SetProperty(_originalProductIdProperty, _originalProductId, value)
            End Set
        End Property

        Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Product) p.CategoryId, String.Empty)
        Private _categoryId As System.String = _categoryIdProperty.DefaultValue
        
        Public Property CategoryId() As System.String
            Get 
                Return GetProperty(_categoryIdProperty, _categoryId) 
            End Get
            Set (value As System.String)
                SetProperty(_categoryIdProperty, _categoryId, value)
            End Set
        End Property

        Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Product) p.Name, String.Empty, vbNullString)
        Private _name As System.String = _nameProperty.DefaultValue
        
        Public Property Name() As System.String
            Get 
                Return GetProperty(_nameProperty, _name) 
            End Get
            Set (value As System.String)
                SetProperty(_nameProperty, _name, value)
            End Set
        End Property

        Private Shared ReadOnly _descriptionProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Product) p.Description, String.Empty, vbNullString)
        Private _description As System.String = _descriptionProperty.DefaultValue
        
        Public Property Description() As System.String
            Get 
                Return GetProperty(_descriptionProperty, _description) 
            End Get
            Set (value As System.String)
                SetProperty(_descriptionProperty, _description, value)
            End Set
        End Property

        Private Shared ReadOnly _imageProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Product) p.Image, String.Empty, vbNullString)
        Private _image As System.String = _imageProperty.DefaultValue
        
        Public Property Image() As System.String
            Get 
                Return GetProperty(_imageProperty, _image) 
            End Get
            Set (value As System.String)
                SetProperty(_imageProperty, _image, value)
            End Set
        End Property

        'AssociatedManyToOne
        Private Shared ReadOnly _categoryMemberProperty As PropertyInfo(Of Category) = RegisterProperty(Of Category)(Function(p As Product) p.CategoryMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property CategoryMember() As Category
            Get
                If(False) Then
                    Return Nothing
                End If
    
                If Not(FieldManager.FieldExists(_categoryMemberProperty))
                    Dim criteria As New PetShop.Tests.StoredProcedures.CategoryCriteria()
                    criteria.CategoryId = CategoryId

                    If (PetShop.Tests.StoredProcedures.Category.Exists(criteria)) Then
                        LoadProperty(_categoryMemberProperty, PetShop.Tests.StoredProcedures.Category.GetByCategoryId(CategoryId))
                    End If
                End If
                
                Return GetProperty(_categoryMemberProperty) 
            End Get
        End Property 

        'AssociatedOneToMany
        Private Shared ReadOnly _itemsProperty As PropertyInfo(Of ItemList) = RegisterProperty(Of ItemList)(Function(p As Product) p.Items, Csla.RelationshipTypes.Child)
    Public ReadOnly Property Items() As ItemList
            Get
                If Not (FieldManager.FieldExists(_itemsProperty)) Then
                    Dim criteria As New PetShop.Tests.StoredProcedures.ItemCriteria()
                    criteria.ProductId = ProductId
    
                    If (Me.IsNew OrElse Not PetShop.Tests.StoredProcedures.ItemList.Exists(criteria)) Then
                        LoadProperty(_itemsProperty, PetShop.Tests.StoredProcedures.ItemList.NewList())
                    Else
                        LoadProperty(_itemsProperty, PetShop.Tests.StoredProcedures.ItemList.GetByProductId(ProductId))
                    End If
                End If
                
                Return GetProperty(_itemsProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewProduct() As Product 
            Return DataPortal.Create(Of Product)()
        End Function
    
        Public Shared Function GetByProductId(ByVal productId As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.ProductId = productId
    
            Return DataPortal.Fetch(Of Product)(criteria)
        End Function
    
        Public Shared Function GetByName(ByVal name As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.Name = name
    
            Return DataPortal.Fetch(Of Product)(criteria)
        End Function
    
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.Fetch(Of Product)(criteria)
        End Function
    
        Public Shared Function GetByCategoryIdName(ByVal categoryId As System.String, ByVal name As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
			criteria.Name = name
    
            Return DataPortal.Fetch(Of Product)(criteria)
        End Function
    
        Public Shared Function GetByCategoryIdProductIdName(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
			criteria.ProductId = productId
			criteria.Name = name
    
            Return DataPortal.Fetch(Of Product)(criteria)
        End Function
    
        Public Shared Sub DeleteProduct(ByVal productId As System.String)
            DataPortal.Delete(New ProductCriteria (productId))
        End Sub
    
#End Region
#Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewProductChild() As Product
            Return DataPortal.CreateChild(Of Product)()
        End Function
    
        Friend Shared Function GetByProductIdChild(ByVal productId As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.ProductId = productId
    
            Return DataPortal.FetchChild(Of Product)(criteria)
        End Function
    
        Friend Shared Function GetByNameChild(ByVal name As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.Name = name
    
            Return DataPortal.FetchChild(Of Product)(criteria)
        End Function
    
        Friend Shared Function GetByCategoryIdChild(ByVal categoryId As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.FetchChild(Of Product)(criteria)
        End Function
    
        Friend Shared Function GetByCategoryIdNameChild(ByVal categoryId As System.String, ByVal name As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
            criteria.Name = name
    
            Return DataPortal.FetchChild(Of Product)(criteria)
        End Function
    
        Friend Shared Function GetByCategoryIdProductIdNameChild(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String) As Product
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
            criteria.ProductId = productId
            criteria.Name = name
    
            Return DataPortal.FetchChild(Of Product)(criteria)
        End Function
    
#End Region
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As ProductCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnInserted()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As ProductCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
    
#End Region
    
#Region "ChildPortal partial methods"

        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As ProductCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As ProductCriteria ) As Boolean
            Return PetShop.Tests.StoredProcedures.ExistsCommand.Execute(criteria)
        End Function

#End Region
    End Class
End Namespace