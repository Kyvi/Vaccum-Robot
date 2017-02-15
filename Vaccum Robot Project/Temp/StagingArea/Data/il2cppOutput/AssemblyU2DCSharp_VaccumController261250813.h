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
// System.Collections.Generic.List`1<System.Single>
struct List_1_t1445631064;
// System.Int32[]
struct Int32U5BU5D_t3030399641;
// System.Collections.ArrayList
struct ArrayList_t4252133567;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// EnvironmentController
struct EnvironmentController_t98459507;
// CameraController
struct CameraController_t3555666667;
// ArmController
struct ArmController_t864785682;
// LegController
struct LegController_t772807932;
// PipeController
struct PipeController_t1605963564;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t3839502067;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// VaccumController
struct  VaccumController_t261250813  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text VaccumController::depthText
	Text_t356221433 * ___depthText_2;
	// UnityEngine.UI.Text VaccumController::nbActionText
	Text_t356221433 * ___nbActionText_3;
	// UnityEngine.UI.Text VaccumController::nbMovesText
	Text_t356221433 * ___nbMovesText_4;
	// UnityEngine.UI.Text VaccumController::nbVaccumText
	Text_t356221433 * ___nbVaccumText_5;
	// UnityEngine.UI.Text VaccumController::nbTakeText
	Text_t356221433 * ___nbTakeText_6;
	// System.Int32 VaccumController::nbMoves
	int32_t ___nbMoves_7;
	// System.Int32 VaccumController::nbVaccum
	int32_t ___nbVaccum_8;
	// System.Int32 VaccumController::nbTake
	int32_t ___nbTake_9;
	// System.Single VaccumController::startX
	float ___startX_10;
	// System.Single VaccumController::startY
	float ___startY_11;
	// System.Single VaccumController::nextX
	float ___nextX_12;
	// System.Single VaccumController::nextY
	float ___nextY_13;
	// System.Int32 VaccumController::nbActionExecuted
	int32_t ___nbActionExecuted_14;
	// System.Int32 VaccumController::performanceCheckFrequence
	int32_t ___performanceCheckFrequence_15;
	// System.Int32 VaccumController::loopLeft
	int32_t ___loopLeft_16;
	// System.Boolean VaccumController::isMesuresFull
	bool ___isMesuresFull_17;
	// System.Int32 VaccumController::positionCurrentMesure
	int32_t ___positionCurrentMesure_18;
	// System.Int32 VaccumController::nbMesures
	int32_t ___nbMesures_19;
	// System.Collections.Generic.List`1<System.Single> VaccumController::performanceMesures
	List_1_t1445631064 * ___performanceMesures_20;
	// System.Int32 VaccumController::nbScores
	int32_t ___nbScores_21;
	// System.Int32[] VaccumController::actionScores
	Int32U5BU5D_t3030399641* ___actionScores_22;
	// System.Collections.ArrayList VaccumController::actionPlan
	ArrayList_t4252133567 * ___actionPlan_23;
	// UnityEngine.GameObject VaccumController::environment
	GameObject_t1756533147 * ___environment_24;
	// EnvironmentController VaccumController::environmentC
	EnvironmentController_t98459507 * ___environmentC_25;
	// System.Int32 VaccumController::depth
	int32_t ___depth_26;
	// System.Int32 VaccumController::position
	int32_t ___position_27;
	// System.Int32 VaccumController::lineV
	int32_t ___lineV_28;
	// System.Int32 VaccumController::columnV
	int32_t ___columnV_29;
	// System.Int32[] VaccumController::perceipts
	Int32U5BU5D_t3030399641* ___perceipts_30;
	// CameraController VaccumController::cameraC
	CameraController_t3555666667 * ___cameraC_31;
	// ArmController VaccumController::armC
	ArmController_t864785682 * ___armC_32;
	// LegController VaccumController::legC
	LegController_t772807932 * ___legC_33;
	// PipeController VaccumController::pipeC
	PipeController_t1605963564 * ___pipeC_34;
	// UnityEngine.WaitForSeconds VaccumController::cameraC_ActionWait
	WaitForSeconds_t3839502067 * ___cameraC_ActionWait_35;
	// UnityEngine.WaitForSeconds VaccumController::armC_ActionWait
	WaitForSeconds_t3839502067 * ___armC_ActionWait_36;
	// UnityEngine.WaitForSeconds VaccumController::legC_ActionWait
	WaitForSeconds_t3839502067 * ___legC_ActionWait_37;
	// UnityEngine.WaitForSeconds VaccumController::pipeC_ActionWait
	WaitForSeconds_t3839502067 * ___pipeC_ActionWait_38;

