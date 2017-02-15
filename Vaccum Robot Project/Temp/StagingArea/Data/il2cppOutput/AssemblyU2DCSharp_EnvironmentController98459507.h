#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Text
struct Text_t356221433;
// Room[]
struct RoomU5BU5D_t3311323944;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t3839502067;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EnvironmentController
struct  EnvironmentController_t98459507  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text EnvironmentController::timeText
	Text_t356221433 * ___timeText_2;
	// UnityEngine.UI.Text EnvironmentController::scoreText
	Text_t356221433 * ___scoreText_3;
	// UnityEngine.UI.Text EnvironmentController::performanceMesureText
	Text_t356221433 * ___performanceMesureText_4;
	// UnityEngine.UI.Text EnvironmentController::scoreOverallText
	Text_t356221433 * ___scoreOverallText_5;
	// UnityEngine.UI.Text EnvironmentController::electricityUsedText
	Text_t356221433 * ___electricityUsedText_6;
	// UnityEngine.UI.Text EnvironmentController::dustText
	Text_t356221433 * ___dustText_7;
	// UnityEngine.UI.Text EnvironmentController::jewelText
	Text_t356221433 * ___jewelText_8;
	// UnityEngine.UI.Text EnvironmentController::jewelLostText
	Text_t356221433 * ___jewelLostText_9;
	// System.Int32 EnvironmentController::electricityUsed
	int32_t ___electricityUsed_10;
	// System.Int32 EnvironmentController::nbDust
	int32_t ___nbDust_11;
	// System.Int32 EnvironmentController::nbJewel
	int32_t ___nbJewel_12;
	// System.Int32 EnvironmentController::nbLostJewel
	int32_t ___nbLostJewel_13;
	// System.Single EnvironmentController::startXDust
	float ___startXDust_14;
	// System.Single EnvironmentController::startYDust
	float ___startYDust_15;
	// System.Single EnvironmentController::startXJewel
	float ___startXJewel_16;
	// System.Single EnvironmentController::startYJewel
	float ___startYJewel_17;
	// System.Single EnvironmentController::nextX
	float ___nextX_18;
	// System.Single EnvironmentController::nextY
	float ___nextY_19;
	// System.Int32 EnvironmentController::score
	int32_t ___score_20;
	// System.Int32 EnvironmentController::performanceScore
	int32_t ___performanceScore_21;
	// System.Single EnvironmentController::timeReset
	float ___timeReset_22;
	// System.Single EnvironmentController::performanceMesure
	float ___performanceMesure_23;
	// System.Int32 EnvironmentController::nbRooms
	int32_t ___nbRooms_24;
	// System.Int32 EnvironmentController::nbRoomsLine
	int32_t ___nbRoomsLine_25;
	// Room[] EnvironmentController::rooms
	RoomU5BU5D_t3311323944* ___rooms_26;
	// UnityEngine.GameObject EnvironmentController::dust
	GameObject_t1756533147 * ___dust_27;
	// UnityEngine.GameObject EnvironmentController::jewel
	GameObject_t1756533147 * ___jewel_28;
	// UnityEngine.GameObject[] EnvironmentController::roomDust
	GameObjectU5BU5D_t3057952154* ___roomDust_29;
	// UnityEngine.GameObject[] EnvironmentController::roomJewel
	GameObjectU5BU5D_t3057952154* ___roomJewel_30;
	// System.Single EnvironmentController::timeDelay
	float ___timeDelay_31;
	// UnityEngine.WaitForSeconds EnvironmentController::waitDelay
	WaitForSeconds_t3839502067 * ___waitDelay_32;

