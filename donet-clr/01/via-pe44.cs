using System;

// 告诉编译器检查CLS相容性
[assembly: CLSCompliant(true)]

namespace SomeLibrary
{
    // 因为是public类, 所以会显示警告
    public sealed class SomeLibraryType
    {
        // 警告: SomeLibrary.SomeLibraryType.Abc()的返回类型不符合CLS
        public UInt32 Abc()
        {
            return 0;
        }
        
        // 警告: 仅大小写不同的标识符SomeLibrary.SomeLibraryType.abc()
        // 不符合CLS
        public void abc() { }
        
        // 不会显示警告: 该方法是私有的
        private UInt32 ABC() 
        { 
            return 0;
        }
    }
}