public:
	inline static int32_t get_offset_of_depthText_2() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___depthText_2)); }
	inline Text_t356221433 * get_depthText_2() const { return ___depthText_2; }
	inline Text_t356221433 ** get_address_of_depthText_2() { return &___depthText_2; }
	inline void set_depthText_2(Text_t356221433 * value)
	{
		___depthText_2 = value;
		Il2CppCodeGenWriteBarrier(&___depthText_2, value);
	}

	inline static int32_t get_offset_of_nbActionText_3() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbActionText_3)); }
	inline Text_t356221433 * get_nbActionText_3() const { return ___nbActionText_3; }
	inline Text_t356221433 ** get_address_of_nbActionText_3() { return &___nbActionText_3; }
	inline void set_nbActionText_3(Text_t356221433 * value)
	{
		___nbActionText_3 = value;
		Il2CppCodeGenWriteBarrier(&___nbActionText_3, value);
	}

	inline static int32_t get_offset_of_nbMovesText_4() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbMovesText_4)); }
	inline Text_t356221433 * get_nbMovesText_4() const { return ___nbMovesText_4; }
	inline Text_t356221433 ** get_address_of_nbMovesText_4() { return &___nbMovesText_4; }
	inline void set_nbMovesText_4(Text_t356221433 * value)
	{
		___nbMovesText_4 = value;
		Il2CppCodeGenWriteBarrier(&___nbMovesText_4, value);
	}

	inline static int32_t get_offset_of_nbVaccumText_5() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbVaccumText_5)); }
	inline Text_t356221433 * get_nbVaccumText_5() const { return ___nbVaccumText_5; }
	inline Text_t356221433 ** get_address_of_nbVaccumText_5() { return &___nbVaccumText_5; }
	inline void set_nbVaccumText_5(Text_t356221433 * value)
	{
		___nbVaccumText_5 = value;
		Il2CppCodeGenWriteBarrier(&___nbVaccumText_5, value);
	}

	inline static int32_t get_offset_of_nbTakeText_6() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbTakeText_6)); }
	inline Text_t356221433 * get_nbTakeText_6() const { return ___nbTakeText_6; }
	inline Text_t356221433 ** get_address_of_nbTakeText_6() { return &___nbTakeText_6; }
	inline void set_nbTakeText_6(Text_t356221433 * value)
	{
		___nbTakeText_6 = value;
		Il2CppCodeGenWriteBarrier(&___nbTakeText_6, value);
	}

	inline static int32_t get_offset_of_nbMoves_7() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbMoves_7)); }
	inline int32_t get_nbMoves_7() const { return ___nbMoves_7; }
	inline int32_t* get_address_of_nbMoves_7() { return &___nbMoves_7; }
	inline void set_nbMoves_7(int32_t value)
	{
		___nbMoves_7 = value;
	}

	inline static int32_t get_offset_of_nbVaccum_8() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbVaccum_8)); }
	inline int32_t get_nbVaccum_8() const { return ___nbVaccum_8; }
	inline int32_t* get_address_of_nbVaccum_8() { return &___nbVaccum_8; }
	inline void set_nbVaccum_8(int32_t value)
	{
		___nbVaccum_8 = value;
	}

	inline static int32_t get_offset_of_nbTake_9() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbTake_9)); }
	inline int32_t get_nbTake_9() const { return ___nbTake_9; }
	inline int32_t* get_address_of_nbTake_9() { return &___nbTake_9; }
	inline void set_nbTake_9(int32_t value)
	{
		___nbTake_9 = value;
	}

	inline static int32_t get_offset_of_startX_10() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___startX_10)); }
	inline float get_startX_10() const { return ___startX_10; }
	inline float* get_address_of_startX_10() { return &___startX_10; }
	inline void set_startX_10(float value)
	{
		___startX_10 = value;
	}

	inline static int32_t get_offset_of_startY_11() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___startY_11)); }
	inline float get_startY_11() const { return ___startY_11; }
	inline float* get_address_of_startY_11() { return &___startY_11; }
	inline void set_startY_11(float value)
	{
		___startY_11 = value;
	}

	inline static int32_t get_offset_of_nextX_12() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nextX_12)); }
	inline float get_nextX_12() const { return ___nextX_12; }
	inline float* get_address_of_nextX_12() { return &___nextX_12; }
	inline void set_nextX_12(float value)
	{
		___nextX_12 = value;
	}

	inline static int32_t get_offset_of_nextY_13() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nextY_13)); }
	inline float get_nextY_13() const { return ___nextY_13; }
	inline float* get_address_of_nextY_13() { return &___nextY_13; }
	inline void set_nextY_13(float value)
	{
		___nextY_13 = value;
	}

	inline static int32_t get_offset_of_nbActionExecuted_14() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbActionExecuted_14)); }
	inline int32_t get_nbActionExecuted_14() const { return ___nbActionExecuted_14; }
	inline int32_t* get_address_of_nbActionExecuted_14() { return &___nbActionExecuted_14; }
	inline void set_nbActionExecuted_14(int32_t value)
	{
		___nbActionExecuted_14 = value;
	}

	inline static int32_t get_offset_of_performanceCheckFrequence_15() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___performanceCheckFrequence_15)); }
	inline int32_t get_performanceCheckFrequence_15() const { return ___performanceCheckFrequence_15; }
	inline int32_t* get_address_of_performanceCheckFrequence_15() { return &___performanceCheckFrequence_15; }
	inline void set_performanceCheckFrequence_15(int32_t value)
	{
		___performanceCheckFrequence_15 = value;
	}

	inline static int32_t get_offset_of_loopLeft_16() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___loopLeft_16)); }
	inline int32_t get_loopLeft_16() const { return ___loopLeft_16; }
	inline int32_t* get_address_of_loopLeft_16() { return &___loopLeft_16; }
	inline void set_loopLeft_16(int32_t value)
	{
		___loopLeft_16 = value;
	}

	inline static int32_t get_offset_of_isMesuresFull_17() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___isMesuresFull_17)); }
	inline bool get_isMesuresFull_17() const { return ___isMesuresFull_17; }
	inline bool* get_address_of_isMesuresFull_17() { return &___isMesuresFull_17; }
	inline void set_isMesuresFull_17(bool value)
	{
		___isMesuresFull_17 = value;
	}

	inline static int32_t get_offset_of_positionCurrentMesure_18() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___positionCurrentMesure_18)); }
	inline int32_t get_positionCurrentMesure_18() const { return ___positionCurrentMesure_18; }
	inline int32_t* get_address_of_positionCurrentMesure_18() { return &___positionCurrentMesure_18; }
	inline void set_positionCurrentMesure_18(int32_t value)
	{
		___positionCurrentMesure_18 = value;
	}

	inline static int32_t get_offset_of_nbMesures_19() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbMesures_19)); }
	inline int32_t get_nbMesures_19() const { return ___nbMesures_19; }
	inline int32_t* get_address_of_nbMesures_19() { return &___nbMesures_19; }
	inline void set_nbMesures_19(int32_t value)
	{
		___nbMesures_19 = value;
	}

	inline static int32_t get_offset_of_performanceMesures_20() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___performanceMesures_20)); }
	inline List_1_t1445631064 * get_performanceMesures_20() const { return ___performanceMesures_20; }
	inline List_1_t1445631064 ** get_address_of_performanceMesures_20() { return &___performanceMesures_20; }
	inline void set_performanceMesures_20(List_1_t1445631064 * value)
	{
		___performanceMesures_20 = value;
		Il2CppCodeGenWriteBarrier(&___performanceMesures_20, value);
	}

	inline static int32_t get_offset_of_nbScores_21() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___nbScores_21)); }
	inline int32_t get_nbScores_21() const { return ___nbScores_21; }
	inline int32_t* get_address_of_nbScores_21() { return &___nbScores_21; }
	inline void set_nbScores_21(int32_t value)
	{
		___nbScores_21 = value;
	}

	inline static int32_t get_offset_of_actionScores_22() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___actionScores_22)); }
	inline Int32U5BU5D_t3030399641* get_actionScores_22() const { return ___actionScores_22; }
	inline Int32U5BU5D_t3030399641** get_address_of_actionScores_22() { return &___actionScores_22; }
	inline void set_actionScores_22(Int32U5BU5D_t3030399641* value)
	{
		___actionScores_22 = value;
		Il2CppCodeGenWriteBarrier(&___actionScores_22, value);
	}

	inline static int32_t get_offset_of_actionPlan_23() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___actionPlan_23)); }
	inline ArrayList_t4252133567 * get_actionPlan_23() const { return ___actionPlan_23; }
	inline ArrayList_t4252133567 ** get_address_of_actionPlan_23() { return &___actionPlan_23; }
	inline void set_actionPlan_23(ArrayList_t4252133567 * value)
	{
		___actionPlan_23 = value;
		Il2CppCodeGenWriteBarrier(&___actionPlan_23, value);
	}

	inline static int32_t get_offset_of_environment_24() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___environment_24)); }
	inline GameObject_t1756533147 * get_environment_24() const { return ___environment_24; }
	inline GameObject_t1756533147 ** get_address_of_environment_24() { return &___environment_24; }
	inline void set_environment_24(GameObject_t1756533147 * value)
	{
		___environment_24 = value;
		Il2CppCodeGenWriteBarrier(&___environment_24, value);
	}

	inline static int32_t get_offset_of_environmentC_25() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___environmentC_25)); }
	inline EnvironmentController_t98459507 * get_environmentC_25() const { return ___environmentC_25; }
	inline EnvironmentController_t98459507 ** get_address_of_environmentC_25() { return &___environmentC_25; }
	inline void set_environmentC_25(EnvironmentController_t98459507 * value)
	{
		___environmentC_25 = value;
		Il2CppCodeGenWriteBarrier(&___environmentC_25, value);
	}

	inline static int32_t get_offset_of_depth_26() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___depth_26)); }
	inline int32_t get_depth_26() const { return ___depth_26; }
	inline int32_t* get_address_of_depth_26() { return &___depth_26; }
	inline void set_depth_26(int32_t value)
	{
		___depth_26 = value;
	}

	inline static int32_t get_offset_of_position_27() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___position_27)); }
	inline int32_t get_position_27() const { return ___position_27; }
	inline int32_t* get_address_of_position_27() { return &___position_27; }
	inline void set_position_27(int32_t value)
	{
		___position_27 = value;
	}

	inline static int32_t get_offset_of_lineV_28() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___lineV_28)); }
	inline int32_t get_lineV_28() const { return ___lineV_28; }
	inline int32_t* get_address_of_lineV_28() { return &___lineV_28; }
	inline void set_lineV_28(int32_t value)
	{
		___lineV_28 = value;
	}

	inline static int32_t get_offset_of_columnV_29() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___columnV_29)); }
	inline int32_t get_columnV_29() const { return ___columnV_29; }
	inline int32_t* get_address_of_columnV_29() { return &___columnV_29; }
	inline void set_columnV_29(int32_t value)
	{
		___columnV_29 = value;
	}

	inline static int32_t get_offset_of_perceipts_30() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___perceipts_30)); }
	inline Int32U5BU5D_t3030399641* get_perceipts_30() const { return ___perceipts_30; }
	inline Int32U5BU5D_t3030399641** get_address_of_perceipts_30() { return &___perceipts_30; }
	inline void set_perceipts_30(Int32U5BU5D_t3030399641* value)
	{
		___perceipts_30 = value;
		Il2CppCodeGenWriteBarrier(&___perceipts_30, value);
	}

	inline static int32_t get_offset_of_cameraC_31() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___cameraC_31)); }
	inline CameraController_t3555666667 * get_cameraC_31() const { return ___cameraC_31; }
	inline CameraController_t3555666667 ** get_address_of_cameraC_31() { return &___cameraC_31; }
	inline void set_cameraC_31(CameraController_t3555666667 * value)
	{
		___cameraC_31 = value;
		Il2CppCodeGenWriteBarrier(&___cameraC_31, value);
	}

	inline static int32_t get_offset_of_armC_32() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___armC_32)); }
	inline ArmController_t864785682 * get_armC_32() const { return ___armC_32; }
	inline ArmController_t864785682 ** get_address_of_armC_32() { return &___armC_32; }
	inline void set_armC_32(ArmController_t864785682 * value)
	{
		___armC_32 = value;
		Il2CppCodeGenWriteBarrier(&___armC_32, value);
	}

	inline static int32_t get_offset_of_legC_33() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___legC_33)); }
	inline LegController_t772807932 * get_legC_33() const { return ___legC_33; }
	inline LegController_t772807932 ** get_address_of_legC_33() { return &___legC_33; }
	inline void set_legC_33(LegController_t772807932 * value)
	{
		___legC_33 = value;
		Il2CppCodeGenWriteBarrier(&___legC_33, value);
	}

	inline static int32_t get_offset_of_pipeC_34() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___pipeC_34)); }
	inline PipeController_t1605963564 * get_pipeC_34() const { return ___pipeC_34; }
	inline PipeController_t1605963564 ** get_address_of_pipeC_34() { return &___pipeC_34; }
	inline void set_pipeC_34(PipeController_t1605963564 * value)
	{
		___pipeC_34 = value;
		Il2CppCodeGenWriteBarrier(&___pipeC_34, value);
	}

	inline static int32_t get_offset_of_cameraC_ActionWait_35() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___cameraC_ActionWait_35)); }
	inline WaitForSeconds_t3839502067 * get_cameraC_ActionWait_35() const { return ___cameraC_ActionWait_35; }
	inline WaitForSeconds_t3839502067 ** get_address_of_cameraC_ActionWait_35() { return &___cameraC_ActionWait_35; }
	inline void set_cameraC_ActionWait_35(WaitForSeconds_t3839502067 * value)
	{
		___cameraC_ActionWait_35 = value;
		Il2CppCodeGenWriteBarrier(&___cameraC_ActionWait_35, value);
	}

	inline static int32_t get_offset_of_armC_ActionWait_36() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___armC_ActionWait_36)); }
	inline WaitForSeconds_t3839502067 * get_armC_ActionWait_36() const { return ___armC_ActionWait_36; }
	inline WaitForSeconds_t3839502067 ** get_address_of_armC_ActionWait_36() { return &___armC_ActionWait_36; }
	inline void set_armC_ActionWait_36(WaitForSeconds_t3839502067 * value)
	{
		___armC_ActionWait_36 = value;
		Il2CppCodeGenWriteBarrier(&___armC_ActionWait_36, value);
	}

	inline static int32_t get_offset_of_legC_ActionWait_37() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___legC_ActionWait_37)); }
	inline WaitForSeconds_t3839502067 * get_legC_ActionWait_37() const { return ___legC_ActionWait_37; }
	inline WaitForSeconds_t3839502067 ** get_address_of_legC_ActionWait_37() { return &___legC_ActionWait_37; }
	inline void set_legC_ActionWait_37(WaitForSeconds_t3839502067 * value)
	{
		___legC_ActionWait_37 = value;
		Il2CppCodeGenWriteBarrier(&___legC_ActionWait_37, value);
	}

	inline static int32_t get_offset_of_pipeC_ActionWait_38() { return static_cast<int32_t>(offsetof(VaccumController_t261250813, ___pipeC_ActionWait_38)); }
	inline WaitForSeconds_t3839502067 * get_pipeC_ActionWait_38() const { return ___pipeC_ActionWait_38; }
	inline WaitForSeconds_t3839502067 ** get_address_of_pipeC_ActionWait_38() { return &___pipeC_ActionWait_38; }
	inline void set_pipeC_ActionWait_38(WaitForSeconds_t3839502067 * value)
	{
		___pipeC_ActionWait_38 = value;
		Il2CppCodeGenWriteBarrier(&___pipeC_ActionWait_38, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
