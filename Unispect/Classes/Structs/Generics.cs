﻿using System.Runtime.InteropServices;

namespace Unispect
{ 
    public struct MonoGenericClass
    {
        public ulong ContainerClass; // MonoClass 0x0
        public MonoGenericContext Context;
    }

    public struct MonoGenericContext
    {
        public ulong ClassInstance; // MonoGenericInstance
        public ulong MethodInstance;
    }

    public struct MonoGenericInstance
    {
        public int Id;
        public int BitField;

        // If there are instances where the params go over 10, probably want to investigate it manually...
        // Because Something<t1,t2,t3,t4,t5,t6,t7,t8,t9,t10> seems pretty nuts.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ulong[] MonoTypes;
    }
}