// HM120SS500ASDK4DemoAPDlg.cpp : implementation file
//

#include "stdafx.h"
#include "dbt.h"
#include "HM120SS500ASDK4DemoAP.h"
#include "HM120SS500ASDK4DemoAPDlg.h"


#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char     THIS_FILE[]     = __FILE__;
#endif

#define MAX_ENROLLED_FINGER_NUM 20

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPDlg dialog

CHM120SS500ASDK4DemoAPDlg::CHM120SS500ASDK4DemoAPDlg(CWnd *pParent /*=NULL*/) :
    CDialog(CHM120SS500ASDK4DemoAPDlg::IDD, pParent)
{
    //{{AFX_DATA_INIT(CHM120SS500ASDK4DemoAPDlg)
        // NOTE: the ClassWizard will add member initialization here
    //}}AFX_DATA_INIT
    // Note that LoadIcon does not require a subsequent DestroyIcon in Win32
    m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void
CHM120SS500ASDK4DemoAPDlg::DoDataExchange(CDataExchange *pDX) {
    CDialog::DoDataExchange(pDX);
    //{{AFX_DATA_MAP(CHM120SS500ASDK4DemoAPDlg)
	DDX_Control(pDX, IDC_DEVICENUM, m_devicenum);
    DDX_Control(pDX, IDC_DRIVESTATUS, m_status);
	//}}AFX_DATA_MAP


}

BEGIN_MESSAGE_MAP(CHM120SS500ASDK4DemoAPDlg, CDialog)
    //{{AFX_MSG_MAP(CHM120SS500ASDK4DemoAPDlg)
	ON_WM_TIMER()	//added by matt
    ON_WM_PAINT()
    ON_WM_QUERYDRAGICON()
    ON_BN_CLICKED(IDSCAN, OnGetImage)
    ON_BN_CLICKED(IDC_STATUS, OnStatus)
    ON_BN_CLICKED(IDC_SCANS, OnScans)
    ON_BN_CLICKED(IDC_STOP, OnStop)
    ON_BN_CLICKED(IDC_OPENDEVICE, OnOpendevice)
    ON_BN_CLICKED(IDC_OPENSENSOR, OnOpensensor)
    ON_BN_CLICKED(IDC_DOENROLL, OnDoenroll)
    ON_BN_CLICKED(IDC_DOVERIFY, OnDoverify)
    ON_BN_CLICKED(IDC_OPENHMFVLIB, OnOpenhmfvlib)
    ON_BN_CLICKED(IDC_STARTENROLL, OnStartenroll)
	ON_BN_CLICKED(IDC_READPID, OnReadPID)
	ON_BN_CLICKED(IDC_READSN, OnReadSN)
	ON_BN_CLICKED(IDC_READMFS, OnReadMFS)
	ON_BN_CLICKED(IDC_READPDS, OnReadPDS)
	ON_BN_CLICKED(IDC_READINFO, OnReadInfo)
	ON_BN_CLICKED(IDC_WRITEINFO, OnWriteInfo)
	ON_BN_CLICKED(IDC_TEST, OnTest)
	ON_CBN_SELCHANGE(IDC_DEVICENUM, OnSelchangeDevicenum)
	//}}AFX_MSG_MAP
	ON_WM_DEVICECHANGE()
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPDlg message handlers

BOOL
CHM120SS500ASDK4DemoAPDlg::OnInitDialog() {
    CDialog::OnInitDialog();

    // Set the icon for this dialog.  The framework does this automatically
    //  when the application's main window is not a dialog
    SetIcon(m_hIcon, TRUE);                     // Set big icon
    SetIcon(m_hIcon, FALSE);            // Set small icon

    // TODO: Add extra initialization here
    bsweep = 0;    
    m_iEnroll = 0;

	//by matt
    //m_p4Dib = NULL;
    //m_p4BIH = NULL;
    m_pPicture = new BYTE[SENSOR_WIDTH * SENSOR_HEIGHT];
    memset(m_pPicture, 0x00, SENSOR_WIDTH * SENSOR_HEIGHT);
    bIsBinary = TRUE;

    return TRUE;  // return TRUE  unless you set the focus to a control
}

void
CHM120SS500ASDK4DemoAPDlg::OnPaint() {
    if (IsIconic()) {
        CPaintDC        dc      (this); // device context for painting

        SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

        // Center icon in client rectangle
        int     cxIcon  = GetSystemMetrics(SM_CXICON);
        int     cyIcon  = GetSystemMetrics(SM_CYICON);
        CRect   rect;
        GetClientRect(&rect);
        int     x       = (rect.Width() - cxIcon + 1) / 2;
        int     y       = (rect.Height() - cyIcon + 1) / 2;

        // Draw the icon
        dc.DrawIcon(x, y, m_hIcon);
		vDrawFinger();
    } else {
        CDialog::OnPaint();
		vDrawFinger();
    }
}

//added by matt
void CHM120SS500ASDK4DemoAPDlg::OnTimer(UINT nIDEvent) {


	vDrawFinger();
	CDialog::OnTimer(nIDEvent);

}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR
CHM120SS500ASDK4DemoAPDlg::OnQueryDragIcon() {
    return (HCURSOR) m_hIcon;
}

void
CHM120SS500ASDK4DemoAPDlg::BmpHeader4(int iw, int ih) {
	//by matt
	/*
    int         i, abc, ab2, dwSize3, row4, nColumn = iw;

    row4 = ih;
    abc = nColumn * row4 / 65536, ab2 = nColumn * row4 - abc * 65536;
    dwSize3 = 1064 + (nColumn) * row4;

    if (m_p4Dib != NULL) {
        delete[] m_p4Dib;
    }

    m_p4Dib = new unsigned char[dwSize3];

    memset(m_p4Dib, 0x00, sizeof(BITMAPINFOHEADER));

    // biSize
    m_p4Dib[0] = 40;
    m_p4Dib[1] = 0;
    m_p4Dib[2] = 0; 
    m_p4Dib[3] = 0;

    // biWidth
    m_p4Dib[4] = nColumn % 256; 
    m_p4Dib[5] = nColumn / 256;
    m_p4Dib[6] = 0;
    m_p4Dib[7] = 0;

    // biHeight
    m_p4Dib[8] = row4 % 256;
    m_p4Dib[9] = row4 / 256;
    m_p4Dib[10] = 0,
    m_p4Dib[11] = 0;

    // biPlanes
    m_p4Dib[12] = 1;
    m_p4Dib[13] = 0;

    // biBitCount 
    m_p4Dib[14] = 8;
    m_p4Dib[15] = 0;

    // biCompression
    // BI_RGB 0x0L
    m_p4Dib[16] = 0;
    m_p4Dib[17] = 0;
    m_p4Dib[18] = 0;
    m_p4Dib[19] = 0;

    // biSizeImage
    m_p4Dib[20] = 0;
    m_p4Dib[21] = 0;
    m_p4Dib[22] = 0;
    m_p4Dib[23] = 0;

    // biXPelsPerMeter
    m_p4Dib[24] = 229;
    m_p4Dib[25] = 76;
    m_p4Dib[26] = 0;
    m_p4Dib[27] = 0;

    // biYPelsPerMeter
    m_p4Dib[28] = 229;
    m_p4Dib[29] = 76; 
    m_p4Dib[30] = 0; 
    m_p4Dib[31] = 0;

    // biClrUsed
    m_p4Dib[32] = 0,  m_p4Dib[33] = 0, m_p4Dib[34] = 0, m_p4Dib[35] = 0;
    // biClrImportant
    m_p4Dib[36] = 0,  m_p4Dib[37] = 0, m_p4Dib[38] = 0, m_p4Dib[39] = 0;

    for (i = 0; i < 256; i++) {
        m_p4Dib[4 * i + 0 + 40] = (UCHAR) i;
        m_p4Dib[4 * i + 1 + 40] = (UCHAR) i;
        m_p4Dib[4 * i + 2 + 40] = (UCHAR) i;
        m_p4Dib[4 * i + 3 + 40] = 0;
    }
    for (i = 1064; i < dwSize3; i++) {
        m_p4Dib[i] = color;
    }

    m_p4BIH = (BITMAPINFOHEADER *) m_p4Dib;
	*/

	RGBQUAD    palRGB[256];

	//bmp display
	m_BMPInfoHeader.biSize			= 40;
	m_BMPInfoHeader.biWidth			= iw;
	m_BMPInfoHeader.biHeight		= -ih;
	m_BMPInfoHeader.biPlanes		= 1;
	m_BMPInfoHeader.biBitCount		= 8;
	m_BMPInfoHeader.biCompression   = BI_RGB;
	m_BMPInfoHeader.biSizeImage		= (long)(iw)*(ih);
	m_BMPInfoHeader.biXPelsPerMeter = 19685L;
	m_BMPInfoHeader.biYPelsPerMeter = 19685L;
	m_BMPInfoHeader.biClrUsed		= 256L;
	m_BMPInfoHeader.biClrImportant  = 256L;
    
	for(int i = 0; i < 256; i++) 
	{
		palRGB[i].rgbRed      = (unsigned char)i;
		palRGB[i].rgbGreen    = (unsigned char)i;
		palRGB[i].rgbBlue     = (unsigned char)i;
		palRGB[i].rgbReserved = 0;
	}

	memcpy(m_pDib, (BYTE*)&m_BMPInfoHeader, sizeof(BITMAPINFOHEADER));
    memcpy(m_pDib+sizeof(BITMAPINFOHEADER), (BYTE *)palRGB, 256*sizeof(RGBQUAD));

}

void
CHM120SS500ASDK4DemoAPDlg::vDrawFinger() {
    CClientDC           dc      (this);


	//by matt
    //StretchDIBits(dc.m_hDC, 15, 30, SENSOR_WIDTH, SENSOR_HEIGHT, 0, 0,
    //              SENSOR_WIDTH, SENSOR_HEIGHT, m_pPicture,
    //              (BITMAPINFO *) m_p4BIH, DIB_RGB_COLORS, SRCCOPY);
    StretchDIBits(dc.m_hDC, 15, 30, SENSOR_WIDTH, SENSOR_HEIGHT, 0, 0,
                  SENSOR_WIDTH, SENSOR_HEIGHT, m_pPicture,
                  (BITMAPINFO *) m_pDib, DIB_RGB_COLORS, SRCCOPY);
}
/****************************************************************************
*
*   2006_03_03, Werty Lee, Harmony 
*  
*       Sample Function Implementation
*
***************************************************************************/  

void
CHM120SS500ASDK4DemoAPDlg::OnOpendevice() {
    OnSelchangeDevicenum();
	
	if (bAPI4_OpenDevice()) {
        GetDlgItem(IDC_OPENSENSOR)->EnableWindow(TRUE); 
        GetDlgItem(IDC_DEVICENUM)->EnableWindow(TRUE); 
		
		m_devicenum.ResetContent();        
		m_devicenum.SetItemData(0, 0);
				
//		char        drivebuf[5];
        int    DeviceNum;      
		
		DeviceNum = bAPI4_GetDeviceNum();
		
		for (int i = 0; i < DeviceNum; i++) {
			// is drive bit set?
			//if (((1 << i) & iLogicalDrives) != 0) {
				//sprintf(drivebuf, "%c:\\\\", i + 'A');
				//if (GetDriveType(drivebuf) == DRIVE_REMOVABLE) {
                
                CString str;
                
                str.Format(_T("Device %d"), i);
                m_devicenum.AddString(str);
//                m_devicenum.SetItemData(j, i);
//                j++;
                
				//}
			//}
		}		
		m_devicenum.SetCurSel(0);      

        m_status.SetWindowText("Open device OK! Please select device first!");
    } else {
        m_status.SetWindowText("Open device Fail!");
    }
}

void
CHM120SS500ASDK4DemoAPDlg::OnOpensensor() {
    int iDevice;
    iDevice = m_devicenum.GetCurSel();
    if (bAPI4_OpenSensor()) {
		if (bAPI4_SelectDevice(iDevice)) {
			if (bAPI4_HMFVOpenLib()) {
				GetDlgItem(IDSCAN)->EnableWindow(TRUE);
				GetDlgItem(IDC_SCANS)->EnableWindow(TRUE);
				GetDlgItem(IDC_STOP)->EnableWindow(TRUE);
				GetDlgItem(IDC_OPENHMFVLIB)->EnableWindow(TRUE);
				GetDlgItem(IDC_STATUS)->EnableWindow(TRUE);
				m_status.SetWindowText("Select and Open Sensor OK!");
			} else {
				m_status.SetWindowText("Open Library Fail!");
			}
		} else {
			m_status.SetWindowText("Open Sensor Fail!");
		}
	} else {
		m_status.SetWindowText("Open Sensor Fail!");
	}
}

void
CHM120SS500ASDK4DemoAPDlg::OnGetImage() {
    // TODO: Add your control notification handler code here
    char        buf[128];
    BOOL        r_value;   
    int         sensor_timeout  = 30000;    


    memset(m_pPicture, 0xFF, SENSOR_HEIGHT * SENSOR_WIDTH);
    m_status.SetWindowText("Put your finger on sensor...");

    m_iWidth = SENSOR_WIDTH;
    m_iHeight = SENSOR_HEIGHT;

    
    BmpHeader4(m_iWidth, m_iHeight);
	this->InvalidateRect(NULL, TRUE);    
    this->UpdateWindow();

	
    if (bIsBinary) {
        r_value = bAPI4_GetBinaryImage(m_pPicture, sensor_timeout,
                                       SENSOR_RESOLUTION, &m_iWidth,
                                       &m_iHeight);
    } else {
        r_value = bAPI4_GetImage(m_pPicture, sensor_timeout,
                                 SENSOR_RESOLUTION, &m_iWidth, &m_iHeight);
    }
	

    if (SENSOR_OK != r_value) {
		memset(buf, 0, 128);
        sprintf(buf, "GetImage Fail! (%d)", r_value);
        m_status.SetWindowText(buf);
        return;
    } else {
        m_status.SetWindowText("Get Image OK!");
    }

    BmpHeader4(m_iWidth, m_iHeight);
    this->InvalidateRect(NULL, TRUE);    
    this->UpdateWindow();
}

void
CHM120SS500ASDK4DemoAPDlg::OnScans() {
    char        buf[128];
    BOOL        r_value;   
    //int         sensor_timeout  = 30000;    

	/*
	BOOL PTSDK4_WISCMOS2_API bAPI4_StartRealtimeImage(int iResolution, 
											int *piWidth, int *piHeight);
	BOOL PTSDK4_WISCMOS2_API bAPI4_GrabRealtimeImage(BYTE *picture, int timeout);
	BOOL PTSDK4_WISCMOS2_API bAPI4_GrabRealtimeBinaryImage(BYTE *picture, int timeout);
	*/

	//by matt
	r_value = bAPI4_StartRealtimeImage(SENSOR_RESOLUTION, 
											&m_iWidth, &m_iHeight);
	//added by matt
	if(r_value != TRUE) {
		m_status.SetWindowText("Starting error...");
		return;
	}
	SetTimer(1,50,NULL);	//added by matt
	memset(m_pPicture, 0xFF, SENSOR_HEIGHT * SENSOR_WIDTH);
	m_status.SetWindowText("Put your finger on sensor...");

    bsweep = true;
    while (bsweep) {
		//by matt
        //memset(m_pPicture, 0xFF, SENSOR_HEIGHT * SENSOR_WIDTH);
        //m_status.SetWindowText("Put your finger on sensor...");
        //m_iWidth = SENSOR_WIDTH;
        //m_iHeight = SENSOR_HEIGHT;

		//by matt
		/*
        if (bIsBinary) {
            r_value = bAPI4_GetBinaryImage(m_pPicture, sensor_timeout,
                                           SENSOR_RESOLUTION, &m_iWidth,
                                           &m_iHeight);
        } else {
            r_value = bAPI4_GetImage(m_pPicture, sensor_timeout,
                                     SENSOR_RESOLUTION, &m_iWidth, &m_iHeight);
        }
		*/
		r_value = bAPI4_GrabRealtimeImage(m_pPicture);
		//by matt

        if (SENSOR_OK != r_value) {
			memset(buf, 0, 128);
            sprintf(buf, "GetImage Fail! (%d)", r_value);
            m_status.SetWindowText(buf);
			::KillTimer(m_hWnd,1);	//added by matt
			memset(m_pPicture, 0xFF, SENSOR_WIDTH * SENSOR_HEIGHT);	//added by matt
            BmpHeader4(m_iWidth, m_iHeight);
            this->InvalidateRect(NULL, TRUE);    
            this->UpdateWindow();
            return;
        } else {
			//by matt
            //m_status.SetWindowText("Get Image OK!");
        }
        BmpHeader4(m_iWidth, m_iHeight);
        //this->InvalidateRect(NULL, TRUE);    
        //this->UpdateWindow();
        //Sleep(500);

		//added by matt
        MSG     msg;
        // pump-out windows message
        while (PeekMessage(&msg, 0, 0, 0, PM_REMOVE)) {
            TranslateMessage(&msg);  
            DispatchMessage(&msg);
        }

    }
}

void
CHM120SS500ASDK4DemoAPDlg::OnStop() {
    m_status.SetWindowText("Get image stopped");
    bsweep = false;
    bAPI4_StopImage();

	//added by matt
	::KillTimer(m_hWnd,1);
	memset(m_pPicture, 0xFF, SENSOR_WIDTH * SENSOR_HEIGHT);	
    BmpHeader4(m_iWidth, m_iHeight);
    this->InvalidateRect(NULL, TRUE);    
    this->UpdateWindow();

}



void
CHM120SS500ASDK4DemoAPDlg::OnOpenhmfvlib() {
    if (bAPI4_HMFVOpenLib()) {
        GetDlgItem(IDC_STARTENROLL)->EnableWindow(TRUE);
        GetDlgItem(IDC_DOVERIFY)->EnableWindow(TRUE);
        m_status.SetWindowText("Open PTFVlib OK!");
    } else {
        m_status.SetWindowText("Open PTFVlib Fail!");
    }
}

void
CHM120SS500ASDK4DemoAPDlg::OnStartenroll() {
#define MAX_POOR_IMAGE_TOLERANCE 10

	//added by matt
    if (m_iEnroll >= MAX_ENROLLED_FINGER_NUM) {
		MessageBox("DB is full!");
		return;
    }               

    if (bAPI4_HMFVStartEnroll(MAX_POOR_IMAGE_TOLERANCE)) {
        GetDlgItem(IDC_DOENROLL)->EnableWindow(TRUE);
    } else {
        MessageBox("Start enroll failed!");
    }
}

void
CHM120SS500ASDK4DemoAPDlg::OnDoenroll() {
    BYTE        pEnrolledFeatures[HMFV_MAX_TEMPLATE_SIZE];
    int         iStatus         = 1;
    DWORD       iEnSize;
    BOOL        bret;
    int         sensor_timeout  = 10000; 
    char        pctmp[128];

    bsweep = true;
    while ((iStatus > 0) && (bsweep)) {
        memset(m_pPicture, 0x00, SENSOR_HEIGHT * SENSOR_WIDTH);
        m_status.SetWindowText("Put your finger on sensor...");
        m_iWidth = SENSOR_WIDTH;
        m_iHeight = SENSOR_HEIGHT;
        //BmpHeader4(m_iWidth, m_iHeight);	//by matt

        bret = bAPI4_GetImage(m_pPicture, sensor_timeout, SENSOR_RESOLUTION,
                              &m_iWidth, &m_iHeight);    

        if (SENSOR_OK != bret) {
            m_status.SetWindowText("Get finger image failed");
            return ;
        } else {
            m_status.SetWindowText("Get Image OK!");
        }

		BmpHeader4(m_iWidth, m_iHeight);	//added by matt
        this->InvalidateRect(NULL, TRUE);    
        this->UpdateWindow();

        if (!bAPI4_HMFVEnroll(SENSOR_RESOLUTION, SENSOR_WIDTH, SENSOR_HEIGHT,
                              m_pPicture, pEnrolledFeatures, &iEnSize,
                              &iStatus)) {
            m_status.SetWindowText("Enrolled error!");
            bsweep = 0;
			continue;	//added by matt
        }

		//added by matt
		if(iEnSize > HMFV_MAX_TEMPLATE_SIZE)
			m_status.SetWindowText("Enrolled Size over 500!");

    }   

    switch (iStatus) {
      case HMFV_STS_EN_SUCCESS:
        memcpy(m_SAbuf + m_iEnroll * HMFV_MAX_TEMPLATE_SIZE,
               pEnrolledFeatures, HMFV_MAX_TEMPLATE_SIZE);
        m_iEnroll++;
		memset(pctmp, 0, 128);
        sprintf(pctmp, "*** The %d-th finger enrolled ***", m_iEnroll);
		//by matt
        //if (MAX_ENROLLED_FINGER_NUM == m_iEnroll) {
        //    m_iEnroll--;
        //}               
        m_status.SetWindowText(pctmp);
        break;
      case HMFV_STS_EN_TOOMANY_POORIMG:
        m_status.SetWindowText("'MAX_POOR_IMAGE_TOLERANCE' of poor image met");
        break;
      case HMFV_STS_EN_TOOMAY_TRIALS:
        m_status.SetWindowText("Too many useless sweepings (12 times in default)");
        break;
      case HMFV_STS_EN_FAIL:
        m_status.SetWindowText("Enrolled failed");
        break;
      case HMFV_STS_EN_CONTINUE:
        m_status.SetWindowText("Button 'Stop Getting Image' pressed");
        break;
    }

    GetDlgItem(IDC_DOENROLL)->EnableWindow(FALSE);
}

void
CHM120SS500ASDK4DemoAPDlg::OnDoverify() {
    int         i               = 0;
    BYTE        **ppEnrollDB;
    int         iStatus;
    BOOL        bret;
    int         sensor_timeout  = 10000;   
    int         iMatchID        = 0;

    if (m_iEnroll > 0) {
        memset(m_pPicture, 0xFF, SENSOR_HEIGHT * SENSOR_WIDTH);
        m_status.SetWindowText("Put your finger on sensor...");
        m_iWidth = SENSOR_WIDTH;
        m_iHeight = SENSOR_HEIGHT;
        //BmpHeader4(m_iWidth, m_iHeight);	//by matt
        bret = bAPI4_GetImage(m_pPicture, sensor_timeout, SENSOR_RESOLUTION,
                              &m_iWidth, &m_iHeight);    
		//by matt
        //this->InvalidateRect(NULL, TRUE);    
        //this->UpdateWindow();
        if (SENSOR_OK != bret) {
            m_status.SetWindowText("Get finger image failed");
            return ;
        } else {
            m_status.SetWindowText("Get Image OK!");
        }

		BmpHeader4(m_iWidth, m_iHeight);	//added by matt
        this->InvalidateRect(NULL, TRUE);		//added by matt
        this->UpdateWindow();					//added by matt

        ppEnrollDB = new BYTE * [MAX_ENROLLED_FINGER_NUM];
        //int     idx     = 0;
        for (i = 0; i < m_iEnroll; i++) {
            ppEnrollDB[i] = m_SAbuf + i * HMFV_MAX_TEMPLATE_SIZE;
        }

        if (!bAPI4_HMFVVerify(SENSOR_RESOLUTION, SENSOR_WIDTH, SENSOR_HEIGHT,
                              m_pPicture, ppEnrollDB, //Input: «ü¦V enrolled templates
                              m_iEnroll, &iMatchID, &iStatus)) {
            m_status.SetWindowText("Verify error!");
        } else {
            if (HMFV_STS_VF_SUCCESS == iStatus) {
                m_status.SetWindowText("*** Verify Pass! ***");
                char    pctmp[128];
				memset(pctmp, 0, 128);
                sprintf(pctmp, "match id = %d", iMatchID);
                MessageBox(pctmp);
            } else {
                m_status.SetWindowText("Verify failed!");
            }
        }
    } else {
        m_status.SetWindowText("No enrolled fingers");
    }
}

void
CHM120SS500ASDK4DemoAPDlg::OnStatus() {
    if (bIsBinary) {
        bIsBinary = FALSE;
		m_status.SetWindowText("Gray image mode");	//added by matt
    } else {
        bIsBinary = TRUE;
		m_status.SetWindowText("Binary image mode");	//added by matt
    }

    /*
    bAPI4_CloseSensor();
    return;
    BOOL        r_value;
    int         inum;
    char        drives[26];
    bAPI4_GetLogicalDrive(&inum, drives);
    */
    /*
        BOOL        r_value;
          BOOL        bStatus = FALSE;
          r_value = bAPI4_CheckSensorStatus(&bStatus);
          if (SENSOR_OK != r_value) {
              m_status.SetWindowText("CheckDeviceStatus Fail!");
          } else {
              if (bStatus) {
                  m_status.SetWindowText("sensor OK");
              } else {
                  m_status.SetWindowText("sensor failed");
              }
          }
    */

	//by matt
	/*
	//for EEPROM test
    BYTE        buf[MAX_PATH];
    BOOL        r_value;

    r_value = bAPI4_ReadSensor(buf);
    m_status.SetWindowText((char *) buf);
	*/
}

void
CHM120SS500ASDK4DemoAPDlg::OnCancel() {
    // TODO: Add extra cleanup here
    bAPI4_StopImage();
    bAPI4_CloseSensor();
    bAPI4_HMFVCLoseLib();
	::KillTimer(m_hWnd,1);	//added by matt
	delete [] m_pPicture;

    CDialog::OnCancel();
}

/*
void
CHM120SS500ASDK4DemoAPDlg::OnDeviceChange(UINT nEventType, DWORD dwData) {
    return;
}
*/

void CHM120SS500ASDK4DemoAPDlg::OnTest() 
{
	//by matt
	//bAPI4_StopImage();	//added by matt
	//bAPI4_CloseSensor();

	//test by matt
	while(1) {
		OnGetImage();
		Sleep(1000);

        MSG     msg;
        while (PeekMessage(&msg, 0, 0, 0, PM_REMOVE)) {
            TranslateMessage(&msg);  
            DispatchMessage(&msg);
        }
	}
}

void CHM120SS500ASDK4DemoAPDlg::OnReadPID() 
{
	BOOL        r_value;
	BYTE byData[PID_VALUE_SIZE];


	memset(byData, 0, PID_VALUE_SIZE);
    r_value = bAPI4_ReadPID(byData);

    if (r_value) {
		m_status.SetWindowText("Read PID OK");
    } else {
		MessageBox("Read EEPROM FAIL!!","Error",MB_ICONSTOP);
    }	

}

void CHM120SS500ASDK4DemoAPDlg::OnReadSN() 
{
	BOOL        r_value;
	BYTE byData[SN_VALUE_SIZE];


	memset(byData, 0, SN_VALUE_SIZE);
    r_value = bAPI4_ReadSN(byData);

    if (r_value) {
		m_status.SetWindowText("Read Serial Number OK");
    } else {
		MessageBox("Read EEPROM FAIL!!","Error",MB_ICONSTOP);
    }		
}

void CHM120SS500ASDK4DemoAPDlg::OnReadMFS() 
{
	BOOL        r_value;
	BYTE byData[MFS_VALUE_SIZE];


	memset(byData, 0, MFS_VALUE_SIZE);
    r_value = bAPI4_ReadMFS(byData);

    if (r_value) {
		m_status.SetWindowText("Read Manufacturer Info OK");
	} else {
		MessageBox("Read EEPROM FAIL!!","Error",MB_ICONSTOP);
    }		
}

void CHM120SS500ASDK4DemoAPDlg::OnReadPDS() 
{
	BOOL        r_value;
	BYTE byData[PDS_VALUE_SIZE];


	memset(byData, 0, PDS_VALUE_SIZE);
    r_value = bAPI4_ReadPDS(byData);

    if (r_value) {
		m_status.SetWindowText("Read Product Info OK");
	} else {
		MessageBox("Read EEPROM FAIL!!","Error",MB_ICONSTOP);
    }		
}

/*
BOOL
CHM120SS500ASDK4DemoAPDlg::OnDeviceChange(UINT nEventType, DWORD dwData) {
    
	if(nEventType == DBT_DEVICEREMOVECOMPLETE) {            
		MessageBox("Device REMOVE");
	}

	if(nEventType == DBT_DEVICEARRIVAL) {
		MessageBox("Device Arrive");
	}
    
    return true;
}
*/

void CHM120SS500ASDK4DemoAPDlg::OnReadInfo() 
{
	BOOL        r_value;
	BYTE byData[INFO_VALUE_SIZE];


	memset(byData, 0, INFO_VALUE_SIZE);
    r_value = bAPI4_ReadInfo(byData);

    if (r_value) {
		m_status.SetWindowText("Read Customer Defined Info OK");
	} else {
		MessageBox("Read EEPROM FAIL!!","Error",MB_ICONSTOP);
    }		
}

void CHM120SS500ASDK4DemoAPDlg::OnWriteInfo() 
{
	BOOL        r_value;
	BYTE *byData = new BYTE[INFO_VALUE_SIZE];
	BYTE *verifyData = new BYTE[INFO_VALUE_SIZE];

	for(int i = 0; i < INFO_VALUE_SIZE; i++) {	//info to be written
		byData[i] = i + 1;
	}

    r_value = bAPI4_WriteInfo(byData);

    if (r_value) {
		
		//verify
		r_value = bAPI4_ReadInfo(verifyData);
		if(!r_value){
			m_status.SetWindowText("Verify Customer Info Fail!!");
		}
		else {
			for(int i=0; i<INFO_VALUE_SIZE; i+=2) {
				if(byData[i] != verifyData[i+1] || byData[i+1] != verifyData[i]) {
					m_status.SetWindowText("Write Customer Info Fail!!");
					return;
				}
			}
		}
		
		m_status.SetWindowText("Write Customer Info OK");
	} else {
		MessageBox("Write EEPROM FAIL!!","Error",MB_ICONSTOP);
    }		
}


void CHM120SS500ASDK4DemoAPDlg::OnSelchangeDevicenum() 
{
	GetDlgItem(IDSCAN)->EnableWindow(FALSE);
    GetDlgItem(IDC_SCANS)->EnableWindow(FALSE);
    GetDlgItem(IDC_STOP)->EnableWindow(FALSE);
    GetDlgItem(IDC_STATUS)->EnableWindow(FALSE);

    GetDlgItem(IDC_STARTENROLL)->EnableWindow(FALSE);
    GetDlgItem(IDC_DOVERIFY)->EnableWindow(FALSE);
    GetDlgItem(IDC_DOENROLL)->EnableWindow(FALSE);
}
