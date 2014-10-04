VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Demo Program"
   ClientHeight    =   5760
   ClientLeft      =   2550
   ClientTop       =   1260
   ClientWidth     =   8715
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5760
   ScaleWidth      =   8715
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox Combo1 
      Enabled         =   0   'False
      Height          =   330
      Left            =   4560
      TabIndex        =   14
      Top             =   1440
      Width           =   1815
   End
   Begin VB.CommandButton cmdSaveImage 
      Cancel          =   -1  'True
      Caption         =   "Save Image"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   4560
      TabIndex        =   13
      Top             =   4080
      Width           =   1785
   End
   Begin VB.CommandButton cmdLeave 
      Caption         =   "Leave"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   6600
      TabIndex        =   12
      Top             =   4680
      Visible         =   0   'False
      Width           =   1785
   End
   Begin VB.CommandButton cmdVerifyFinger 
      Caption         =   "Verify Finger"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   6600
      TabIndex        =   11
      Top             =   2280
      Width           =   1785
   End
   Begin VB.CommandButton cmdEnrollFinger 
      Caption         =   "Enroll Finger"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   6600
      TabIndex        =   10
      Top             =   1680
      Width           =   1785
   End
   Begin VB.CommandButton cmdOpenPTFVlib 
      Caption         =   "Open PTFVlib"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   6600
      TabIndex        =   5
      Top             =   480
      Width           =   1785
   End
   Begin VB.CommandButton CmdGetFullImage 
      Caption         =   "Get Full Image"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   4560
      TabIndex        =   4
      Top             =   2760
      Width           =   1785
   End
   Begin VB.PictureBox Picture1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4305
      Left            =   360
      ScaleHeight     =   292.129
      ScaleMode       =   0  'User
      ScaleWidth      =   243
      TabIndex        =   7
      Top             =   480
      Width           =   3705
   End
   Begin VB.CommandButton cmdOpenDevice 
      Caption         =   "Open Device"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   4560
      TabIndex        =   0
      Top             =   480
      Width           =   1785
   End
   Begin VB.CommandButton cmdBin2Original 
      Caption         =   "Binary <==> Gray"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   4560
      TabIndex        =   3
      Top             =   3360
      Width           =   1785
   End
   Begin VB.CommandButton cmdOpenSensor 
      Caption         =   "Open Sensor"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   4560
      TabIndex        =   2
      Top             =   2160
      Width           =   1785
   End
   Begin VB.CommandButton cmdStopGetImage 
      Caption         =   "Stop Getting Image"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   4560
      TabIndex        =   1
      Top             =   4680
      Width           =   1785
   End
   Begin VB.CommandButton cmdStartEnroll 
      Caption         =   "Start Enroll"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   492
      Left            =   6600
      TabIndex        =   6
      Top             =   1080
      Width           =   1785
   End
   Begin VB.Label Label1 
      Caption         =   "Select Device:"
      Height          =   255
      Left            =   4560
      TabIndex        =   15
      Top             =   1200
      Width           =   1215
   End
   Begin VB.Label m_DriveStatus 
      Height          =   255
      Left            =   360
      TabIndex        =   9
      Top             =   5040
      Width           =   3855
   End
   Begin VB.Label Label3 
      Caption         =   "Label2"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   15
      Left            =   0
      TabIndex        =   8
      Top             =   0
      Width           =   135
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim m_iWidth As Long
Dim m_iHeight As Long
Dim bStatus As Boolean
Dim bStatus1 As Boolean
Dim m_pPicture(73727) As Byte
Dim bIsBinary As Boolean
Dim bsweep As Boolean
Dim m_SAbuf(131071) As Byte
Dim pEnrolledFeatures(HMFV_MAX_TEMPLATE_SIZE - 1) As Byte
Dim m_iEnroll As Long
Dim bmpnum As Long
Dim m_iDevice As Long





Private Sub cmdBin2Original_Click()
    Dim r_value As Boolean

    If bIsBinary Then
        bIsBinary = False
        m_DriveStatus.Caption = "Gray Image Mode"
    Else
        bIsBinary = True
        m_DriveStatus.Caption = "Binary Image Mode"
    End If
        
    'Dim buf(260) As Byte
    'r_value = bAPI4_ReadSensor(buf(0))
    
