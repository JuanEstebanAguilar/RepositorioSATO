// HM120SS500ASDK4DemoAP.h : main header file for the HM120SS500ASDK4DemoAP application
//

#if !defined(AFX_HM120SS500ASDK4DemoAP_H__D992FA60_AA90_4546_9330_594CC18B682F__INCLUDED_)
#define AFX_HM120SS500ASDK4DemoAP_H__D992FA60_AA90_4546_9330_594CC18B682F__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"           // main symbols

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPApp:
// See HM120SS500ASDK4DemoAP.cpp for the implementation of this class
//

class CHM120SS500ASDK4DemoAPApp : public CWinApp {
  public:
        CHM120SS500ASDK4DemoAPApp();

    // Overrides
    // ClassWizard generated virtual function overrides
    //{{AFX_VIRTUAL(CHM120SS500ASDK4DemoAPApp)
    public:
    virtual BOOL InitInstance();
    //}}AFX_VIRTUAL

    // Implementation

    //{{AFX_MSG(CHM120SS500ASDK4DemoAPApp)
        // NOTE - the ClassWizard will add and remove member functions here.
        //    DO NOT EDIT what you see in these blocks of generated code !
    //}}AFX_MSG
        DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_HM120SS500ASDK4DemoAP_H__D992FA60_AA90_4546_9330_594CC18B682F__INCLUDED_)
