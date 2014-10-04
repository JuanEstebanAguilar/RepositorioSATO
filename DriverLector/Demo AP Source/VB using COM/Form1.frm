VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   7605
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10245
   LinkTopic       =   "Form1"
   ScaleHeight     =   7605
   ScaleWidth      =   10245
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "Stop"
      Height          =   855
      Left            =   3480
      TabIndex        =   12
      Top             =   2280
      Width           =   1695
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Identify"
      Height          =   855
      Left            =   3480
      TabIndex        =   11
      Top             =   1320
      Width           =   1695
   End
   Begin VB.OptionButton Option1 
      Height          =   975
      Index           =   2
      Left            =   5520
      TabIndex        =   10
      Top             =   5520
      Width           =   375
   End
   Begin VB.OptionButton Option1 
      Height          =   975
      Index           =   1
      Left            =   5520
      TabIndex        =   9
      Top             =   3120
      Width           =   375
   End
   Begin VB.OptionButton Option1 
      Height          =   975
      Index           =   0
      Left            =   5520
      TabIndex        =   8
      Top             =   840
      Value           =   -1  'True
      Width           =   375
   End
   Begin VB.Frame Finger1 
      Caption         =   "Finger3"
      Height          =   2295
      Index           =   2
      Left            =   6000
      TabIndex        =   6
      Top             =   4920
      Width           =   3855
      Begin VB.TextBox Text1 
         Height          =   1815
         Index           =   2
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   7
         Top             =   240
         Width           =   3495
      End
   End
   Begin VB.Frame Finger1 
      Caption         =   "Finger2"
      Height          =   2295
      Index           =   1
      Left            =   6000
      TabIndex        =   4
      Top             =   2520
      Width           =   3855
      Begin VB.TextBox Text1 
         Height          =   1815
         Index           =   1
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   5
         Top             =   240
         Width           =   3495
      End
   End
   Begin VB.Frame Finger1 
      Caption         =   "Finger1"
      Height          =   2295
      Index           =   0
      Left            =   6000
      TabIndex        =   2
      Top             =   120
      Width           =   3855
      Begin VB.TextBox Text1 
         Height          =   1815
         Index           =   0
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   3
         Top             =   240
         Width           =   3495
      End
   End
   Begin VB.PictureBox Picture1 
      Height          =   3135
      Left            =   120
      ScaleHeight     =   3075
      ScaleWidth      =   2595
      TabIndex        =   1
      Top             =   120
      Width           =   2655
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Enroll"
      Height          =   855
      Left            =   3480
      TabIndex        =   0
      Top             =   360
      Width           =   1695
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private WithEvents m_sensor As WisSensorN
Attribute m_sensor.VB_VarHelpID = -1

Private Sub Command1_Click()
    m_sensor.StartEnroll

End Sub

Private Sub Command2_Click()
    m_sensor.IdentifyCapture
End Sub

Private Sub Command3_Click()
    
    m_sensor.StopCapture
    
End Sub

Private Sub Form_Load()

    Set m_sensor = New WisSensorN
    
    m_sensor.SetDisplay Picture1.hWnd
    
    m_sensor.Open

End Sub

Private Sub Form_Unload(Cancel As Integer)

    m_sensor.Close

    Unload Me
End Sub

Private Function GetRadioIndex()

    If Option1(0) = True Then
        GetRadioIndex = 0
    ElseIf Option1(1) = True Then
        GetRadioIndex = 1
    ElseIf Option1(2) = True Then
        GetRadioIndex = 2
    End If
    
End Function




Private Sub m_sensor_DataEvent(ByVal status As WisSensorNLibLib.Data, ByVal Template As String)
    Select Case status
    
        Case DATA_ENROLL
            Text1(GetRadioIndex).Text = Template
        
        Case DATA_IDENTIFY_CAPTURE
        
            Dim tt(3) As String
            
            tt(0) = Text1(0).Text
            tt(1) = Text1(1).Text
            tt(2) = Text1(2).Text
            
            Index = m_sensor.Identify(Template, tt)
            
            If Index >= 0 Then
                MsgBox "Finger" & (Index + 1)
            Else
                MsgBox "no match"
            End If
            
    
    End Select
End Sub
