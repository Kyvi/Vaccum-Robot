#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Node
struct Node_t686167620;
// System.Collections.Generic.List`1<Node>
struct List_1_t55288752;
// System.Int32[]
struct Int32U5BU5D_t3030399641;

#include "mscorlib_System_Object2689449295.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Node
struct  Node_t686167620  : public Il2CppObject
{
public:
	// System.Int32 Node::id
	int32_t ___id_0;
	// System.Int32 Node::score
	int32_t ___score_1;
	// System.Int32 Node::type
	int32_t ___type_2;
	// System.Int32 Node::line
	int32_t ___line_3;
	// System.Int32 Node::column
	int32_t ___column_4;
	// System.Int32 Node::depth
	int32_t ___depth_5;
	// Node Node::father
	Node_t686167620 * ___father_6;
	// System.Collections.Generic.List`1<Node> Node::children
	List_1_t55288752 * ___children_7;
	// System.Int32 Node::nbRooms
	int32_t ___nbRooms_8;
	// System.Int32[] Node::states
	Int32U5BU5D_t3030399641* ___states_9;
	// System.Int32 Node::nbScores
	int32_t ___nbScores_10;
	// System.Int32[] Node::actionScores
	Int32U5BU5D_t3030399641* ___actionScores_11;

public:
	inline static int32_t get_offset_of_id_0() { return static_cast<int32_t>(offsetof(Node_t686167620, ___id_0)); }
	inline int32_t get_id_0() const { return ___id_0; }
	inline int32_t* get_address_of_id_0() { return &___id_0; }
	inline void set_id_0(int32_t value)
	{
		___id_0 = value;
	}

	inline static int32_t get_offset_of_score_1() { return static_cast<int32_t>(offsetof(Node_t686167620, ___score_1)); }
	inline int32_t get_score_1() const { return ___score_1; }
	inline int32_t* get_address_of_score_1() { return &___score_1; }
	inline void set_score_1(int32_t value)
	{
		___score_1 = value;
	}

	inline static int32_t get_offset_of_type_2() { return static_cast<int32_t>(offsetof(Node_t686167620, ___type_2)); }
	inline int32_t get_type_2() const { return ___type_2; }
	inline int32_t* get_address_of_type_2() { return &___type_2; }
	inline void set_type_2(int32_t value)
	{
		___type_2 = value;
	}

	inline static int32_t get_offset_of_line_3() { return static_cast<int32_t>(offsetof(Node_t686167620, ___line_3)); }
	inline int32_t get_line_3() const { return ___line_3; }
	inline int32_t* get_address_of_line_3() { return &___line_3; }
	inline void set_line_3(int32_t value)
	{
		___line_3 = value;
	}

	inline static int32_t get_offset_of_column_4() { return static_cast<int32_t>(offsetof(Node_t686167620, ___column_4)); }
	inline int32_t get_column_4() const { return ___column_4; }
	inline int32_t* get_address_of_column_4() { return &___column_4; }
	inline void set_column_4(int32_t value)
	{
		___column_4 = value;
	}

	inline static int32_t get_offset_of_depth_5() { return static_cast<int32_t>(offsetof(Node_t686167620, ___depth_5)); }
	inline int32_t get_depth_5() const { return ___depth_5; }
	inline int32_t* get_address_of_depth_5() { return &___depth_5; }
	inline void set_depth_5(int32_t value)
	{
		___depth_5 = value;
	}

	inline static int32_t get_offset_of_father_6() { return static_cast<int32_t>(offsetof(Node_t686167620, ___father_6)); }
	inline Node_t686167620 * get_father_6() const { return ___father_6; }
	inline Node_t686167620 ** get_address_of_father_6() { return &___father_6; }
	inline void set_father_6(Node_t686167620 * value)
	{
		___father_6 = value;
		Il2CppCodeGenWriteBarrier(&___father_6, value);
	}

	inline static int32_t get_offset_of_children_7() { return static_cast<int32_t>(offsetof(Node_t686167620, ___children_7)); }
	inline List_1_t55288752 * get_children_7() const { return ___children_7; }
	inline List_1_t55288752 ** get_address_of_children_7() { return &___children_7; }
	inline void set_children_7(List_1_t55288752 * value)
	{
		___children_7 = value;
		Il2CppCodeGenWriteBarrier(&___children_7, value);
	}

	inline static int32_t get_offset_of_nbRooms_8() { return static_cast<int32_t>(offsetof(Node_t686167620, ___nbRooms_8)); }
	inline int32_t get_nbRooms_8() const { return ___nbRooms_8; }
	inline int32_t* get_address_of_nbRooms_8() { return &___nbRooms_8; }
	inline void set_nbRooms_8(int32_t value)
	{
		___nbRooms_8 = value;
	}

	inline static int32_t get_offset_of_states_9() { return static_cast<int32_t>(offsetof(Node_t686167620, ___states_9)); }
	inline Int32U5BU5D_t3030399641* get_states_9() const { return ___states_9; }
	inline Int32U5BU5D_t3030399641** get_address_of_states_9() { return &___states_9; }
	inline void set_states_9(Int32U5BU5D_t3030399641* value)
	{
		___states_9 = value;
		Il2CppCodeGenWriteBarrier(&___states_9, value);
	}

	inline static int32_t get_offset_of_nbScores_10() { return static_cast<int32_t>(offsetof(Node_t686167620, ___nbScores_10)); }
	inline int32_t get_nbScores_10() const { return ___nbScores_10; }
	inline int32_t* get_address_of_nbScores_10() { return &___nbScores_10; }
	inline void set_nbScores_10(int32_t value)
	{
		___nbScores_10 = value;
	}

	inline static int32_t get_offset_of_actionScores_11() { return static_cast<int32_t>(offsetof(Node_t686167620, ___actionScores_11)); }
	inline Int32U5BU5D_t3030399641* get_actionScores_11() const { return ___actionScores_11; }
	inline Int32U5BU5D_t3030399641** get_address_of_actionScores_11() { return &___actionScores_11; }
	inline void set_actionScores_11(Int32U5BU5D_t3030399641* value)
	{
		___actionScores_11 = value;
		Il2CppCodeGenWriteBarrier(&___actionScores_11, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