End Sub


Private Sub cmdEnrollFinger_Click()
    Dim iStatus As Long
    Dim iEnSize As Long
    Dim r_value, r_value2 As Boolean
    Dim sensor_timeout As Long
    Dim num As Long
    Dim pEnrolledFeatures(HMFV_MAX_TEMPLATE_SIZE - 1) As Byte
    Dim msg As String
   
    sensor_timeout = 10000
    iStatus = 1
    bsweep = True
            
        
    While (iStatus > 0) And (bsweep = True)
        For num = 0 To 32766
           m_pPicture(num) = 0
        Next num
        For num = 0 To 32766
            m_pPicture(32766 + num) = 0
        Next num
        For num = 0 To 8195
            m_pPicture(65532 + num) = 0
        Next num
        
        
        m_DriveStatus.Caption = "Put your finger on sensor..."
               
        m_iWidth = SENSOR_WIDTH
        m_iHeight = SENSOR_HEIGHT
        
        r_value = bAPI4_GetImage(m_pPicture(0), sensor_timeout, _
                                 SENSOR_RESOLUTION, m_iWidth, m_iHeight)
                                 
        If (r_value = False) Then
            m_DriveStatus.Caption = "Get finger image failed!"
        Else
            m_DriveStatus.Caption = "Get Image OK!"
        End If
                                 
        r_value2 = bAPI4_HMFVEnroll(SENSOR_RESOLUTION, SENSOR_WIDTH, SENSOR_HEIGHT, _
                                  m_pPicture(0), pEnrolledFeatures(0), iEnSize, _
                                  iStatus)
                                  
        If (r_value2 = False) Then
            m_DriveStatus.Caption = "Enrolled error!"
            bsweep = False
        End If
    Wend
    
    
    Select Case (iStatus)
        Case HMFV_STS_EN_SUCCESS
            For num = 0 To HMFV_MAX_TEMPLATE_SIZE - 1
                m_SAbuf(m_iEnroll * HMFV_MAX_TEMPLATE_SIZE + num) = pEnrolledFeatures(num)
            Next num
              
            m_iEnroll = m_iEnroll + 1
            msg = "*** The " & m_iEnroll
            msg = msg + "_st finger enrolled ***"
            
            'If MAX_ENROLLED_FINGER_NUM = m_iEnroll Then
            '    m_iEnroll = m_iEnroll - 1
            'End If
            m_DriveStatus.Caption = msg
            
        
        Case HMFV_STS_EN_TOOMANY_POORIMG
            m_DriveStatus.Caption = "'MAX_POOR_IMAGE_TOLERANCE' of poor image met"
         
        Case HMFV_STS_EN_TOOMAY_TRIALS
            m_DriveStatus.Caption = "Too many useless sweepings (12 times in default)"
        
        Case HMFV_STS_EN_FAIL
            m_DriveStatus.Caption = "Enrolled failed"
        
        Case HMFV_STS_EN_CONTINUE
            m_DriveStatus.Caption = "Button 'Stop Getting Image' pressed"
    End Select
            
        cmdEnrollFinger.Enabled = False
                                             
End Sub

Private Sub CmdGetFullImage_Click()
    Dim r_value As Boolean
    Dim sensor_timeout As Long
    Dim num As Long
    Dim filename As String
   
    sensor_timeout = 30000
    
    For num = 0 To 32766
       m_pPicture(num) = 255
    Next num
    For num = 0 To 32766
        m_pPicture(32766 + num) = 255
    Next num
    For num = 0 To 8195
        m_pPicture(65532 + num) = 255
    Next num
           
    'bIsBinary = True
    
    m_DriveStatus.Caption = "Put your finger on sensor..."

    m_iWidth = SENSOR_WIDTH
    m_iHeight = SENSOR_HEIGHT
                
    If bIsBinary Then
        r_value = bAPI4_GetBinaryImage(m_pPicture(0), sensor_timeout, _
                                       SENSOR_RESOLUTION, m_iWidth, m_iHeight)
    Else
        r_value = bAPI4_GetImage(m_pPicture(0), sensor_timeout, _
                                 SENSOR_RESOLUTION, m_iWidth, m_iHeight)
    End If

    If SENSOR_OK <> r_value Then
        m_DriveStatus.Caption = "Get Image Fail!"
    Else
        m_DriveStatus.Caption = "Get Image OK!"
    End If
    
    filename = "fingerprint.bmp"
    
    r_value = bAPI4_SaveImage(filename, SENSOR_WIDTH, SENSOR_HEIGHT, m_pPicture(0))
    Picture1.picture = LoadPicture(filename)
    