public:
	inline static int32_t get_offset_of_timeText_2() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___timeText_2)); }
	inline Text_t356221433 * get_timeText_2() const { return ___timeText_2; }
	inline Text_t356221433 ** get_address_of_timeText_2() { return &___timeText_2; }
	inline void set_timeText_2(Text_t356221433 * value)
	{
		___timeText_2 = value;
		Il2CppCodeGenWriteBarrier(&___timeText_2, value);
	}

	inline static int32_t get_offset_of_scoreText_3() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___scoreText_3)); }
	inline Text_t356221433 * get_scoreText_3() const { return ___scoreText_3; }
	inline Text_t356221433 ** get_address_of_scoreText_3() { return &___scoreText_3; }
	inline void set_scoreText_3(Text_t356221433 * value)
	{
		___scoreText_3 = value;
		Il2CppCodeGenWriteBarrier(&___scoreText_3, value);
	}

	inline static int32_t get_offset_of_performanceMesureText_4() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___performanceMesureText_4)); }
	inline Text_t356221433 * get_performanceMesureText_4() const { return ___performanceMesureText_4; }
	inline Text_t356221433 ** get_address_of_performanceMesureText_4() { return &___performanceMesureText_4; }
	inline void set_performanceMesureText_4(Text_t356221433 * value)
	{
		___performanceMesureText_4 = value;
		Il2CppCodeGenWriteBarrier(&___performanceMesureText_4, value);
	}

	inline static int32_t get_offset_of_scoreOverallText_5() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___scoreOverallText_5)); }
	inline Text_t356221433 * get_scoreOverallText_5() const { return ___scoreOverallText_5; }
	inline Text_t356221433 ** get_address_of_scoreOverallText_5() { return &___scoreOverallText_5; }
	inline void set_scoreOverallText_5(Text_t356221433 * value)
	{
		___scoreOverallText_5 = value;
		Il2CppCodeGenWriteBarrier(&___scoreOverallText_5, value);
	}

	inline static int32_t get_offset_of_electricityUsedText_6() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___electricityUsedText_6)); }
	inline Text_t356221433 * get_electricityUsedText_6() const { return ___electricityUsedText_6; }
	inline Text_t356221433 ** get_address_of_electricityUsedText_6() { return &___electricityUsedText_6; }
	inline void set_electricityUsedText_6(Text_t356221433 * value)
	{
		___electricityUsedText_6 = value;
		Il2CppCodeGenWriteBarrier(&___electricityUsedText_6, value);
	}

	inline static int32_t get_offset_of_dustText_7() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___dustText_7)); }
	inline Text_t356221433 * get_dustText_7() const { return ___dustText_7; }
	inline Text_t356221433 ** get_address_of_dustText_7() { return &___dustText_7; }
	inline void set_dustText_7(Text_t356221433 * value)
	{
		___dustText_7 = value;
		Il2CppCodeGenWriteBarrier(&___dustText_7, value);
	}

	inline static int32_t get_offset_of_jewelText_8() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___jewelText_8)); }
	inline Text_t356221433 * get_jewelText_8() const { return ___jewelText_8; }
	inline Text_t356221433 ** get_address_of_jewelText_8() { return &___jewelText_8; }
	inline void set_jewelText_8(Text_t356221433 * value)
	{
		___jewelText_8 = value;
		Il2CppCodeGenWriteBarrier(&___jewelText_8, value);
	}

	inline static int32_t get_offset_of_jewelLostText_9() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___jewelLostText_9)); }
	inline Text_t356221433 * get_jewelLostText_9() const { return ___jewelLostText_9; }
	inline Text_t356221433 ** get_address_of_jewelLostText_9() { return &___jewelLostText_9; }
	inline void set_jewelLostText_9(Text_t356221433 * value)
	{
		___jewelLostText_9 = value;
		Il2CppCodeGenWriteBarrier(&___jewelLostText_9, value);
	}

	inline static int32_t get_offset_of_electricityUsed_10() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___electricityUsed_10)); }
	inline int32_t get_electricityUsed_10() const { return ___electricityUsed_10; }
	inline int32_t* get_address_of_electricityUsed_10() { return &___electricityUsed_10; }
	inline void set_electricityUsed_10(int32_t value)
	{
		___electricityUsed_10 = value;
	}

	inline static int32_t get_offset_of_nbDust_11() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nbDust_11)); }
	inline int32_t get_nbDust_11() const { return ___nbDust_11; }
	inline int32_t* get_address_of_nbDust_11() { return &___nbDust_11; }
	inline void set_nbDust_11(int32_t value)
	{
		___nbDust_11 = value;
	}

	inline static int32_t get_offset_of_nbJewel_12() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nbJewel_12)); }
	inline int32_t get_nbJewel_12() const { return ___nbJewel_12; }
	inline int32_t* get_address_of_nbJewel_12() { return &___nbJewel_12; }
	inline void set_nbJewel_12(int32_t value)
	{
		___nbJewel_12 = value;
	}

	inline static int32_t get_offset_of_nbLostJewel_13() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nbLostJewel_13)); }
	inline int32_t get_nbLostJewel_13() const { return ___nbLostJewel_13; }
	inline int32_t* get_address_of_nbLostJewel_13() { return &___nbLostJewel_13; }
	inline void set_nbLostJewel_13(int32_t value)
	{
		___nbLostJewel_13 = value;
	}

	inline static int32_t get_offset_of_startXDust_14() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___startXDust_14)); }
	inline float get_startXDust_14() const { return ___startXDust_14; }
	inline float* get_address_of_startXDust_14() { return &___startXDust_14; }
	inline void set_startXDust_14(float value)
	{
		___startXDust_14 = value;
	}

	inline static int32_t get_offset_of_startYDust_15() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___startYDust_15)); }
	inline float get_startYDust_15() const { return ___startYDust_15; }
	inline float* get_address_of_startYDust_15() { return &___startYDust_15; }
	inline void set_startYDust_15(float value)
	{
		___startYDust_15 = value;
	}

	inline static int32_t get_offset_of_startXJewel_16() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___startXJewel_16)); }
	inline float get_startXJewel_16() const { return ___startXJewel_16; }
	inline float* get_address_of_startXJewel_16() { return &___startXJewel_16; }
	inline void set_startXJewel_16(float value)
	{
		___startXJewel_16 = value;
	}

	inline static int32_t get_offset_of_startYJewel_17() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___startYJewel_17)); }
	inline float get_startYJewel_17() const { return ___startYJewel_17; }
	inline float* get_address_of_startYJewel_17() { return &___startYJewel_17; }
	inline void set_startYJewel_17(float value)
	{
		___startYJewel_17 = value;
	}

	inline static int32_t get_offset_of_nextX_18() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nextX_18)); }
	inline float get_nextX_18() const { return ___nextX_18; }
	inline float* get_address_of_nextX_18() { return &___nextX_18; }
	inline void set_nextX_18(float value)
	{
		___nextX_18 = value;
	}

	inline static int32_t get_offset_of_nextY_19() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nextY_19)); }
	inline float get_nextY_19() const { return ___nextY_19; }
	inline float* get_address_of_nextY_19() { return &___nextY_19; }
	inline void set_nextY_19(float value)
	{
		___nextY_19 = value;
	}

	inline static int32_t get_offset_of_score_20() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___score_20)); }
	inline int32_t get_score_20() const { return ___score_20; }
	inline int32_t* get_address_of_score_20() { return &___score_20; }
	inline void set_score_20(int32_t value)
	{
		___score_20 = value;
	}

	inline static int32_t get_offset_of_performanceScore_21() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___performanceScore_21)); }
	inline int32_t get_performanceScore_21() const { return ___performanceScore_21; }
	inline int32_t* get_address_of_performanceScore_21() { return &___performanceScore_21; }
	inline void set_performanceScore_21(int32_t value)
	{
		___performanceScore_21 = value;
	}

	inline static int32_t get_offset_of_timeReset_22() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___timeReset_22)); }
	inline float get_timeReset_22() const { return ___timeReset_22; }
	inline float* get_address_of_timeReset_22() { return &___timeReset_22; }
	inline void set_timeReset_22(float value)
	{
		___timeReset_22 = value;
	}

	inline static int32_t get_offset_of_performanceMesure_23() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___performanceMesure_23)); }
	inline float get_performanceMesure_23() const { return ___performanceMesure_23; }
	inline float* get_address_of_performanceMesure_23() { return &___performanceMesure_23; }
	inline void set_performanceMesure_23(float value)
	{
		___performanceMesure_23 = value;
	}

	inline static int32_t get_offset_of_nbRooms_24() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nbRooms_24)); }
	inline int32_t get_nbRooms_24() const { return ___nbRooms_24; }
	inline int32_t* get_address_of_nbRooms_24() { return &___nbRooms_24; }
	inline void set_nbRooms_24(int32_t value)
	{
		___nbRooms_24 = value;
	}

	inline static int32_t get_offset_of_nbRoomsLine_25() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___nbRoomsLine_25)); }
	inline int32_t get_nbRoomsLine_25() const { return ___nbRoomsLine_25; }
	inline int32_t* get_address_of_nbRoomsLine_25() { return &___nbRoomsLine_25; }
	inline void set_nbRoomsLine_25(int32_t value)
	{
		___nbRoomsLine_25 = value;
	}

	inline static int32_t get_offset_of_rooms_26() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___rooms_26)); }
	inline RoomU5BU5D_t3311323944* get_rooms_26() const { return ___rooms_26; }
	inline RoomU5BU5D_t3311323944** get_address_of_rooms_26() { return &___rooms_26; }
	inline void set_rooms_26(RoomU5BU5D_t3311323944* value)
	{
		___rooms_26 = value;
		Il2CppCodeGenWriteBarrier(&___rooms_26, value);
	}

	inline static int32_t get_offset_of_dust_27() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___dust_27)); }
	inline GameObject_t1756533147 * get_dust_27() const { return ___dust_27; }
	inline GameObject_t1756533147 ** get_address_of_dust_27() { return &___dust_27; }
	inline void set_dust_27(GameObject_t1756533147 * value)
	{
		___dust_27 = value;
		Il2CppCodeGenWriteBarrier(&___dust_27, value);
	}

	inline static int32_t get_offset_of_jewel_28() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___jewel_28)); }
	inline GameObject_t1756533147 * get_jewel_28() const { return ___jewel_28; }
	inline GameObject_t1756533147 ** get_address_of_jewel_28() { return &___jewel_28; }
	inline void set_jewel_28(GameObject_t1756533147 * value)
	{
		___jewel_28 = value;
		Il2CppCodeGenWriteBarrier(&___jewel_28, value);
	}

	inline static int32_t get_offset_of_roomDust_29() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___roomDust_29)); }
	inline GameObjectU5BU5D_t3057952154* get_roomDust_29() const { return ___roomDust_29; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_roomDust_29() { return &___roomDust_29; }
	inline void set_roomDust_29(GameObjectU5BU5D_t3057952154* value)
	{
		___roomDust_29 = value;
		Il2CppCodeGenWriteBarrier(&___roomDust_29, value);
	}

	inline static int32_t get_offset_of_roomJewel_30() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___roomJewel_30)); }
	inline GameObjectU5BU5D_t3057952154* get_roomJewel_30() const { return ___roomJewel_30; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_roomJewel_30() { return &___roomJewel_30; }
	inline void set_roomJewel_30(GameObjectU5BU5D_t3057952154* value)
	{
		___roomJewel_30 = value;
		Il2CppCodeGenWriteBarrier(&___roomJewel_30, value);
	}

	inline static int32_t get_offset_of_timeDelay_31() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___timeDelay_31)); }
	inline float get_timeDelay_31() const { return ___timeDelay_31; }
	inline float* get_address_of_timeDelay_31() { return &___timeDelay_31; }
	inline void set_timeDelay_31(float value)
	{
		___timeDelay_31 = value;
	}

	inline static int32_t get_offset_of_waitDelay_32() { return static_cast<int32_t>(offsetof(EnvironmentController_t98459507, ___waitDelay_32)); }
	inline WaitForSeconds_t3839502067 * get_waitDelay_32() const { return ___waitDelay_32; }
	inline WaitForSeconds_t3839502067 ** get_address_of_waitDelay_32() { return &___waitDelay_32; }
	inline void set_waitDelay_32(WaitForSeconds_t3839502067 * value)
	{
		___waitDelay_32 = value;
		Il2CppCodeGenWriteBarrier(&___waitDelay_32, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
