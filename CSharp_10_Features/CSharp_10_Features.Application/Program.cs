using System.Text;

MyRecordStruct record1 = new MyRecordStruct("123", "321");
MyStruct struct1 = new MyStruct("123", "321");

Console.WriteLine(record1.ToString());
Console.WriteLine(struct1.ToString());

public record struct MyRecordStruct(string Prop1, string Prop2);

public struct MyStruct : IEquatable<MyStruct>
{
    public MyStruct(string prop1, string prop2)
    {
        Prop1 = prop1;
        Prop2 = prop2;
    }

    public string Prop1 { get; set; }
    public string Prop2 { get; set; }

    private bool PrintMembers(StringBuilder builder)
    {
        builder.Append(nameof(Prop1));
        builder.Append(" = ");
        builder.Append(Prop1);
        builder.Append(", ");

        builder.Append(nameof(Prop2));
        builder.Append(" = ");
        builder.Append(Prop2);

        return true;
    }

    public bool Equals(MyStruct other)
    {
        return other is MyStruct @struct && Equals(@struct);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(nameof(MyStruct));
        builder.Append(" { ");

        if (PrintMembers(builder))
            builder.Append(" ");

        builder.Append("}");
        return builder.ToString();
    }

    public override bool Equals(object obj)
    {
        return obj is MyStruct @struct && Equals(@struct);
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}