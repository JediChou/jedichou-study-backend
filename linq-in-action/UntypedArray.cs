// File name: UntypedArray.cs
// Description 1: 代码清单 4-2
// Description 2: 通过LINQ to Objects查询元素类型为Object的数组

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

static class TestArray
{
    static void Main()
    {
        Object[] array = {"String", 12, true, 'a'};
        var types = 
            array
                .Select(item => item.GetType().Name)
                .OrderBy(type=>type);
        ObjectDumper.Write(types);
    }
}

// Reference: https://github.com/lordviktor/101-Linq-Samples/blob/master/LINQ%20-%20Aggregate%20Operators/C%23/AggregateOperators/ObjectDumper.cs
public class ObjectDumper {
    public static void Write(object o) {
        Write(o, 0);
    }

    public static void Write(object o, int depth) {
        ObjectDumper dumper = new ObjectDumper(depth);
        dumper.WriteObject(null, o);
    }

    TextWriter writer;
    int pos;
    int level;
    int depth;

    private ObjectDumper(int depth) {
        this.writer = Console.Out;
        this.depth = depth;
    }

    private void Write(string s) {
        if (s != null) {
            writer.Write(s);
            pos += s.Length;
        }
    }

    private void WriteIndent() {
        for (int i = 0; i < level; i++) writer.Write("  ");
    }

    private void WriteLine() {
        writer.WriteLine();
        pos = 0;
    }

    private void WriteTab() {
        Write("  ");
        while (pos % 8 != 0) Write(" ");
    }

    private void WriteObject(string prefix, object o) {
        if (o == null || o is ValueType || o is string) {
            WriteIndent();
            Write(prefix);
            WriteValue(o);
            WriteLine();
        }
        else if (o is IEnumerable) {
            foreach (object element in (IEnumerable)o) {
                if (element is IEnumerable && !(element is string)) {
                    WriteIndent();
                    Write(prefix);
                    Write("...");
                    WriteLine();
                    if (level < depth) {
                        level++;
                        WriteObject(prefix, element);
                        level--;
                    }
                }
                else {
                    WriteObject(prefix, element);
                }
            }
        }
        else {
            MemberInfo[] members = o.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance);
            WriteIndent();
            Write(prefix);
            bool propWritten = false;
            foreach (MemberInfo m in members) {
                FieldInfo f = m as FieldInfo;
                PropertyInfo p = m as PropertyInfo;
                if (f != null || p != null) {
                    if (propWritten) {
                        WriteTab();
                    }
                    else {
                        propWritten = true;
                    }
                    Write(m.Name);
                    Write("=");
                    Type t = f != null ? f.FieldType : p.PropertyType;
                    if (t.IsValueType || t == typeof(string)) {
                        WriteValue(f != null ? f.GetValue(o) : p.GetValue(o, null));
                    }
                    else {
                        if (typeof(IEnumerable).IsAssignableFrom(t)) {
                            Write("...");
                        }
                        else {
                            Write("{ }");
                        }
                    }
                }
            }
            if (propWritten) WriteLine();
            if (level < depth) {
                foreach (MemberInfo m in members) {
                    FieldInfo f = m as FieldInfo;
                    PropertyInfo p = m as PropertyInfo;
                    if (f != null || p != null) {
                        Type t = f != null ? f.FieldType : p.PropertyType;
                        if (!(t.IsValueType || t == typeof(string))) {
                            object value = f != null ? f.GetValue(o) : p.GetValue(o, null);
                            if (value != null) {
                                level++;
                                WriteObject(m.Name + ": ", value);
                                level--;
                            }
                        }
                    }
                }
            }
        }
    }

    private void WriteValue(object o) {
        if (o == null) {
            Write("null");
        }
        else if (o is DateTime) {
            Write(((DateTime)o).ToShortDateString());
        }
        else if (o is ValueType || o is string) {
            Write(o.ToString());
        }
        else if (o is IEnumerable) {
            Write("...");
        }
        else {
            Write("{ }");
        }
    }
}