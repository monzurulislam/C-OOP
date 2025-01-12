﻿Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq

' You can add custom code to this file. Changes will not be overwritten.
' 
' If you want Entity Framework to drop and regenerate your database
' automatically whenever you change your model schema, add the following
' code to the Application_Start method in your Global.asax file.
' Note: this will destroy and re-create your database with every model change.
' 
' System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MvcApplication1.Models.TodoItemContext>());
Public Class TodoItemContext
    Inherits DbContext
    
    Public Sub New() 
        MyBase.New("name=DefaultConnection")
    End Sub

    Public Property TodoItems As DbSet(Of TodoItem)
    Public Property TodoLists As DbSet(Of TodoList)
End Class
