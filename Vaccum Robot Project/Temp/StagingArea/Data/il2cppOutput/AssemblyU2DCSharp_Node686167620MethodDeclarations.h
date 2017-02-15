#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// Node
struct Node_t686167620;
// System.Int32[]
struct Int32U5BU5D_t3030399641;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "AssemblyU2DCSharp_Node686167620.h"

// System.Void Node::.ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32[],System.Int32,Node,System.Int32,System.Int32,System.Int32[])
extern "C"  void Node__ctor_m1980757379 (Node_t686167620 * __this, int32_t ___type0, int32_t ___id1, int32_t ___line2, int32_t ___column3, int32_t ___nbRooms4, Int32U5BU5D_t3030399641* ___states5, int32_t ___depth6, Node_t686167620 * ___father7, int32_t ___score8, int32_t ___nbScores9, Int32U5BU5D_t3030399641* ___actionScores10, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String Node::toString()
extern "C"  String_t* Node_toString_m2129931470 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addVaccumUp()
extern "C"  void Node_addVaccumUp_m552701748 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addTake()
extern "C"  void Node_addTake_m1804698553 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addRight()
extern "C"  void Node_addRight_m3623098136 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addLeft()
extern "C"  void Node_addLeft_m1323888565 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addTop()
extern "C"  void Node_addTop_m1171413525 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addBottom()
extern "C"  void Node_addBottom_m4210554665 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::addNothing()
extern "C"  void Node_addNothing_m4035920839 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Node::createChildren()
extern "C"  void Node_createChildren_m3753078148 (Node_t686167620 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
