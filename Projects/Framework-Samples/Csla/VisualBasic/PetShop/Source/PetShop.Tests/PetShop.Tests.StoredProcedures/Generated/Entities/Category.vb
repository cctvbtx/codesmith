﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'       Changes to this template will not be lost.
'
'     Template: EditableRoot.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Namespace PetShop.Tests.StoredProcedures
    Public Partial Class Category
#Region "Business Rules"
    
        ''' <summary>
        ''' All custom rules need to be placed in this method.
        ''' </summary>
        ''' <Returns>Return true to override the generated rules If false generated rules will be run.</Returns>
        Protected Function AddBusinessValidationRules() As Boolean
            ' TODO: add validation rules
            'ValidationRules.AddRule(RuleMethod, "")
    
            Return False
        End Function
    
#End Region
    
#Region "Authorization Rules"
    
    
        Protected Overrides Sub AddAuthorizationRules()
            ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).
    
            'Dim canWrite As String() = { "AdminUser", "RegularUser" }
            'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
            'Dim admin As String() = { "AdminUser" }
    
            'AuthorizationRules.AllowCreate(GetType(Category), admin)
            'AuthorizationRules.AllowDelete(GetType(Category), admin)
            'AuthorizationRules.AllowEdit(GetType(Category), canWrite)
            'AuthorizationRules.AllowGet(GetType(Category), canRead)
    
            ''CategoryId
            'AuthorizationRules.AllowWrite(_categoryIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_categoryIdProperty, canRead)
    
            ''Name
            'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
            'AuthorizationRules.AllowRead(_nameProperty, canRead)
    
            ''Description
            'AuthorizationRules.AllowWrite(_descriptionProperty, canWrite)
            'AuthorizationRules.AllowRead(_descriptionProperty, canRead)
    
    ' NOTE: Many-To-Many support coming soon.
            ''Products
            'AuthorizationRules.AllowRead(_productsProperty, canRead)
    
        End Sub
    
#End Region
    End Class
End Namespace