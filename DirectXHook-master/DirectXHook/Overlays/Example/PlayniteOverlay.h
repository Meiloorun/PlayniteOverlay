#pragma once

#include "IRenderCallback.h"
#include "OverlayFramework.h"

class PlayniteOverlay : public IRenderCallback
{
public:
	void Setup();
	void Render();

private:
	OF::Box* box;
};