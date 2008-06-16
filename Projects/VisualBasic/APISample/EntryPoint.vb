﻿Imports System
Imports CodeSmith.Engine
Imports SchemaExplorer




Namespace APISample
    Module EntryPoint
        Sub Main()
            Dim compiler As CodeTemplateCompiler
            compiler = New CodeTemplateCompiler("..\\..\\StoredProcedures.cst")
            compiler.Compile()
            If compiler.Errors.Count = 0 Then
                Dim template As CodeTemplate
                template = compiler.CreateInstance()

                Dim database As DatabaseSchema
                database = New DatabaseSchema(New SqlSchemaProvider(), "Server=(local);Database=Petshop;Integrated Security=true;")
                Dim table As TableSchema
                table = database.Tables("Inventory")

                template.SetProperty("SourceTable", table)
                template.SetProperty("IncludeDrop", False)
                template.SetProperty("InsertPrefix", "Insert")

                template.Render(Console.Out)
            Else
                Dim i As Integer
                For i = 0 To compiler.Errors.Count
                    Console.Error.WriteLine(compiler.Errors(i).ToString())
                    Console.Read()
                Next
            End If
        End Sub
    End Module


End Namespace
