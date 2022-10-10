#pragma once

#include "IRenderCallback.h"
#include "OverlayFramework.h"

class Overlay : public IRenderCallback
{
public:
	void Setup();
	void Render();
};