End Sub
'Private Sub Form_Load()
'    Dim bStatus1 As Boolean
'    Dim bStatus2 As Boolean
'    Dim bStatus3 As Boolean
'
'    bStatus1 = bAPI4_StopImage()
'    bStatus2 = bAPI4_CloseSensor()
'    bStatus3 = bAPI4_HMFVCLoseLib()
'
'End Sub
   
Private Sub Form_Unload(Cancel As Integer)

    Dim bStatus1 As Boolean
    Dim bStatus2 As Boolean
    Dim bStatus3 As Boolean
   
    'If MsgBox("Do you want to exit?", vbQuestion + vbYesNo) = vbNo Then
    '    Cancel = -1
    'Else
        bStatus1 = bAPI4_StopImage()
        bStatus2 = bAPI4_CloseSensor()
        bStatus3 = bAPI4_HMFVCLoseLib()
        Unload Me
    'End If
   
End Sub

Private Sub Combo1_Click()
    m_iDevice = Combo1.ItemData(Combo1.ListIndex)
    cmdOpenSensor.Enabled = True
    
    CmdGetFullImage.Enabled = False
    cmdStopGetImage.Enabled = False
    cmdBin2Original.Enabled = False
    cmdOpenPTFVlib.Enabled = False
    cmdSaveImage.Enabled = False
    
    cmdStartEnroll.Enabled = False
    cmdVerifyFinger.Enabled = False
    
End Sub

Private Sub cmdLeave_Click()
    Dim bStatus1 As Boolean
    Dim bStatus2 As Boolean
    Dim bStatus3 As Boolean
    bStatus1 = bAPI4_StopImage()
    bStatus2 = bAPI4_CloseSensor()
    bStatus3 = bAPI4_HMFVCLoseLib()
End Sub

Private Sub cmdOpenDevice_Click()
    Dim devno As Long
    Dim i As Long
    Combo1.Clear
    bStatus = bAPI4_OpenDevice()
    If bStatus Then
        devno = bAPI4_GetDeviceNum()
        For i = 0 To (devno - 1)
            Combo1.AddItem "Device " & i
            Combo1.ItemData(Combo1.NewIndex) = i
        Next i
        Combo1.ListIndex = 0
        Combo1.Enabled = True
        m_DriveStatus.Caption = "Open device OK! Please select device first!"
    Else
        m_DriveStatus.Caption = "Open device Fail"
    End If
End Sub

Private Sub cmdOpenPTFVlib_Click()
    If bAPI4_HMFVOpenLib() Then
        cmdStartEnroll.Enabled = True
        cmdVerifyFinger.Enabled = True
        m_DriveStatus.Caption = "Open PTFVlib OK"
    Else
        m_DriveStatus.Caption = "Open PTFVlib Fail"
    End If
End Sub

Private Sub cmdOpenSensor_Click()
    If bAPI4_OpenSensor() Then
        bStatus = bAPI4_SelectDevice(m_iDevice)
        If bStatus Then
            m_DriveStatus.Caption = "Select and Open " & Combo1.List(Combo1.ListIndex) & " OK"
            bIsBinary = True
        Else
            m_DriveStatus.Caption = "Select and Open " & Combo1.List(Combo1.ListIndex) & " Fail"
        End If

        If bAPI4_HMFVOpenLib() Then
            CmdGetFullImage.Enabled = True
            cmdStopGetImage.Enabled = True
            cmdBin2Original.Enabled = True
            cmdOpenPTFVlib.Enabled = True
            cmdSaveImage.Enabled = True
            
            'm_DriveStatus.Caption = "Open sensor OK"
        Else
            m_DriveStatus.Caption = "Open Library Fail"
        End If
    Else
        m_DriveStatus.Caption = "Open sensor Fail"
    End If
