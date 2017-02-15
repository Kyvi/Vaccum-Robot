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

#include "mscorlib_System_Object2689449295.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Graph
struct  Graph_t2735713688  : public Il2CppObject
{
public:
	// Node Graph::root
	Node_t686167620 * ___root_0;
	// System.Int32 Graph::depth
	int32_t ___depth_1;
	// System.Collections.Generic.List`1<Node> Graph::graphNodes
	List_1_t55288752 * ___graphNodes_2;

public:
	inline static int32_t get_offset_of_root_0() { return static_cast<int32_t>(offsetof(Graph_t2735713688, ___root_0)); }
	inline Node_t686167620 * get_root_0() const { return ___root_0; }
	inline Node_t686167620 ** get_address_of_root_0() { return &___root_0; }
	inline void set_root_0(Node_t686167620 * value)
	{
		___root_0 = value;
		Il2CppCodeGenWriteBarrier(&___root_0, value);
	}

	inline static int32_t get_offset_of_depth_1() { return static_cast<int32_t>(offsetof(Graph_t2735713688, ___depth_1)); }
	inline int32_t get_depth_1() const { return ___depth_1; }
	inline int32_t* get_address_of_depth_1() { return &___depth_1; }
	inline void set_depth_1(int32_t value)
	{
		___depth_1 = value;
	}

	inline static int32_t get_offset_of_graphNodes_2() { return static_cast<int32_t>(offsetof(Graph_t2735713688, ___graphNodes_2)); }
	inline List_1_t55288752 * get_graphNodes_2() const { return ___graphNodes_2; }
	inline List_1_t55288752 ** get_address_of_graphNodes_2() { return &___graphNodes_2; }
	inline void set_graphNodes_2(List_1_t55288752 * value)
	{
		___graphNodes_2 = value;
		Il2CppCodeGenWriteBarrier(&___graphNodes_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
