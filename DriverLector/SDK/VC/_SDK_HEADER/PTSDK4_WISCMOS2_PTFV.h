struct BMPHeader
{
    char bfType[2];       /* "BM" */
    int bfSize;           /* Size of file in bytes */
    int bfReserved;       /* set to 0 */
    int bfOffBits;        /* Byte offset to actual bitmap data (= 54) */
    int biSize;           /* Size of BITMAPINFOHEADER, in bytes (= 40) */
    int biWidth;          /* Width of image, in pixels */
    int biHeight;         /* Height of images, in pixels */
    short biPlanes;       /* Number of planes in target device (set to 1) */
    short biBitCount;     /* Bits per pixel (24 in this case) */
    int biCompression;    /* Type of compression (0 if no compression) */
    int biSizeImage;      /* Image size, in bytes (0 if no compression) */
    int biXPelsPerMeter;  /* Resolution in pixels/meter of display device */
    int biYPelsPerMeter;  /* Resolution in pixels/meter of display device */
    int biClrUsed;        /* Number of colors in the color table (if 0, use 
                             maximum allowed by biBitCount) */
    int biClrImportant;   /* Number of important colors.  If 0, all colors 
                             are important */
};




#if defined(__cplusplus)
extern "C" {
#endif

    BOOL __stdcall bAPI4_OpenDevice();

    BOOL __stdcall bAPI4_OpenSensor();
    int __stdcall bAPI4_GetDeviceNum();
    BOOL __stdcall bAPI4_SelectDevice(int iDevice);
    BOOL __stdcall bAPI4_CloseSensor();

    BOOL __stdcall bAPI4_GetImage(BYTE *picture, int timeout,
                                            int iResolution, int *piWidth,
                                            int *piHeight);
	//added by matt
    BOOL __stdcall bAPI4_GetBinaryImage(BYTE *picture, int timeout,
                                            int iResolution, int *piWidth,
                                            int *piHeight);
	//added by matt
	BOOL __stdcall bAPI4_StartRealtimeImage(int iResolution, 
											int *piWidth, int *piHeight);
	BOOL __stdcall bAPI4_GrabRealtimeImage(BYTE *picture);

	BOOL __stdcall bAPI4_ReadPID(BYTE *pBuf);
	BOOL __stdcall bAPI4_ReadSN(BYTE *pBuf);
	BOOL __stdcall bAPI4_ReadMFS(BYTE *pBuf);
	BOOL __stdcall bAPI4_ReadPDS(BYTE *pBuf);

	BOOL __stdcall bAPI4_ReadInfo(BYTE *pBuf);
	BOOL __stdcall bAPI4_WriteInfo(BYTE *pBuf);

	//added by govert
    BOOL __stdcall bAPI4_StopImage();
    BOOL __stdcall bAPI4_CheckSensorStatus(BOOL *pbStatus);

    BOOL __stdcall bAPI4_HMFVOpenLib();
    BOOL __stdcall bAPI4_HMFVCLoseLib();
    BOOL __stdcall bAPI4_HMFVStartEnroll(int iDefaultEnrolledTimes);
    BOOL __stdcall bAPI4_HMFVEnroll(int iResolution, int iWidth,
                                              int iHeight, BYTE *pFingerImage,
                                              BYTE *pEnrolledFeatures,
                                              DWORD *pwEnRetSize,
                                              int *piStatus);

    BOOL __stdcall bAPI4_HMFVVerify(int iResolution, int iWidth,
                                              int iHeight, BYTE *pFingerImage,
                                              BYTE **ppEnrolledfeatures,
                                              int iEnrolledNum,
                                              int *piMatchedID, int *piStatus);
	//adam_090210
    BOOL __stdcall bAPI4_HMFVVerify2(int iResolution, int iWidth,
                                              int iHeight, BYTE *pFingerImage,
                                              BYTE *ppEnrolledfeatures,
                                              int iEnrolledNum,
                                              int *piMatchedID, int *piStatus);

    BOOL __stdcall bAPI4_HMFVSetParas(int iParaID, int iParaValue);
    BOOL __stdcall bAPI4_HMFVGetParas(int iParaID, int *piParaValue);


	//tommi add
	BOOL __stdcall bAPI4_HMFVExtract(int iResolution, int iWidth, int iHeight, BYTE *pFingerImage, BYTE *pFeatures, DWORD *pwFeatSize, int *piQuality );

	BOOL __stdcall bAPI4_HMFVVerifyTemplate( BYTE *pTemplate, BYTE **ppEnrolledfeatures, int iEnrolledNum, int *piMatchedID, int *piStatus);

	//added by matt for VB image display
	BOOL __stdcall bAPI4_SaveImage(const char *filename, int width, int height, BYTE *rgb);


#if defined(__cplusplus)
}
#endif 


#define MAX_AREA_SIZE				256 

#define SENSOR_WIDTH				256             
#define SENSOR_HEIGHT				288
#define SENSOR_RESOLUTION			500
#define SENSOR_OK					1
#define SENSOR_SECURITY_AREA_SIZE	512*MAX_AREA_SIZE

#define HMFV_MAX_TEMPLATE_SIZE		500
#define HMFV_LIB_NOT_OPENED			-100

#define HMFV_STS_MALLOC_FAIL		-101	//by matt
#define HMFV_STS_GI_TIMEOUT			-3		//tommi add get image timeout

#define HMFV_STS_EN_CONTINUE		1
#define HMFV_STS_EN_SUCCESS			0
#define HMFV_STS_EN_FAIL			-1
#define HMFV_STS_EN_NOINIT			-2
#define HMFV_STS_EN_TOOMANY_POORIMG -3
#define HMFV_STS_EN_TOOMAY_TRIALS	-4


#define HMFV_STS_VF_SUCCESS			2
#define HMFV_STS_VF_FAIL			1
#define HMFV_STS_VF_POORIMG			-1
#define HMFV_STS_VF_ERROR			-2

#define PARAID_MATCHTHRESHOLD		100
#define LOW_MATCH_TH				0
#define MID_MATCH_TH				1
#define HIGH_MATCH_TH				2
#define	FINGER_ON_TH				120		//Hermann add

//eeprom field length
#define		PID_VALUE_SIZE		2
#define		SN_VALUE_SIZE		8
#define		MFS_VALUE_SIZE		16
#define		PDS_VALUE_SIZE		16
#define		INFO_VALUE_SIZE		32


