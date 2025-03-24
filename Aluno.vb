Imports System.Threading

Public Class Aluno

    Private _nome As String
    Private _ra As Integer
    Private _cpf As String
    Private _email As String
    Private _senha As String
    Private _turma As String


    Public Sub New()

    End Sub

    Public Sub New(nome As String, ra As Integer, cpf As String, email As String, senha As String, turma As String)
        _nome = nome
        _ra = ra
        _cpf = cpf
        _email = email
        _senha = senha
        _turma = turma

        If nome = "" Then
            Throw New Exception("nome vazio")
        End If

    End Sub





End Class
