'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.0
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On 

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(), _
 System.ComponentModel.DesignerCategoryAttribute("code"), _
 System.Diagnostics.DebuggerStepThrough(), _
 System.ComponentModel.ToolboxItem(True)> _
Public Class FixedCustomerTDS
  Inherits DataSet

  Private tableCustomer As CustomerDataTable

  Private tableInvoice As InvoiceDataTable

  Private relationCustomerInvoice As DataRelation

  Public Sub New()
    MyBase.New()
    Me.InitClass()
    Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
    AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
    AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
  End Sub

  Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
    MyBase.New()
    Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)), String)
    If (Not (strSchema) Is Nothing) Then
      Dim ds As DataSet = New DataSet()
      ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
      If (Not (ds.Tables("Customer")) Is Nothing) Then
        Me.Tables.Add(New CustomerDataTable(ds.Tables("Customer")))
      End If
      If (Not (ds.Tables("Invoice")) Is Nothing) Then
        Me.Tables.Add(New InvoiceDataTable(ds.Tables("Invoice")))
      End If
      Me.DataSetName = ds.DataSetName
      Me.Prefix = ds.Prefix
      Me.Namespace = ds.Namespace
      Me.Locale = ds.Locale
      Me.CaseSensitive = ds.CaseSensitive
      Me.EnforceConstraints = ds.EnforceConstraints
      Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
      Me.InitVars()
    Else
      Me.InitClass()
    End If
    Me.GetSerializationData(info, context)
    Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
    AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
    AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
  End Sub

  <System.ComponentModel.Browsable(False), _
   System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
  Public ReadOnly Property Customer() As CustomerDataTable
    Get
      Return Me.tableCustomer
    End Get
  End Property

  Protected Overridable Function CreateCustomerDataTable(ByVal table As DataTable) As CustomerDataTable
    If table Is Nothing Then
      Return New CustomerDataTable()
    Else
      Return New CustomerDataTable(table)
    End If
  End Function

  <System.ComponentModel.Browsable(False), _
   System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
  Public ReadOnly Property Invoice() As InvoiceDataTable
    Get
      Return Me.tableInvoice
    End Get
  End Property

  Protected Overridable Function CreateInvoiceDataTable(ByVal table As DataTable) As InvoiceDataTable
    If table Is Nothing Then
      Return New InvoiceDataTable()
    Else
      Return New InvoiceDataTable(table)
    End If
  End Function

  Public Overrides Function Clone() As DataSet
    Dim cln As CustomerTDS = CType(MyBase.Clone, CustomerTDS)
    cln.InitVars()
    Return cln
  End Function

  Protected Overrides Function ShouldSerializeTables() As Boolean
    Return False
  End Function

  Protected Overrides Function ShouldSerializeRelations() As Boolean
    Return False
  End Function

  Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
    Me.Reset()
    Dim ds As DataSet = New DataSet()
    ds.ReadXml(reader)
    If (Not (ds.Tables("Customer")) Is Nothing) Then
      Me.Tables.Add(New CustomerDataTable(ds.Tables("Customer")))
    End If
    If (Not (ds.Tables("Invoice")) Is Nothing) Then
      Me.Tables.Add(New InvoiceDataTable(ds.Tables("Invoice")))
    End If
    Me.DataSetName = ds.DataSetName
    Me.Prefix = ds.Prefix
    Me.Namespace = ds.Namespace
    Me.Locale = ds.Locale
    Me.CaseSensitive = ds.CaseSensitive
    Me.EnforceConstraints = ds.EnforceConstraints
    Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
    Me.InitVars()
  End Sub

  Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
    Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream()
    Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
    stream.Position = 0
    Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
  End Function

  Friend Sub InitVars()
    Me.tableCustomer = CType(Me.Tables("Customer"), CustomerDataTable)
    If (Not (Me.tableCustomer) Is Nothing) Then
      Me.tableCustomer.InitVars()
    End If
    Me.tableInvoice = CType(Me.Tables("Invoice"), InvoiceDataTable)
    If (Not (Me.tableInvoice) Is Nothing) Then
      Me.tableInvoice.InitVars()
    End If
    Me.relationCustomerInvoice = Me.Relations("CustomerInvoice")
  End Sub

  Private Sub InitClass()
    Me.DataSetName = "CustomerTDS"
    Me.Prefix = ""
    Me.Namespace = "http://tempuri.org/ADONET.xsd"
    Me.Locale = New System.Globalization.CultureInfo("en-US")
    Me.CaseSensitive = False
    Me.EnforceConstraints = True
    Me.tableCustomer = CreateCustomerDataTable(Nothing)
    Me.Tables.Add(Me.tableCustomer)
    Me.tableInvoice = CreateInvoiceDataTable(Nothing)
    Me.Tables.Add(Me.tableInvoice)
    Dim fkc As ForeignKeyConstraint
    fkc = New ForeignKeyConstraint("CustomerInvoice", New DataColumn() {Me.tableCustomer.CustomerIDColumn}, New DataColumn() {Me.tableInvoice.CustomerIDColumn})
    Me.tableInvoice.Constraints.Add(fkc)
    fkc.AcceptRejectRule = AcceptRejectRule.Cascade
    fkc.DeleteRule = Rule.Cascade
    fkc.UpdateRule = Rule.Cascade
    Me.relationCustomerInvoice = New DataRelation("CustomerInvoice", New DataColumn() {Me.tableCustomer.CustomerIDColumn}, New DataColumn() {Me.tableInvoice.CustomerIDColumn}, False)
    Me.Relations.Add(Me.relationCustomerInvoice)
  End Sub

  Private Function ShouldSerializeCustomer() As Boolean
    Return False
  End Function

  Private Function ShouldSerializeInvoice() As Boolean
    Return False
  End Function

  Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
    If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
      Me.InitVars()
    End If
  End Sub

  Public Delegate Sub CustomerRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomerRowChangeEvent)

  Public Delegate Sub InvoiceRowChangeEventHandler(ByVal sender As Object, ByVal e As InvoiceRowChangeEvent)

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class CustomerDataTable
    Inherits DataTable
    Implements System.Collections.IEnumerable

    Private columnCustomerID As DataColumn

    Private columnFirstName As DataColumn

    Private columnLastName As DataColumn

    Private columnMiddleName As DataColumn

    Private columnAddress As DataColumn

    Private columnApartment As DataColumn

    Private columnCity As DataColumn

    Private columnState As DataColumn

    Private columnZip As DataColumn

    Private columnHomePhone As DataColumn

    Private columnBusinessPhone As DataColumn

    Private columnFullName As DataColumn

    Friend Sub New()
      MyBase.New("Customer")
      Me.InitClass()
    End Sub

    Friend Sub New(ByVal table As DataTable)
      MyBase.New(table.TableName)
      If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
        Me.CaseSensitive = table.CaseSensitive
      End If
      If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
        Me.Locale = table.Locale
      End If
      If (table.Namespace <> table.DataSet.Namespace) Then
        Me.Namespace = table.Namespace
      End If
      Me.Prefix = table.Prefix
      Me.MinimumCapacity = table.MinimumCapacity
      Me.DisplayExpression = table.DisplayExpression
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Count() As Integer
      Get
        Return Me.Rows.Count
      End Get
    End Property

    Friend ReadOnly Property CustomerIDColumn() As DataColumn
      Get
        Return Me.columnCustomerID
      End Get
    End Property

    Friend ReadOnly Property FirstNameColumn() As DataColumn
      Get
        Return Me.columnFirstName
      End Get
    End Property

    Friend ReadOnly Property LastNameColumn() As DataColumn
      Get
        Return Me.columnLastName
      End Get
    End Property

    Friend ReadOnly Property MiddleNameColumn() As DataColumn
      Get
        Return Me.columnMiddleName
      End Get
    End Property

    Friend ReadOnly Property AddressColumn() As DataColumn
      Get
        Return Me.columnAddress
      End Get
    End Property

    Friend ReadOnly Property ApartmentColumn() As DataColumn
      Get
        Return Me.columnApartment
      End Get
    End Property

    Friend ReadOnly Property CityColumn() As DataColumn
      Get
        Return Me.columnCity
      End Get
    End Property

    Friend ReadOnly Property StateColumn() As DataColumn
      Get
        Return Me.columnState
      End Get
    End Property

    Friend ReadOnly Property ZipColumn() As DataColumn
      Get
        Return Me.columnZip
      End Get
    End Property

    Friend ReadOnly Property HomePhoneColumn() As DataColumn
      Get
        Return Me.columnHomePhone
      End Get
    End Property

    Friend ReadOnly Property BusinessPhoneColumn() As DataColumn
      Get
        Return Me.columnBusinessPhone
      End Get
    End Property

    Friend ReadOnly Property FullNameColumn() As DataColumn
      Get
        Return Me.columnFullName
      End Get
    End Property

    Default Public ReadOnly Property Item(ByVal index As Integer) As CustomerRow
      Get
        Return CType(Me.Rows(index), CustomerRow)
      End Get
    End Property

    Public Event CustomerRowChanged As CustomerRowChangeEventHandler

    Public Event CustomerRowChanging As CustomerRowChangeEventHandler

    Public Event CustomerRowDeleted As CustomerRowChangeEventHandler

    Public Event CustomerRowDeleting As CustomerRowChangeEventHandler

    Public Overloads Sub AddCustomerRow(ByVal row As CustomerRow)
      Me.Rows.Add(row)
    End Sub

    Public Overloads Function AddCustomerRow(ByVal CustomerID As System.Guid, ByVal FirstName As String, ByVal LastName As String, ByVal MiddleName As String, ByVal Address As String, ByVal Apartment As String, ByVal City As String, ByVal State As String, ByVal Zip As String, ByVal HomePhone As String, ByVal BusinessPhone As String, ByVal FullName As String) As CustomerRow
      Dim rowCustomerRow As CustomerRow = CType(Me.NewRow, CustomerRow)
      rowCustomerRow.ItemArray = New Object() {CustomerID, FirstName, LastName, MiddleName, Address, Apartment, City, State, Zip, HomePhone, BusinessPhone, FullName}
      Me.Rows.Add(rowCustomerRow)
      Return rowCustomerRow
    End Function

    Public Function FindByCustomerID(ByVal CustomerID As System.Guid) As CustomerRow
      Return CType(Me.Rows.Find(New Object() {CustomerID}), CustomerRow)
    End Function

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
      Return Me.Rows.GetEnumerator
    End Function

    Public Overrides Function Clone() As DataTable
      Dim cln As CustomerDataTable = CType(MyBase.Clone, CustomerDataTable)
      cln.InitVars()
      Return cln
    End Function

    Protected Overrides Function CreateInstance() As DataTable
      Return New CustomerDataTable()
    End Function

    Friend Sub InitVars()
      Me.columnCustomerID = Me.Columns("CustomerID")
      Me.columnFirstName = Me.Columns("FirstName")
      Me.columnLastName = Me.Columns("LastName")
      Me.columnMiddleName = Me.Columns("MiddleName")
      Me.columnAddress = Me.Columns("Address")
      Me.columnApartment = Me.Columns("Apartment")
      Me.columnCity = Me.Columns("City")
      Me.columnState = Me.Columns("State")
      Me.columnZip = Me.Columns("Zip")
      Me.columnHomePhone = Me.Columns("HomePhone")
      Me.columnBusinessPhone = Me.Columns("BusinessPhone")
      Me.columnFullName = Me.Columns("FullName")
    End Sub

    Private Sub InitClass()
      Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnCustomerID)
      Me.columnFirstName = New DataColumn("FirstName", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnFirstName)
      Me.columnLastName = New DataColumn("LastName", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnLastName)
      Me.columnMiddleName = New DataColumn("MiddleName", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnMiddleName)
      Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnAddress)
      Me.columnApartment = New DataColumn("Apartment", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnApartment)
      Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnCity)
      Me.columnState = New DataColumn("State", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnState)
      Me.columnZip = New DataColumn("Zip", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnZip)
      Me.columnHomePhone = New DataColumn("HomePhone", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnHomePhone)
      Me.columnBusinessPhone = New DataColumn("BusinessPhone", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnBusinessPhone)
      Me.columnFullName = New DataColumn("FullName", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnFullName)
      Me.Constraints.Add(New UniqueConstraint("ADONETKey1", New DataColumn() {Me.columnCustomerID}, True))
      Me.Constraints.Add(New UniqueConstraint("UniqueHomePhone", New DataColumn() {Me.columnHomePhone, Me.columnBusinessPhone}, False))
      Me.columnCustomerID.AllowDBNull = False
      Me.columnCustomerID.Unique = True
      Me.columnFirstName.AllowDBNull = False
      Me.columnLastName.AllowDBNull = False
      Me.columnFullName.Expression = "LastName + ', ' + FirstName"
      Me.columnFullName.ReadOnly = True
    End Sub

    Public Function NewCustomerRow() As CustomerRow
      Return CType(Me.NewRow, CustomerRow)
    End Function

    Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
      Return New CustomerRow(builder)
    End Function

    Protected Overrides Function GetRowType() As System.Type
      Return GetType(CustomerRow)
    End Function

    Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanged(e)
      If (Not (Me.CustomerRowChangedEvent) Is Nothing) Then
        RaiseEvent CustomerRowChanged(Me, New CustomerRowChangeEvent(CType(e.Row, CustomerRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanging(e)
      If (Not (Me.CustomerRowChangingEvent) Is Nothing) Then
        RaiseEvent CustomerRowChanging(Me, New CustomerRowChangeEvent(CType(e.Row, CustomerRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleted(e)
      If (Not (Me.CustomerRowDeletedEvent) Is Nothing) Then
        RaiseEvent CustomerRowDeleted(Me, New CustomerRowChangeEvent(CType(e.Row, CustomerRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleting(e)
      If (Not (Me.CustomerRowDeletingEvent) Is Nothing) Then
        RaiseEvent CustomerRowDeleting(Me, New CustomerRowChangeEvent(CType(e.Row, CustomerRow), e.Action))
      End If
    End Sub

    Public Sub RemoveCustomerRow(ByVal row As CustomerRow)
      Me.Rows.Remove(row)
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class CustomerRow
    Inherits DataRow

    Private tableCustomer As CustomerDataTable

    Friend Sub New(ByVal rb As DataRowBuilder)
      MyBase.New(rb)
      Me.tableCustomer = CType(Me.Table, CustomerDataTable)
    End Sub

    Public Property CustomerID() As System.Guid
      Get
        Return CType(Me(Me.tableCustomer.CustomerIDColumn), System.Guid)
      End Get
      Set(ByVal Value As System.Guid)
        Me(Me.tableCustomer.CustomerIDColumn) = Value
      End Set
    End Property

    Public Property FirstName() As String
      Get
        Return CType(Me(Me.tableCustomer.FirstNameColumn), String)
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.FirstNameColumn) = Value
      End Set
    End Property

    Public Property LastName() As String
      Get
        Return CType(Me(Me.tableCustomer.LastNameColumn), String)
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.LastNameColumn) = Value
      End Set
    End Property

    Public Property MiddleName() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.MiddleNameColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.MiddleNameColumn) = Value
      End Set
    End Property

    Public Property Address() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.AddressColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.AddressColumn) = Value
      End Set
    End Property

    Public Property Apartment() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.ApartmentColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.ApartmentColumn) = Value
      End Set
    End Property

    Public Property City() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.CityColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.CityColumn) = Value
      End Set
    End Property

    Public Property State() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.StateColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.StateColumn) = Value
      End Set
    End Property

    Public Property Zip() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.ZipColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.ZipColumn) = Value
      End Set
    End Property

    Public Property HomePhone() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.HomePhoneColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.HomePhoneColumn) = Value
      End Set
    End Property

    Public Property BusinessPhone() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.BusinessPhoneColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.BusinessPhoneColumn) = Value
      End Set
    End Property

    Public Property FullName() As String
      Get
        Try
          Return CType(Me(Me.tableCustomer.FullNameColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableCustomer.FullNameColumn) = Value
      End Set
    End Property

    Public Function IsMiddleNameNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.MiddleNameColumn)
    End Function

    Public Sub SetMiddleNameNull()
      Me(Me.tableCustomer.MiddleNameColumn) = System.Convert.DBNull
    End Sub

    Public Function IsAddressNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.AddressColumn)
    End Function

    Public Sub SetAddressNull()
      Me(Me.tableCustomer.AddressColumn) = System.Convert.DBNull
    End Sub

    Public Function IsApartmentNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.ApartmentColumn)
    End Function

    Public Sub SetApartmentNull()
      Me(Me.tableCustomer.ApartmentColumn) = System.Convert.DBNull
    End Sub

    Public Function IsCityNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.CityColumn)
    End Function

    Public Sub SetCityNull()
      Me(Me.tableCustomer.CityColumn) = System.Convert.DBNull
    End Sub

    Public Function IsStateNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.StateColumn)
    End Function

    Public Sub SetStateNull()
      Me(Me.tableCustomer.StateColumn) = System.Convert.DBNull
    End Sub

    Public Function IsZipNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.ZipColumn)
    End Function

    Public Sub SetZipNull()
      Me(Me.tableCustomer.ZipColumn) = System.Convert.DBNull
    End Sub

    Public Function IsHomePhoneNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.HomePhoneColumn)
    End Function

    Public Sub SetHomePhoneNull()
      Me(Me.tableCustomer.HomePhoneColumn) = System.Convert.DBNull
    End Sub

    Public Function IsBusinessPhoneNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.BusinessPhoneColumn)
    End Function

    Public Sub SetBusinessPhoneNull()
      Me(Me.tableCustomer.BusinessPhoneColumn) = System.Convert.DBNull
    End Sub

    Public Function IsFullNameNull() As Boolean
      Return Me.IsNull(Me.tableCustomer.FullNameColumn)
    End Function

    Public Sub SetFullNameNull()
      Me(Me.tableCustomer.FullNameColumn) = System.Convert.DBNull
    End Sub

    Public Function GetInvoiceRows() As InvoiceRow()
      Return CType(Me.GetChildRows(Me.Table.ChildRelations("CustomerInvoice")), InvoiceRow())
    End Function
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class CustomerRowChangeEvent
    Inherits EventArgs

    Private eventRow As CustomerRow

    Private eventAction As DataRowAction

    Public Sub New(ByVal row As CustomerRow, ByVal action As DataRowAction)
      MyBase.New()
      Me.eventRow = row
      Me.eventAction = action
    End Sub

    Public ReadOnly Property Row() As CustomerRow
      Get
        Return Me.eventRow
      End Get
    End Property

    Public ReadOnly Property Action() As DataRowAction
      Get
        Return Me.eventAction
      End Get
    End Property
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class InvoiceDataTable
    Inherits DataTable
    Implements System.Collections.IEnumerable

    Private columnInvoiceID As DataColumn

    Private columnInvoiceNumber As DataColumn

    Private columnInvoiceDate As DataColumn

    Private columnTerms As DataColumn

    Private columnFOB As DataColumn

    Private columnPO As DataColumn

    Private columnCustomerID As DataColumn

    Friend Sub New()
      MyBase.New("Invoice")
      Me.InitClass()
    End Sub

    Friend Sub New(ByVal table As DataTable)
      MyBase.New(table.TableName)
      If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
        Me.CaseSensitive = table.CaseSensitive
      End If
      If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
        Me.Locale = table.Locale
      End If
      If (table.Namespace <> table.DataSet.Namespace) Then
        Me.Namespace = table.Namespace
      End If
      Me.Prefix = table.Prefix
      Me.MinimumCapacity = table.MinimumCapacity
      Me.DisplayExpression = table.DisplayExpression
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Count() As Integer
      Get
        Return Me.Rows.Count
      End Get
    End Property

    Friend ReadOnly Property InvoiceIDColumn() As DataColumn
      Get
        Return Me.columnInvoiceID
      End Get
    End Property

    Friend ReadOnly Property InvoiceNumberColumn() As DataColumn
      Get
        Return Me.columnInvoiceNumber
      End Get
    End Property

    Friend ReadOnly Property InvoiceDateColumn() As DataColumn
      Get
        Return Me.columnInvoiceDate
      End Get
    End Property

    Friend ReadOnly Property TermsColumn() As DataColumn
      Get
        Return Me.columnTerms
      End Get
    End Property

    Friend ReadOnly Property FOBColumn() As DataColumn
      Get
        Return Me.columnFOB
      End Get
    End Property

    Friend ReadOnly Property POColumn() As DataColumn
      Get
        Return Me.columnPO
      End Get
    End Property

    Friend ReadOnly Property CustomerIDColumn() As DataColumn
      Get
        Return Me.columnCustomerID
      End Get
    End Property

    Default Public ReadOnly Property Item(ByVal index As Integer) As InvoiceRow
      Get
        Return CType(Me.Rows(index), InvoiceRow)
      End Get
    End Property

    Public Event InvoiceRowChanged As InvoiceRowChangeEventHandler

    Public Event InvoiceRowChanging As InvoiceRowChangeEventHandler

    Public Event InvoiceRowDeleted As InvoiceRowChangeEventHandler

    Public Event InvoiceRowDeleting As InvoiceRowChangeEventHandler

    Public Overloads Sub AddInvoiceRow(ByVal row As InvoiceRow)
      Me.Rows.Add(row)
    End Sub

    Public Overloads Function AddInvoiceRow(ByVal InvoiceID As System.Guid, ByVal InvoiceDate As Date, ByVal Terms As String, ByVal FOB As String, ByVal PO As String, ByVal parentCustomerRowByCustomerInvoice As CustomerRow) As InvoiceRow
      Dim rowInvoiceRow As InvoiceRow = CType(Me.NewRow, InvoiceRow)
      rowInvoiceRow.ItemArray = New Object() {InvoiceID, Nothing, InvoiceDate, Terms, FOB, PO, parentCustomerRowByCustomerInvoice(0)}
      Me.Rows.Add(rowInvoiceRow)
      Return rowInvoiceRow
    End Function

    Public Function FindByInvoiceID(ByVal InvoiceID As System.Guid) As InvoiceRow
      Return CType(Me.Rows.Find(New Object() {InvoiceID}), InvoiceRow)
    End Function

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
      Return Me.Rows.GetEnumerator
    End Function

    Public Overrides Function Clone() As DataTable
      Dim cln As InvoiceDataTable = CType(MyBase.Clone, InvoiceDataTable)
      cln.InitVars()
      Return cln
    End Function

    Protected Overrides Function CreateInstance() As DataTable
      Return New InvoiceDataTable()
    End Function

    Friend Sub InitVars()
      Me.columnInvoiceID = Me.Columns("InvoiceID")
      Me.columnInvoiceNumber = Me.Columns("InvoiceNumber")
      Me.columnInvoiceDate = Me.Columns("InvoiceDate")
      Me.columnTerms = Me.Columns("Terms")
      Me.columnFOB = Me.Columns("FOB")
      Me.columnPO = Me.Columns("PO")
      Me.columnCustomerID = Me.Columns("CustomerID")
    End Sub

    Private Sub InitClass()
      Me.columnInvoiceID = New DataColumn("InvoiceID", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnInvoiceID)
      Me.columnInvoiceNumber = New DataColumn("InvoiceNumber", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnInvoiceNumber)
      Me.columnInvoiceDate = New DataColumn("InvoiceDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnInvoiceDate)
      Me.columnTerms = New DataColumn("Terms", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnTerms)
      Me.columnFOB = New DataColumn("FOB", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnFOB)
      Me.columnPO = New DataColumn("PO", GetType(System.String), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnPO)
      Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
      Me.Columns.Add(Me.columnCustomerID)
      Me.Constraints.Add(New UniqueConstraint("ADONETKey2", New DataColumn() {Me.columnInvoiceID}, True))
      Me.columnInvoiceID.AllowDBNull = False
      Me.columnInvoiceID.Unique = True
      Me.columnInvoiceNumber.AutoIncrement = True
      Me.columnInvoiceNumber.AllowDBNull = False
      Me.columnInvoiceNumber.ReadOnly = True
      Me.columnInvoiceDate.AllowDBNull = False
    End Sub

    Public Function NewInvoiceRow() As InvoiceRow
      Return CType(Me.NewRow, InvoiceRow)
    End Function

    Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
      Return New InvoiceRow(builder)
    End Function

    Protected Overrides Function GetRowType() As System.Type
      Return GetType(InvoiceRow)
    End Function

    Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanged(e)
      If (Not (Me.InvoiceRowChangedEvent) Is Nothing) Then
        RaiseEvent InvoiceRowChanged(Me, New InvoiceRowChangeEvent(CType(e.Row, InvoiceRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowChanging(e)
      If (Not (Me.InvoiceRowChangingEvent) Is Nothing) Then
        RaiseEvent InvoiceRowChanging(Me, New InvoiceRowChangeEvent(CType(e.Row, InvoiceRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleted(e)
      If (Not (Me.InvoiceRowDeletedEvent) Is Nothing) Then
        RaiseEvent InvoiceRowDeleted(Me, New InvoiceRowChangeEvent(CType(e.Row, InvoiceRow), e.Action))
      End If
    End Sub

    Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
      MyBase.OnRowDeleting(e)
      If (Not (Me.InvoiceRowDeletingEvent) Is Nothing) Then
        RaiseEvent InvoiceRowDeleting(Me, New InvoiceRowChangeEvent(CType(e.Row, InvoiceRow), e.Action))
      End If
    End Sub

    Public Sub RemoveInvoiceRow(ByVal row As InvoiceRow)
      Me.Rows.Remove(row)
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class InvoiceRow
    Inherits DataRow

    Private tableInvoice As InvoiceDataTable

    Friend Sub New(ByVal rb As DataRowBuilder)
      MyBase.New(rb)
      Me.tableInvoice = CType(Me.Table, InvoiceDataTable)
    End Sub

    Public Property InvoiceID() As System.Guid
      Get
        Return CType(Me(Me.tableInvoice.InvoiceIDColumn), System.Guid)
      End Get
      Set(ByVal Value As System.Guid)
        Me(Me.tableInvoice.InvoiceIDColumn) = Value
      End Set
    End Property

    Public Property InvoiceNumber() As Integer
      Get
        Return CType(Me(Me.tableInvoice.InvoiceNumberColumn), Integer)
      End Get
      Set(ByVal Value As Integer)
        Me(Me.tableInvoice.InvoiceNumberColumn) = Value
      End Set
    End Property

    Public Property InvoiceDate() As Date
      Get
        Return CType(Me(Me.tableInvoice.InvoiceDateColumn), Date)
      End Get
      Set(ByVal Value As Date)
        Me(Me.tableInvoice.InvoiceDateColumn) = Value
      End Set
    End Property

    Public Property Terms() As String
      Get
        Try
          Return CType(Me(Me.tableInvoice.TermsColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableInvoice.TermsColumn) = Value
      End Set
    End Property

    Public Property FOB() As String
      Get
        Try
          Return CType(Me(Me.tableInvoice.FOBColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableInvoice.FOBColumn) = Value
      End Set
    End Property

    Public Property PO() As String
      Get
        Try
          Return CType(Me(Me.tableInvoice.POColumn), String)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As String)
        Me(Me.tableInvoice.POColumn) = Value
      End Set
    End Property

    Public Property CustomerID() As System.Guid
      Get
        Try
          Return CType(Me(Me.tableInvoice.CustomerIDColumn), System.Guid)
        Catch e As InvalidCastException
          Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
        End Try
      End Get
      Set(ByVal Value As System.Guid)
        Me(Me.tableInvoice.CustomerIDColumn) = Value
      End Set
    End Property

    Public Property CustomerRow() As CustomerRow
      Get
        Return CType(Me.GetParentRow(Me.Table.ParentRelations("CustomerInvoice")), CustomerRow)
      End Get
      Set(ByVal Value As CustomerRow)
        Me.SetParentRow(Value, Me.Table.ParentRelations("CustomerInvoice"))
      End Set
    End Property

    Public Function IsTermsNull() As Boolean
      Return Me.IsNull(Me.tableInvoice.TermsColumn)
    End Function

    Public Sub SetTermsNull()
      Me(Me.tableInvoice.TermsColumn) = System.Convert.DBNull
    End Sub

    Public Function IsFOBNull() As Boolean
      Return Me.IsNull(Me.tableInvoice.FOBColumn)
    End Function

    Public Sub SetFOBNull()
      Me(Me.tableInvoice.FOBColumn) = System.Convert.DBNull
    End Sub

    Public Function IsPONull() As Boolean
      Return Me.IsNull(Me.tableInvoice.POColumn)
    End Function

    Public Sub SetPONull()
      Me(Me.tableInvoice.POColumn) = System.Convert.DBNull
    End Sub

    Public Function IsCustomerIDNull() As Boolean
      Return Me.IsNull(Me.tableInvoice.CustomerIDColumn)
    End Function

    Public Sub SetCustomerIDNull()
      Me(Me.tableInvoice.CustomerIDColumn) = System.Convert.DBNull
    End Sub
  End Class

  <System.Diagnostics.DebuggerStepThrough()> _
  Public Class InvoiceRowChangeEvent
    Inherits EventArgs

    Private eventRow As InvoiceRow

    Private eventAction As DataRowAction

    Public Sub New(ByVal row As InvoiceRow, ByVal action As DataRowAction)
      MyBase.New()
      Me.eventRow = row
      Me.eventAction = action
    End Sub

    Public ReadOnly Property Row() As InvoiceRow
      Get
        Return Me.eventRow
      End Get
    End Property

    Public ReadOnly Property Action() As DataRowAction
      Get
        Return Me.eventAction
      End Get
    End Property
  End Class
End Class
