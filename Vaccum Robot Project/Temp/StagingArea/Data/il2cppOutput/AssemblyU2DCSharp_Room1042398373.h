#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "mscorlib_System_Object2689449295.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Room
struct  Room_t1042398373  : public Il2CppObject
{
public:
	// System.Int32 Room::ID
	int32_t ___ID_0;
	// System.Int32 Room::state
	int32_t ___state_1;
	// System.Int32 Room::lineR
	int32_t ___lineR_2;
	// System.Int32 Room::columnR
	int32_t ___columnR_3;
	// System.Single Room::dustProbability
	float ___dustProbability_4;
	// System.Single Room::jewelProbability
	float ___jewelProbability_5;

public:
	inline static int32_t get_offset_of_ID_0() { return static_cast<int32_t>(offsetof(Room_t1042398373, ___ID_0)); }
	inline int32_t get_ID_0() const { return ___ID_0; }
	inline int32_t* get_address_of_ID_0() { return &___ID_0; }
	inline void set_ID_0(int32_t value)
	{
		___ID_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(Room_t1042398373, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}

	inline static int32_t get_offset_of_lineR_2() { return static_cast<int32_t>(offsetof(Room_t1042398373, ___lineR_2)); }
	inline int32_t get_lineR_2() const { return ___lineR_2; }
	inline int32_t* get_address_of_lineR_2() { return &___lineR_2; }
	inline void set_lineR_2(int32_t value)
	{
		___lineR_2 = value;
	}

	inline static int32_t get_offset_of_columnR_3() { return static_cast<int32_t>(offsetof(Room_t1042398373, ___columnR_3)); }
	inline int32_t get_columnR_3() const { return ___columnR_3; }
	inline int32_t* get_address_of_columnR_3() { return &___columnR_3; }
	inline void set_columnR_3(int32_t value)
	{
		___columnR_3 = value;
	}

	inline static int32_t get_offset_of_dustProbability_4() { return static_cast<int32_t>(offsetof(Room_t1042398373, ___dustProbability_4)); }
	inline float get_dustProbability_4() const { return ___dustProbability_4; }
	inline float* get_address_of_dustProbability_4() { return &___dustProbability_4; }
	inline void set_dustProbability_4(float value)
	{
		___dustProbability_4 = value;
	}

	inline static int32_t get_offset_of_jewelProbability_5() { return static_cast<int32_t>(offsetof(Room_t1042398373, ___jewelProbability_5)); }
	inline float get_jewelProbability_5() const { return ___jewelProbability_5; }
	inline float* get_address_of_jewelProbability_5() { return &___jewelProbability_5; }
	inline void set_jewelProbability_5(float value)
	{
		___jewelProbability_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
