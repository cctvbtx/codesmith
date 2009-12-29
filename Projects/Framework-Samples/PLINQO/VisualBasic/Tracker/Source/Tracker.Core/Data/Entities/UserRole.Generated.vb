﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------
Imports System
Imports System.Linq

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The class representing the dbo.UserRole table.
    ''' </summary>
    <System.Data.Linq.Mapping.Table(Name:="dbo.UserRole")> _
    <System.Runtime.Serialization.DataContract(IsReference:=True)> _
    <System.ComponentModel.DataAnnotations.ScaffoldTable(True)> _
    <System.ComponentModel.DataAnnotations.MetadataType(GetType(UserRole.Metadata))> _
    <System.Data.Services.Common.DataServiceKey("UserId", "RoleId")> _
    <System.Diagnostics.DebuggerDisplay("UserId: {UserId}, RoleId: {RoleId}")> _
    Partial Public Class UserRole
        Inherits LinqEntityBase
        Implements ICloneable

#Region "Static Constructor"
        ''' <summary>
        ''' Initializes the <see cref="UserRole"/> class.
        ''' </summary>
        Shared Sub New()
            AddSharedRules()
        End Sub
#End Region

#Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="UserRole"/> class.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCode()> _
        Public Sub New()
            Initialize()
        End Sub

        Private Sub Initialize()
            _role = Nothing
            _user = Nothing
            OnCreated()
        End Sub
#End Region

#Region "Column Mapped Properties"

        Private _userId As Integer

        ''' <summary>
        ''' Gets or sets the UserId column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="UserId", Storage:="_userId", DbType:="int NOT NULL", IsPrimaryKey:=True, CanBeNull:=False)> _
        <System.Runtime.Serialization.DataMember(Order:=1)> _
        Public Property UserId() As Integer
            Get
                Return _userId
            End Get
            Set(ByVal value As Integer)
                If ((Me._userId = value) = False) Then
                    If (_user.HasLoadedOrAssignedValue) Then
                        Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                    End If
                    OnUserIdChanging(value)
                    SendPropertyChanging("UserId")
                    _userId = value
                    SendPropertyChanged("UserId")
                    OnUserIdChanged()
                End If
            End Set
        End Property

        Private _roleId As Integer

        ''' <summary>
        ''' Gets or sets the RoleId column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="RoleId", Storage:="_roleId", DbType:="int NOT NULL", IsPrimaryKey:=True, CanBeNull:=False)> _
        <System.Runtime.Serialization.DataMember(Order:=2)> _
        Public Property RoleId() As Integer
            Get
                Return _roleId
            End Get
            Set(ByVal value As Integer)
                If ((Me._roleId = value) = False) Then
                    If (_role.HasLoadedOrAssignedValue) Then
                        Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                    End If
                    OnRoleIdChanging(value)
                    SendPropertyChanging("RoleId")
                    _roleId = value
                    SendPropertyChanged("RoleId")
                    OnRoleIdChanged()
                End If
            End Set
        End Property
#End Region

#Region "Association Mapped Properties"

        Private  _role As System.Data.Linq.EntityRef(Of Role)

        ''' <summary>
        ''' Gets or sets the Role association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="Role_UserRole", Storage:="_role", ThisKey:="RoleId", OtherKey:="Id", IsUnique:=true, IsForeignKey:=true)> _
        <System.Runtime.Serialization.DataMember(Order:=3, EmitDefaultValue:=False)> _
        Public Property Role() As Role
            Get
                If (serializing AndAlso Not _role.HasLoadedOrAssignedValue) Then
                    Return Nothing
                Else
                    Return _role.Entity
                End If
            End Get
            Set(ByVal value As Role)
                Dim previousValue As Role = _role.Entity
                If ((Object.Equals(previousValue, value) = False) OrElse (Me._role.HasLoadedOrAssignedValue = False)) Then
                    SendPropertyChanging("Role")
                    If ((previousValue Is Nothing) = False) Then
                        _role.Entity = Nothing
                        previousValue.UserRoleList.Remove(Me)
                    End If
                    _role.Entity = value
                    If ((value Is Nothing) = False) Then
                        value.UserRoleList.Add(Me)
                        _roleId = value.Id
                    Else
                        _roleId = Nothing
                    End If
                    SendPropertyChanged("Role")
                End If
            End Set
        End Property
        Private  _user As System.Data.Linq.EntityRef(Of User)

        ''' <summary>
        ''' Gets or sets the User association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="User_UserRole", Storage:="_user", ThisKey:="UserId", OtherKey:="Id", IsUnique:=true, IsForeignKey:=true, DeleteOnNull:=true)> _
        <System.Runtime.Serialization.DataMember(Order:=4, EmitDefaultValue:=False)> _
        Public Property User() As User
            Get
                If (serializing AndAlso Not _user.HasLoadedOrAssignedValue) Then
                    Return Nothing
                Else
                    Return _user.Entity
                End If
            End Get
            Set(ByVal value As User)
                Dim previousValue As User = _user.Entity
                If ((Object.Equals(previousValue, value) = False) OrElse (Me._user.HasLoadedOrAssignedValue = False)) Then
                    SendPropertyChanging("User")
                    If ((previousValue Is Nothing) = False) Then
                        _user.Entity = Nothing
                        previousValue.UserRoleList.Remove(Me)
                    End If
                    _user.Entity = value
                    If ((value Is Nothing) = False) Then
                        value.UserRoleList.Add(Me)
                        _userId = value.Id
                    Else
                        _userId = Nothing
                    End If
                    SendPropertyChanged("User")
                End If
            End Set
        End Property
