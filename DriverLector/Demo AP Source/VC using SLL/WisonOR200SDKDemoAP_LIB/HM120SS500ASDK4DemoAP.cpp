// HM120SS500ASDK4DemoAP.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "HM120SS500ASDK4DemoAP.h"
#include "HM120SS500ASDK4DemoAPDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char     THIS_FILE[]     = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPApp

BEGIN_MESSAGE_MAP(CHM120SS500ASDK4DemoAPApp, CWinApp)
        //{{AFX_MSG_MAP(CHM120SS500ASDK4DemoAPApp)
                // NOTE - the ClassWizard will add and remove mapping macros here.
                //    DO NOT EDIT what you see in these blocks of generated code!
        //}}AFX_MSG
        ON_COMMAND(ID_HELP, CWinApp::OnHelp)
		 
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPApp construction

CHM120SS500ASDK4DemoAPApp::CHM120SS500ASDK4DemoAPApp() {
    // TODO: add construction code here,
    // Place all significant initialization in InitInstance
}

/////////////////////////////////////////////////////////////////////////////
// The one and only CHM120SS500ASDK4DemoAPApp object

CHM120SS500ASDK4DemoAPApp       theApp;

/////////////////////////////////////////////////////////////////////////////
// CHM120SS500ASDK4DemoAPApp initialization

BOOL
CHM120SS500ASDK4DemoAPApp::InitInstance() {
    // Standard initialization
    // If you are not using these features and wish to reduce the size
    //  of your final executable, you should remove from the following
    //  the specific initialization routines you do not need.

#ifdef _AFXDLL
    Enable3dControls();                 // Call this when using MFC in a shared DLL
#else
    Enable3dControlsStatic();   // Call this when linking to MFC statically
#endif

    CHM120SS500ASDK4DemoAPDlg           dlg;
    m_pMainWnd = &dlg;
    int         nResponse       = dlg.DoModal();
    if (nResponse == IDOK) {
        // TODO: Place code here to handle when the dialog is
        //  dismissed with OK
    } else if (nResponse == IDCANCEL) {
        // TODO: Place code here to handle when the dialog is
        //  dismissed with Cancel
    }

    // Since the dialog has been closed, return FALSE so that we exit the
    //  application, rather than start the application's message pump.
    return FALSE;
}
