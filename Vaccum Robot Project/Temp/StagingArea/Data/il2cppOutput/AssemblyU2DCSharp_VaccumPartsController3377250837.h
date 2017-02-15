#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// VaccumController
struct VaccumController_t261250813;
// EnvironmentController
struct EnvironmentController_t98459507;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// VaccumPartsController
struct  VaccumPartsController_t3377250837  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 VaccumPartsController::actionScore
	int32_t ___actionScore_2;
	// System.Single VaccumPartsController::ActionTime
	float ___ActionTime_3;
	// VaccumController VaccumPartsController::vaccumC
	VaccumController_t261250813 * ___vaccumC_4;
	// EnvironmentController VaccumPartsController::environementC
	EnvironmentController_t98459507 * ___environementC_5;

public:
	inline static int32_t get_offset_of_actionScore_2() { return static_cast<int32_t>(offsetof(VaccumPartsController_t3377250837, ___actionScore_2)); }
	inline int32_t get_actionScore_2() const { return ___actionScore_2; }
	inline int32_t* get_address_of_actionScore_2() { return &___actionScore_2; }
	inline void set_actionScore_2(int32_t value)
	{
		___actionScore_2 = value;
	}

	inline static int32_t get_offset_of_ActionTime_3() { return static_cast<int32_t>(offsetof(VaccumPartsController_t3377250837, ___ActionTime_3)); }
	inline float get_ActionTime_3() const { return ___ActionTime_3; }
	inline float* get_address_of_ActionTime_3() { return &___ActionTime_3; }
	inline void set_ActionTime_3(float value)
	{
		___ActionTime_3 = value;
	}

	inline static int32_t get_offset_of_vaccumC_4() { return static_cast<int32_t>(offsetof(VaccumPartsController_t3377250837, ___vaccumC_4)); }
	inline VaccumController_t261250813 * get_vaccumC_4() const { return ___vaccumC_4; }
	inline VaccumController_t261250813 ** get_address_of_vaccumC_4() { return &___vaccumC_4; }
	inline void set_vaccumC_4(VaccumController_t261250813 * value)
	{
		___vaccumC_4 = value;
		Il2CppCodeGenWriteBarrier(&___vaccumC_4, value);
	}

	inline static int32_t get_offset_of_environementC_5() { return static_cast<int32_t>(offsetof(VaccumPartsController_t3377250837, ___environementC_5)); }
	inline EnvironmentController_t98459507 * get_environementC_5() const { return ___environementC_5; }
	inline EnvironmentController_t98459507 ** get_address_of_environementC_5() { return &___environementC_5; }
	inline void set_environementC_5(EnvironmentController_t98459507 * value)
	{
		___environementC_5 = value;
		Il2CppCodeGenWriteBarrier(&___environementC_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
