/**********************************************************************/
/***                                                                ***/
/*** This file is automatically generated; edits will be ignored.   ***/
/***                                                                ***/
/**********************************************************************/
public partial class ReTypeProviderRegistry {
    public static ReTypeAotData Provider_FooType = new ReTypeAotData {
        ProviderFor = typeof(FooType),
        FieldAotData = new[] {
            new ReField.AotData {
                FieldName = "Foo",
                Read = (o) => ((FooType)o).Foo,
                Write = (ref object o, object v) => ((FooType)o).Foo = (int)v
            },
            new ReField.AotData {
                FieldName = "Bar",
                Read = (o) => ((FooType)o).Bar,
                Write = (ref object o, object v) => ((FooType)o).Bar = (int)v
            },
        },
        MethodAotData = new ReMethod.AotData[] {
            new ReMethod.AotData {
                MethodName = "MyMethod",
                Invoke = (instance, args) => { ((FooType)instance).MyMethod((int)args[0], (int)args[1]); return null; }
            },
            new ReMethod.AotData {
                MethodName = "MyMethod2",
                Invoke = (instance, args) => ((FooType)instance).MyMethod2((int)args[0], (int)args[1])
            }
        }
    };
}