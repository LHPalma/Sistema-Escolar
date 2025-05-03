Public Class Aluno

    'Encapsulamento dos campos
    Private _nome As String
    Private _ra As Integer
    Private _cpf As String
    Private _email As String
    Private _senha As String
    Private _turma As String

    'Construtor principal da classe
    Public Sub New(nome As String, ra As Integer, cpf As String, email As String, senha As String, turma As String)
        Me.Nome = nome
        Me.RA = ra
        Me.CPF = cpf
        Me.Email = email
        Me.Senha = senha
        Me.Turma = turma
    End Sub

    'Construtor vazio para outros usos
    Public Sub New()
    End Sub

    'Propriedades públicas para permitir acesso aos dados encapsulados, usando .get e .set

    'Public Property Dado As String
    'Get (Defini o que fazer quando alguém tentar acessar a classe)
    'Return _nome (retorna valor encapsulado)
    'End Get
    'Set(value As String) (Define o que fazer quando alguém tenta modificar o valor, nesse caso modifica o valor interno com value sendo o novo valor)
    ' _nome = value
    'End Set
    'End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("O nome não pode estar vazio.")
            End If
            _nome = value.Trim()
        End Set
    End Property

    Public Property RA As Integer
        Get
            Return _ra
        End Get
        Set(value As Integer)
            If value <= 0 Then
                Throw New Exception("O RA deve ser um número positivo.")
            End If
            _ra = value
        End Set
    End Property

    Public Property CPF As String
        Get
            Return _cpf
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) OrElse value.Length < 11 Then
                Throw New Exception("CPF inválido.")
            End If
            _cpf = value.Trim()
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            If Not value.Contains("@") Then
                Throw New Exception("Email inválido.")
            End If
            _email = value.Trim()
        End Set
    End Property

    Public Property Senha As String
        Get
            Return _senha
        End Get
        Set(value As String)
            _senha = value
        End Set
    End Property

    Public Property Turma As String
        Get
            Return _turma
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("Turma não pode estar vazia.")
            End If
            _turma = value.Trim()
        End Set
    End Property
End Class
