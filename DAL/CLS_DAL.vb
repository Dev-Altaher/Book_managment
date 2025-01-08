Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace LibM.DAL
    Public Class CLS_DAL
        ' تعريف الاتصال بقاعدة البيانات
        Private con As SqlConnection

        ' مهيئ الفئة لإعداد الاتصال
        Public Sub New()
            ' تعيين سلسلة الاتصال لقاعدة البيانات
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Book managment\DBLIBM.mdf;Integrated Security=True")
        End Sub

        ' طريقة لفتح الاتصال بقاعدة البيانات
        Public Sub Open()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        End Sub

        ' طريقة لإغلاق الاتصال بقاعدة البيانات
        Public Sub Close()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Sub

        ' دالة لقراءة البيانات باستخدام إجراء مخزن
        Public Function Read(store As String, pr As SqlParameter()) As DataTable
            ' إنشاء SqlCommand
            Dim cmd As New SqlCommand()
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = store

            ' إذا كانت هناك معاملات، إضافتها إلى الأمر
            If pr IsNot Nothing Then
                cmd.Parameters.AddRange(pr)
            End If

            ' تعبئة البيانات في DataTable
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            Return dt
        End Function

        ' دالة لتنفيذ عمليات الإضافة والتعديل والحذف
        Public Sub Execute(store As String, pr As SqlParameter())
            ' إنشاء SqlCommand
            Dim cmd As New SqlCommand()
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = store

            ' إذا كانت هناك معاملات، إضافتها إلى الأمر
            If pr IsNot Nothing Then
                cmd.Parameters.AddRange(pr)
            End If

            ' تنفيذ الأمر
            cmd.ExecuteNonQuery()
        End Sub
    End Class
End Namespace