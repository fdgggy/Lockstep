using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lockstep.Math;

// C#类型/关键字	    范围	                大小	            .NET 类型
// sbyte	        -128 到 127	        8 位带符号整数	System.SByte
// byte	            0 到 255	        无符号的 8 位整数	System.Byte
// short	        -32,768 到 32,767	有符号 16 位整数	System.Int16
// ushort	        0 到 65,535	        无符号 16 位整数	System.UInt16
// int	            -2,147,483,648 到 2,147,483,647	带符号的 32 位整数	System.Int32
// uint	            0 到 4,294,967,295	无符号的 32 位整数	System.UInt32
// long	            -9,223,372,036,854,775,808 到 9,223,372,036,854,775,807	64 位带符号整数	System.Int64
// ulong	        0 到 18,446,744,073,709,551,615	无符号 64 位整数	System.UInt64
// nint	            取决于平台	带符号的 32 位或 64 位整数	System.IntPtr
// nuint	        取决于平台	无符号的 32 位或 64 位整数	System.UIntPtr
// float	±1.5 x 10−45 至 ±3.4 x 1038	大约 6-9 位数字	4 个字节	System.Single
// double	±5.0 × 10−324 到 ±1.7 × 10308	大约 15-17 位数字	8 个字节	System.Double
// decimal	±1.0 x 10-28 至 ±7.9228 x 1028	28-29 位	16 个字节	System.Decimal
//最左侧列中的每个 C# 类型关键字都是相应 .NET 类型的别名, 整型浮点类型的默认值都为零，0
// 不带后缀的文本或带有 d 或 D 后缀的文本的类型为 double
// 带有 f 或 F 后缀的文本的类型为 float
// 带有 m 或 M 后缀的文本的类型为 decimal
// double d = 3D;
// d = 4d;
// d = 3.934_001;
//
// float f = 3_000.5F;
// f = 5.4f;
//
// decimal myMoney = 3_000.5m;
// myMoney = 400.75M;
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tuple();
        TestFloat();
    }

    //元组类型是值类型，将多个数据元素分组成一个轻型数据结构
    //用于多返回值
    private void Tuple()
    {
        (double Sum, int Count) t = (6.6, 3);
        Debug.Log($"Tuple Sum:{t.Sum}, Count:{t.Count}");
        Debug.Log($"{t.ToString()}");

        //元组作为返回值
        var result = TupleReturn();
        Debug.Log($"result v1:{result.v1}, v2:{result.v2}");

        //元组作为out参数
        var limitsLookup = new Dictionary<int, (int Min, int Max)>()
        {
            [2] = (5, 10),
            [5] = (10, 20),
            [6] = (2, 18),
        };

        if (limitsLookup.TryGetValue(6, out (int Min, int Max) limits))
        {
            Debug.Log($"limitsLookup Min:{limits.Min}, Max:{limits.Max}");
        }
        
        // System.ValueTuple 类型是值类型。 System.Tuple 类型是引用类型。
        // System.ValueTuple 类型是可变的。 System.Tuple 类型是不可变的。
        // System.ValueTuple 类型的数据成员是字段。 System.Tuple 类型的数据成员是属性。
    }

    private (float v1, bool v2) TupleReturn()
    {
        return (8.0f, true);
    }
    
    private void TestFloat()
    {
        double d = 3D;
        d = 4d;
        d = 3.934_001;
        Debug.Log($"d:{d}");

        float f = 3_000.5F;
        Debug.Log($"f:{f}");

        decimal myMoney = 3_000.5m;
        Debug.Log($"myMoney:{myMoney}");

        LFloat floatValue = new LFloat(5);
        Debug.Log($"floatValue:{floatValue.ToString()}, hashCode:{floatValue.GetHashCode()}");
        Debug.Log($"floatValue ToInt:{floatValue.ToInt()}, ToLong:{floatValue.ToFloat()}");
        Debug.Log($"floatValue Floor:{floatValue.Floor()}");

        LFloat floatValue2 = new LFloat(false, -5.2f);
        Debug.Log($"floatValue2 Floor:{floatValue2.Floor()}");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
