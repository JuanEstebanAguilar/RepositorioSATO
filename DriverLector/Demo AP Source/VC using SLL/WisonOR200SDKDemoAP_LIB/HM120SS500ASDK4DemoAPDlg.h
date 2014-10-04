// HM120SS500ASDK4DemoAPDlg.h : header file
//

#if !defined(AFX_HM120SS500ASDK4DemoAPDLG_H__E87C5B34_5E50_4C52_BB4E_0BC12F0A4D64__INCLUDED_)
#define AFX_HM120SS500ASDK4DemoAPDLG_H__E87C5B34_5E50_4C52_BB4E_0BC12F0A4D64__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "..\\_SDK_HEADER\\PTSDK4_WISCMOS2_PTFV.h"

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPDlg dialog

class CHM120SS500ASDK4DemoAPDlg : public CDialog {
    // Construction
  public:
                        CHM120SS500ASDK4DemoAPDlg(CWnd *pParent = NULL);     // standard constructor

    bool                bsweep;
	BOOL				bIsBinary;

    BYTE                m_iEnroll;
    BYTE                m_SAbuf[SENSOR_SECURITY_AREA_SIZE];

    // for scan image
    void                BmpHeader4(int iW, int iH);
    BYTE                *m_pPicture;

	//by matt
    //BYTE                *m_p4Dib;		
    //BITMAPINFOHEADER    *m_p4BIH;
	BYTE				m_pDib[1078];
	BITMAPINFOHEADER	m_BMPInfoHeader;
	//by matt

    int                 m_iWidth;
    int                 m_iHeight;
    void                vDrawFinger();

    // Dialog Data
    //{{AFX_DATA(CHM120SS500ASDK4DemoAPDlg)
	enum { IDD = IDD_HM120SS500ASDK4DemoAP_DIALOG };
	CComboBox	m_devicenum;
    CStatic     m_status;
	//}}AFX_DATA

    // ClassWizard generated virtual function overrides
    //{{AFX_VIRTUAL(CHM120SS500ASDK4DemoAPDlg)
    protected:
    virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
    //}}AFX_VIRTUAL

    // Implementation
  protected:
    HICON               m_hIcon;

    // Generated message map functions
    //{{AFX_MSG(CHM120SS500ASDK4DemoAPDlg)
    virtual BOOL OnInitDialog();
	afx_msg void OnTimer(UINT nIDEvent);	//added by matt
    afx_msg void OnPaint();
    afx_msg HCURSOR OnQueryDragIcon();
    afx_msg void OnGetImage();
    afx_msg void OnStatus();
    virtual void OnCancel();
    afx_msg void OnScans();
    afx_msg void OnStop();
    afx_msg void OnOpendevice();
    afx_msg void OnOpensensor();
    afx_msg void OnDoenroll();
    afx_msg void OnDoverify();
    afx_msg void OnOpenhmfvlib();
    afx_msg void OnStartenroll();
	afx_msg void OnReadPID();
	afx_msg void OnReadSN();
	afx_msg void OnReadMFS();
	afx_msg void OnReadPDS();
	afx_msg void OnReadInfo();
	afx_msg void OnWriteInfo();
	afx_msg void OnTest();
	afx_msg void OnSelchangeDevicenum();
	//}}AFX_MSG
	//afx_msg BOOL        OnDeviceChange(UINT nEventType, DWORD dwData);  
                        DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_HM120SS500ASDK4DemoAPDLG_H__E87C5B34_5E50_4C52_BB4E_0BC12F0A4D64__INCLUDED_)
