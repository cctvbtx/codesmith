'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Profile.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
Public Partial Class Profile 
    Inherits BusinessBase(Of Profile)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method 
    End Sub

    Private Sub New(ByVal uniqueID As System.Int32)
        Using(BypassPropertyChecks)
           LoadProperty(_uniqueIDProperty, uniqueID)
        End Using
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _usernameProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_usernameProperty, 256))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _applicationNameProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_applicationNameProperty, 256))
    End Sub

    #End Region

    #Region "Properties"

    
    Private Shared ReadOnly _uniqueIDProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Profile) p.UniqueID)
		<System.ComponentModel.DataObjectField(true, true)> _
    Public Property UniqueID() As System.Int32
        Get 
            Return GetProperty(_uniqueIDProperty)
        End Get
        Friend Set (ByVal value As System.Int32)
            SetProperty(_uniqueIDProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _usernameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Profile) p.Username)
    Public Property Username() As System.String
        Get 
            Return GetProperty(_usernameProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_usernameProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _applicationNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Profile) p.ApplicationName)
    Public Property ApplicationName() As System.String
        Get 
            Return GetProperty(_applicationNameProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_applicationNameProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _isAnonymousProperty As PropertyInfo(Of System.Nullable(Of System.Boolean)) = RegisterProperty(Of System.Nullable(Of System.Boolean))(Function(p As Profile) p.IsAnonymous)
    Public Property IsAnonymous() As System.Nullable(Of System.Boolean)
        Get 
            Return GetProperty(_isAnonymousProperty)
        End Get
        Set (ByVal value As System.Nullable(Of System.Boolean))
            SetProperty(_isAnonymousProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _lastActivityDateProperty As PropertyInfo(Of System.Nullable(Of System.DateTime)) = RegisterProperty(Of System.Nullable(Of System.DateTime))(Function(p As Profile) p.LastActivityDate)
    Public Property LastActivityDate() As System.Nullable(Of System.DateTime)
        Get 
            Return GetProperty(_lastActivityDateProperty)
        End Get
        Set (ByVal value As System.Nullable(Of System.DateTime))
            SetProperty(_lastActivityDateProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _lastUpdatedDateProperty As PropertyInfo(Of System.Nullable(Of System.DateTime)) = RegisterProperty(Of System.Nullable(Of System.DateTime))(Function(p As Profile) p.LastUpdatedDate)
    Public Property LastUpdatedDate() As System.Nullable(Of System.DateTime)
        Get 
            Return GetProperty(_lastUpdatedDateProperty)
        End Get
        Set (ByVal value As System.Nullable(Of System.DateTime))
            SetProperty(_lastUpdatedDateProperty, value)
        End Set
    End Property
    
    'OneToMany
    Private Shared ReadOnly _accountsProperty As PropertyInfo(Of AccountList) = RegisterProperty(Of AccountList)(Function(p As Profile) p.Accounts, Csla.RelationshipTypes.Child)
Public ReadOnly Property Accounts() As AccountList 
        Get
            If Not (FieldManager.FieldExists(_accountsProperty)) Then
                Dim criteria As New PetShop.Business.AccountCriteria()
                criteria.UniqueID = UniqueID
                
                If (Me.IsNew Or Not PetShop.Business.AccountList.Exists(criteria)) Then
                    LoadProperty(_accountsProperty, PetShop.Business.AccountList.NewList())
                Else
                    LoadProperty(_accountsProperty, PetShop.Business.AccountList.GetByUniqueID(UniqueID))
                End If
            End If
            
            Return GetProperty(_accountsProperty) 
        End Get
    End Property
    
    'OneToMany
    Private Shared ReadOnly _cartsProperty As PropertyInfo(Of CartList) = RegisterProperty(Of CartList)(Function(p As Profile) p.Carts, Csla.RelationshipTypes.Child)
Public ReadOnly Property Carts() As CartList 
        Get
            If Not (FieldManager.FieldExists(_cartsProperty)) Then
                Dim criteria As New PetShop.Business.CartCriteria()
                criteria.UniqueID = UniqueID
                
                If (Me.IsNew Or Not PetShop.Business.CartList.Exists(criteria)) Then
                    LoadProperty(_cartsProperty, PetShop.Business.CartList.NewList())
                Else
                    LoadProperty(_cartsProperty, PetShop.Business.CartList.GetByUniqueID(UniqueID))
                End If
            End If
            
            Return GetProperty(_cartsProperty) 
        End Get
    End Property
    
    #End Region

    #Region "Root Factory Methods"

    Public Shared Function NewProfile() As Profile 
        Return DataPortal.Create(Of Profile)()
    End Function

    Public Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As Profile 
        Dim criteria As New ProfileCriteria()
        criteria.UniqueID = uniqueID

        Return DataPortal.Fetch(Of Profile)(criteria)
    End Function

    Public Shared Function GetByUsernameApplicationName(ByVal username As System.String, ByVal applicationName As System.String) As Profile 
        Dim criteria As New ProfileCriteria()
        criteria.Username = username
		criteria.ApplicationName = applicationName

        Return DataPortal.Fetch(Of Profile)(criteria)
    End Function

    Public Shared Sub DeleteProfile(ByVal uniqueID As System.Int32)
        DataPortal.Delete(New ProfileCriteria(uniqueID))
    End Sub

    #End Region

    #Region "Child Factory Methods"

    Friend Shared Function NewProfileChild() As Profile
        Return DataPortal.CreateChild(Of Profile)()
    End Function

    Friend Shared Function GetByUniqueIDChild(ByVal uniqueID As System.Int32) As Profile 
        Dim criteria As New ProfileCriteria()
        criteria.UniqueID = uniqueID

        Return DataPortal.FetchChild(Of Profile)(criteria)
    End Function

    Friend Shared Function GetByUsernameApplicationNameChild(ByVal username As System.String, ByVal applicationName As System.String) As Profile 
        Dim criteria As New ProfileCriteria()
        criteria.Username = username
        criteria.ApplicationName = applicationName

        Return DataPortal.FetchChild(Of Profile)(criteria)
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As ProfileCriteria) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region

End Class