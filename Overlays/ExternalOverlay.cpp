//Basic Headers
#include <Windows.h>
#include <windowsx.h>
#include <stdio.h>
#include <stdlib.h>
#include <io.h>
#include <fcntl.h>
#include <dwmapi.h>

//DirectX Headers
#include <d3d9.h>
#include <d3dx9.h>


//load DX libs
#pragma comment(lib, "dwmapi.lib")
#pragma comment(lib, "d3d9.lib")
#pragma comment(lib, "d3dx9.lib")

#define WS_EX_LAYERED 0x00080000
#define LWA_ALPHA 0x00000002
#define ARGB_TRANS 0x00000000

LPDIRECT3D9EX d3d;
LPDIRECT3DDEVICE9EX d3ddev;

int w_Width = 800;
int w_Height = 600;

ID3DXFONT *font = 

