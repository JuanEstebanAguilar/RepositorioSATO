Attribute VB_Name = "basDemo"
Option Explicit

Declare Function bAPI4_OpenDevice Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Boolean
Declare Function bAPI4_GetDeviceNum Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Long
Declare Function bAPI4_SelectDevice Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iDevice As Long) As Boolean
Declare Function bAPI4_OpenSensor Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Boolean
Declare Function bAPI4_CloseSensor Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Boolean

Declare Function bAPI4_GetImage Lib "PTSDK4_WISCMOS2_PTFV.dll" (picture As Byte, ByVal timeout As Long, _
                       ByVal iResolution As Long, piWidth As Long, piHeight As Long) As Boolean
    
Declare Function bAPI4_GetBinaryImage Lib "PTSDK4_WISCMOS2_PTFV.dll" (picture As Byte, ByVal timeout As Long, _
                       ByVal iResolution As Long, piWidth As Long, piHeight As Long) As Boolean

'Declare Function bAPI4_ReadSensor Lib "PTSDK4_WISCMOS2_PTFV.dll" (pBuf As Byte) As Boolean
Declare Function bAPI4_StopImage Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Boolean
Declare Function bAPI4_CheckSensorStatus Lib "PTSDK4_WISCMOS2_PTFV.dll" (pbStatus As Boolean) As Boolean
Declare Function bAPI4_HMFVOpenLib Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Boolean
Declare Function bAPI4_HMFVCLoseLib Lib "PTSDK4_WISCMOS2_PTFV.dll" () As Boolean
Declare Function bAPI4_HMFVStartEnroll Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iDefaultEnrolledTimes As Long) As Boolean

Declare Function bAPI4_HMFVEnroll Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iResolution As Long, ByVal iWidth As Long, _
                       ByVal iHeight As Long, pFingerImage As Byte, pEnrolledFeatures As Byte, _
                         pwEnRetSize As Long, piStatus As Long) As Boolean

Declare Function bAPI4_HMFVVerify Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iResolution As Long, ByVal iWidth As Long, _
                       ByVal iHeight As Long, pFingerImage As Byte, pEnrolledFeatures As Byte, _
                       ByVal iEnrolledNum As Long, piMatchedID As Long, piStatus As Long) As Boolean
                       
Declare Function bAPI4_HMFVVerify2 Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iResolution As Long, ByVal iWidth As Long, _
                       ByVal iHeight As Long, pFingerImage As Byte, pEnrolledFeatures As Byte, _
                       ByVal iEnrolledNum As Long, piMatchedID As Long, piStatus As Long) As Boolean

Declare Function bAPI4_HMFVSetParas Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iParaID As Long, ByVal iParaValue As Long) As Boolean
Declare Function bAPI4_HMFVGetParas Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iParaID As Long, piParaValue As Long) As Boolean

Declare Function bAPI4_HMFVExtract Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal iResolution As Long, ByVal iWidth As Long, _
                       ByVal iHeight As Long, pFingerImage As Byte, pFeatures As Byte, _
                         pwFeatSize As Long, piQuality As Byte) As Boolean

Declare Function bAPI4_HMFVVerifyTemplate Lib "PTSDK4_WISCMOS2_PTFV.dll" (pTemplate As Byte, _
                         ppEnrolledfeatures As Byte, iEnrolledNum As Long, piMatchedID As Long, _
                         piStatus As Long) As Boolean

Declare Function bAPI4_SaveImage Lib "PTSDK4_WISCMOS2_PTFV.dll" (ByVal filename As String, ByVal width As Long, _
                                                                 ByVal height As Long, picture As Byte) As Boolean

                       
Global Const MAX_AREA_SIZE = 256

Global Const SENSOR_WIDTH = 256
Global Const SENSOR_HEIGHT = 288
Global Const SENSOR_RESOLUTION = 500
Global Const SENSOR_OK = 1
Global Const SENSOR_SECURITY_AREA_SIZE = 131072

Global Const HMFV_MAX_TEMPLATE_SIZE = 500
Global Const HMFV_LIB_NOT_OPENED = -100

Global Const HMFV_STS_GI_TIMEOUT = -3

Global Const HMFV_STS_EN_CONTINUE = 1
Global Const HMFV_STS_EN_SUCCESS = 0
Global Const HMFV_STS_EN_FAIL = -1
Global Const HMFV_STS_EN_NOINIT = -2
Global Const HMFV_STS_EN_TOOMANY_POORIMG = -3
Global Const HMFV_STS_EN_TOOMAY_TRIALS = -4


Global Const HMFV_STS_VF_SUCCESS = 2
Global Const HMFV_STS_VF_FAIL = 1
Global Const HMFV_STS_VF_POORIMG = -1
Global Const HMFV_STS_VF_ERROR = -2

Global Const PARAID_MATCHTHRESHOLD = 100
Global Const LOW_MATCH_TH = 0
Global Const MID_MATCH_TH = 1
Global Const HIGH_MATCH_TH = 2
Global Const FINGER_ON_TH = 120
 
Global Const MAX_POOR_IMAGE_TOLERANCE = 10
Global Const MAX_ENROLLED_FINGER_NUM = 20


