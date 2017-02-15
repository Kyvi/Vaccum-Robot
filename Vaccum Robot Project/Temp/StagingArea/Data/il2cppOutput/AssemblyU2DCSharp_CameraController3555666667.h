#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Room[]
struct RoomU5BU5D_t3311323944;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CameraController
struct  CameraController_t3555666667  : public MonoBehaviour_t1158329972
{
public:
	// System.Single CameraController::ActionTime
	float ___ActionTime_2;
	// Room[] CameraController::rooms
	RoomU5BU5D_t3311323944* ___rooms_3;

public:
	inline static int32_t get_offset_of_ActionTime_2() { return static_cast<int32_t>(offsetof(CameraController_t3555666667, ___ActionTime_2)); }
	inline float get_ActionTime_2() const { return ___ActionTime_2; }
	inline float* get_address_of_ActionTime_2() { return &___ActionTime_2; }
	inline void set_ActionTime_2(float value)
	{
		___ActionTime_2 = value;
	}

	inline static int32_t get_offset_of_rooms_3() { return static_cast<int32_t>(offsetof(CameraController_t3555666667, ___rooms_3)); }
	inline RoomU5BU5D_t3311323944* get_rooms_3() const { return ___rooms_3; }
	inline RoomU5BU5D_t3311323944** get_address_of_rooms_3() { return &___rooms_3; }
	inline void set_rooms_3(RoomU5BU5D_t3311323944* value)
	{
		___rooms_3 = value;
		Il2CppCodeGenWriteBarrier(&___rooms_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