#End Region

#Region "Extensibility Method Definitions"

        ''' <summary>Called by the Shared constructor to add shared rules.</summary>
        Partial Private Shared Sub AddSharedRules()
        End Sub
        ''' <summary>Called when this instance is loaded.</summary>
        Partial Private Sub OnLoaded()
        End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub
        ''' <summary>Called when this instance is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called when UserId is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnUserIdChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after UserId has Changed.</summary>
        Partial Private Sub OnUserIdChanged()
        End Sub
        ''' <summary>Called when RoleId is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnRoleIdChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after RoleId has Changed.</summary>
        Partial Private Sub OnRoleIdChanged()
        End Sub
#End Region

#Region "Serialization"

        Private serializing As Boolean

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = True
        End Sub

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerialized(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerialized(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = False
        End Sub

        ''' <summary>
        ''' Called when deserializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnDeserializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnDeserializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            Initialize()
        End Sub
        
        ''' <summary>
        ''' Deserializes an instance of <see cref="UserRole"/> from XML.
        ''' </summary>
        ''' <param name="xml">The XML string representing a <see cref="UserRole"/> instance.</param>
        ''' <returns>An instance of <see cref="UserRole"/> that is deserialized from the XML string.</returns>
        Public Shared Function FromXml(ByVal xml As String) As UserRole
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(UserRole))
            
            Using sr = New System.IO.StringReader(xml)
                Using reader = System.Xml.XmlReader.Create(sr)
                    Return TryCast(deserializer.ReadObject(reader), UserRole)
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Deserializes an instance of <see cref="UserRole"/>.
        ''' </summary>
        ''' <param name="buffer">The byte array representing a <see cref="UserRole"/> instance.</param>
        ''' <returns>An instance of <see cref="UserRole"/> that is deserialized from the byte array.</returns>
        Public Shared Function FromBinary(ByVal buffer As Byte()) As UserRole
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(UserRole))

            Using ms = New System.IO.MemoryStream(buffer)
                Using reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max)
                    Return TryCast(deserializer.ReadObject(reader), UserRole)
                End Using
            End Using
        End Function
#End Region

#Region "Clone"
        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
            Dim serializer As New System.Runtime.Serialization.DataContractSerializer([GetType]())
            Using ms As New System.IO.MemoryStream()
                serializer.WriteObject(ms, Me)
                ms.Position = 0
                Return serializer.ReadObject(ms)
            End Using
        End Function

        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        ''' <remarks>
        ''' This method is equivalent to a Detach from the current <see cref="System.Data.Linq.DataContext"/>.
        ''' Only loaded EntityRef and EntitySet child accessions will be cloned.
        ''' </remarks>
        Public Function Clone() As UserRole
            Return DirectCast(DirectCast(Me, ICloneable).Clone(), UserRole)
        End Function
#End Region

#Region "Detach Methods"
        ''' <summary>
        ''' Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <remarks>
        ''' Detaching the entity will allow it to be attached to another <see cref="System.Data.Linq.DataContext"/>.
        ''' </remarks>
        Public Overrides Sub Detach()

            If (Not IsAttached()) Then
                Return
            End If

            MyBase.Detach()
            _role = Detach(_role)
            _user = Detach(_user)
        End Sub
#End Region
    End Class
End Namespace