End Sub


Private Sub cmdSaveImage_Click()
    Dim r_value As Boolean
    Dim filename As String
    
    filename = "bmp_" & bmpnum
    filename = filename + ".bmp"
    bmpnum = bmpnum + 1
    
    r_value = bAPI4_SaveImage(filename, SENSOR_WIDTH, SENSOR_HEIGHT, m_pPicture(0))
    
    If SENSOR_OK <> r_value Then
        m_DriveStatus.Caption = "Save Image Fail!"
    Else
        m_DriveStatus.Caption = "Save Image OK!"
    End If
    
End Sub

Private Sub cmdStartEnroll_Click()
    Dim bStatus As Boolean
    Dim msg As String

    If m_iEnroll >= MAX_ENROLLED_FINGER_NUM Then
       msg = "DB is full!"
       Call MsgBox(msg)
       Exit Sub
    End If

    If bAPI4_HMFVStartEnroll(MAX_POOR_IMAGE_TOLERANCE) Then
       cmdEnrollFinger.Enabled = True
    Else
       msg = "Start enroll failed!"
       Call MsgBox(msg)
    End If
    
End Sub

Private Sub cmdStopGetImage_Click()
    Dim bStatus As Boolean
    m_DriveStatus.Caption = "Get image stopped"
    bsweep = False
    bStatus = bAPI4_StopImage()
End Sub



Private Sub cmdVerifyFinger_Click()
    Dim r_value, r_value2 As Boolean
    Dim i, j As Long
    Dim msg As String
    Dim num As Long
    Dim sensor_timeout As Long
    Dim iMatchID As Long
    Dim iStatus As Long
    Dim ppEnrollDB(19, 499) As Byte
    Dim check As Long
    
    iMatchID = 1
    sensor_timeout = 10000

    If (m_iEnroll > 0) Then
        For num = 0 To 32766
           m_pPicture(num) = 0
        Next num
        For num = 0 To 32766
            m_pPicture(32766 + num) = 0
        Next num
        For num = 0 To 8195
            m_pPicture(65532 + num) = 0
        Next num
        
        m_DriveStatus.Caption = "Put your finger on sensor..."
               
        m_iWidth = SENSOR_WIDTH
        m_iHeight = SENSOR_HEIGHT
        
        r_value = bAPI4_GetImage(m_pPicture(0), sensor_timeout, _
                                 SENSOR_RESOLUTION, m_iWidth, m_iHeight)
    
        If (r_value = False) Then
            m_DriveStatus.Caption = "Get finger image failed"
        Else
             m_DriveStatus.Caption = "Get Image OK!"
        End If
        
        
        'ReDim ppEnrollDB(MAX_ENROLLED_FINGER_NUM - 1, HMFV_MAX_TEMPLATE_SIZE - 1) As Byte
        'ReDim ppEnrollDB(19, 499) As Byte
        'For i = 0 To m_iEnroll - 1
        '    For j = 0 To 499
        '        ppEnrollDB(i, j) = m_SAbuf(i * 500 + j)
        '    Next j
        'Next i
                                                                                                      
        r_value2 = bAPI4_HMFVVerify2(SENSOR_RESOLUTION, SENSOR_WIDTH, SENSOR_HEIGHT, _
                                  m_pPicture(0), m_SAbuf(0), m_iEnroll, iMatchID, iStatus)
                                                                                                  
        If (r_value2 = False) Then
            m_DriveStatus.Caption = "Verify error!"
        Else
            If (HMFV_STS_VF_SUCCESS = iStatus) Then
                m_DriveStatus.Caption = "*** Verify Pass! ***"
                msg = "match id = " & iMatchID
                m_DriveStatus.Caption = msg
            Else
                m_DriveStatus.Caption = "Verify failed!"
            End If
        End If
    
    Else
        m_DriveStatus.Caption = "No enrolled fingers"
    End If
                



End Sub

