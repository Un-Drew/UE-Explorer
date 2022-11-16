﻿using UEExplorer.Framework;
using UELib;
using UELib.Core;
using UELib.Engine;
using UELib.Flags;

namespace UEExplorer.UI.Nodes
{
    public sealed class ObjectImageKeySelector : ObjectVisitor<string>
    {
        public override string Visit(IAcceptable visitor)
        {
            string key = Visit((dynamic)visitor);
            return key ?? "Content";
        }

        public string Visit(PackageReference packageReference) => "UnrealPackageFile";

        public string Visit(UnrealPackage linker)
        {
            return "UnrealPackageFile";
        }

        public string Visit(UObject obj)
        {
            return obj.GetType().Name;
        }

        public string Visit(UProperty obj)
        {
            if (obj.HasPropertyFlag(PropertyFlagsLO.ReturnParm)) return "ReturnValue";

            const string key = nameof(UProperty);
            if (obj.IsProtected()) return $"{key}-Protected";

            if (obj.IsPrivate()) return $"{key}-Private";

            return key;
        }

        public string Visit(UScriptStruct obj)
        {
            return nameof(UStruct);
        }

        public string Visit(UFunction obj)
        {
            string key;
            if (obj.HasFunctionFlag(FunctionFlags.Event))
                key = "Event";
            else if (obj.HasFunctionFlag(FunctionFlags.Delegate))
                key = "Delegate";
            else if (obj.HasFunctionFlag(FunctionFlags.Operator))
                key = "Operator";
            else key = nameof(UFunction);

            if (obj.IsProtected()) return $"{key}-Protected";

            if (obj.IsPrivate()) return $"{key}-Private";

            return key;
        }

        public string Visit(UClass obj)
        {
            if (obj.IsClassInterface()) return "Interface";

            if (obj.IsClassWithin()) return "UClass-Within";

            return nameof(UClass);
        }

        public string Visit(USound obj)
        {
            return nameof(USound);
        }

        public string Visit(UFont obj)
        {
            return nameof(UFont);
        }

        public string Visit(AActor obj)
        {
            return nameof(AActor);
        }
    }
}
