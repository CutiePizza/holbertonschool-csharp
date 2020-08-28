using System;

    class Obj
    {
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            if (!(derivedType != baseType && derivedType.IsSubclassOf(baseType)))
                return (false);
            else
                return (true);
        }
    }
