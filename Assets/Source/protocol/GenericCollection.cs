// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: generic_collection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LeanCloud.Play.Protocol {

  /// <summary>Holder for reflection information generated from generic_collection.proto</summary>
  public static partial class GenericCollectionReflection {

    #region Descriptor
    /// <summary>File descriptor for generic_collection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenericCollectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhnZW5lcmljX2NvbGxlY3Rpb24ucHJvdG8SF2NuLmxlYW5jbG91ZC5wbGF5",
            "LnByb3RvIqkDChZHZW5lcmljQ29sbGVjdGlvblZhbHVlEkIKBHR5cGUYASAB",
            "KA4yNC5jbi5sZWFuY2xvdWQucGxheS5wcm90by5HZW5lcmljQ29sbGVjdGlv",
            "blZhbHVlLlR5cGUSEgoIaW50VmFsdWUYAiABKAVIABIWCgxsb25nSW50VmFs",
            "dWUYAyABKANIABITCglib29sVmFsdWUYBCABKAhIABIVCgtzdHJpbmdWYWx1",
            "ZRgFIAEoCUgAEhQKCmJ5dGVzVmFsdWUYBiABKAxIABIUCgpmbG9hdFZhbHVl",
            "GAcgASgCSAASFQoLZG91YmxlVmFsdWUYCCABKAFIABIUCgxvYmplY3RUeXBl",
            "SWQYCSABKAUikAEKBFR5cGUSCAoETlVMTBAAEgkKBUJZVEVTEAESCAoEQllU",
            "RRACEgkKBVNIT1JUEAMSBwoDSU5UEAQSCAoETE9ORxAFEggKBEJPT0wQBhIJ",
            "CgVGTE9BVBAHEgoKBkRPVUJMRRAIEgoKBk9CSkVDVBAJEgoKBlNUUklORxAK",
            "EgcKA01BUBALEgkKBUFSUkFZEAxCBwoFdmFsdWUi+gEKEUdlbmVyaWNDb2xs",
            "ZWN0aW9uEkIKCWxpc3RWYWx1ZRgBIAMoCzIvLmNuLmxlYW5jbG91ZC5wbGF5",
            "LnByb3RvLkdlbmVyaWNDb2xsZWN0aW9uVmFsdWUSSgoNbWFwRW50cnlWYWx1",
            "ZRgCIAMoCzIzLmNuLmxlYW5jbG91ZC5wbGF5LnByb3RvLkdlbmVyaWNDb2xs",
            "ZWN0aW9uLk1hcEVudHJ5GlUKCE1hcEVudHJ5EgsKA2tleRgBIAEoCRI8CgN2",
            "YWwYAiABKAsyLy5jbi5sZWFuY2xvdWQucGxheS5wcm90by5HZW5lcmljQ29s",
            "bGVjdGlvblZhbHVlQhxQAaoCF0xlYW5DbG91ZC5QbGF5LlByb3RvY29sYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LeanCloud.Play.Protocol.GenericCollectionValue), global::LeanCloud.Play.Protocol.GenericCollectionValue.Parser, new[]{ "Type", "IntValue", "LongIntValue", "BoolValue", "StringValue", "BytesValue", "FloatValue", "DoubleValue", "ObjectTypeId" }, new[]{ "Value" }, new[]{ typeof(global::LeanCloud.Play.Protocol.GenericCollectionValue.Types.Type) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LeanCloud.Play.Protocol.GenericCollection), global::LeanCloud.Play.Protocol.GenericCollection.Parser, new[]{ "ListValue", "MapEntryValue" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry), global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry.Parser, new[]{ "Key", "Val" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GenericCollectionValue : pb::IMessage<GenericCollectionValue> {
    private static readonly pb::MessageParser<GenericCollectionValue> _parser = new pb::MessageParser<GenericCollectionValue>(() => new GenericCollectionValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GenericCollectionValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LeanCloud.Play.Protocol.GenericCollectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericCollectionValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericCollectionValue(GenericCollectionValue other) : this() {
      type_ = other.type_;
      objectTypeId_ = other.objectTypeId_;
      switch (other.ValueCase) {
        case ValueOneofCase.IntValue:
          IntValue = other.IntValue;
          break;
        case ValueOneofCase.LongIntValue:
          LongIntValue = other.LongIntValue;
          break;
        case ValueOneofCase.BoolValue:
          BoolValue = other.BoolValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
        case ValueOneofCase.BytesValue:
          BytesValue = other.BytesValue;
          break;
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
        case ValueOneofCase.DoubleValue:
          DoubleValue = other.DoubleValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericCollectionValue Clone() {
      return new GenericCollectionValue(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::LeanCloud.Play.Protocol.GenericCollectionValue.Types.Type type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::LeanCloud.Play.Protocol.GenericCollectionValue.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "intValue" field.</summary>
    public const int IntValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IntValue {
      get { return valueCase_ == ValueOneofCase.IntValue ? (int) value_ : 0; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.IntValue;
      }
    }

    /// <summary>Field number for the "longIntValue" field.</summary>
    public const int LongIntValueFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LongIntValue {
      get { return valueCase_ == ValueOneofCase.LongIntValue ? (long) value_ : 0L; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.LongIntValue;
      }
    }

    /// <summary>Field number for the "boolValue" field.</summary>
    public const int BoolValueFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool BoolValue {
      get { return valueCase_ == ValueOneofCase.BoolValue ? (bool) value_ : false; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.BoolValue;
      }
    }

    /// <summary>Field number for the "stringValue" field.</summary>
    public const int StringValueFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StringValue {
      get { return valueCase_ == ValueOneofCase.StringValue ? (string) value_ : ""; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.StringValue;
      }
    }

    /// <summary>Field number for the "bytesValue" field.</summary>
    public const int BytesValueFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString BytesValue {
      get { return valueCase_ == ValueOneofCase.BytesValue ? (pb::ByteString) value_ : pb::ByteString.Empty; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.BytesValue;
      }
    }

    /// <summary>Field number for the "floatValue" field.</summary>
    public const int FloatValueFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float FloatValue {
      get { return valueCase_ == ValueOneofCase.FloatValue ? (float) value_ : 0F; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.FloatValue;
      }
    }

    /// <summary>Field number for the "doubleValue" field.</summary>
    public const int DoubleValueFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DoubleValue {
      get { return valueCase_ == ValueOneofCase.DoubleValue ? (double) value_ : 0D; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.DoubleValue;
      }
    }

    /// <summary>Field number for the "objectTypeId" field.</summary>
    public const int ObjectTypeIdFieldNumber = 9;
    private int objectTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ObjectTypeId {
      get { return objectTypeId_; }
      set {
        objectTypeId_ = value;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      IntValue = 2,
      LongIntValue = 3,
      BoolValue = 4,
      StringValue = 5,
      BytesValue = 6,
      FloatValue = 7,
      DoubleValue = 8,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GenericCollectionValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GenericCollectionValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (IntValue != other.IntValue) return false;
      if (LongIntValue != other.LongIntValue) return false;
      if (BoolValue != other.BoolValue) return false;
      if (StringValue != other.StringValue) return false;
      if (BytesValue != other.BytesValue) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleValue, other.DoubleValue)) return false;
      if (ObjectTypeId != other.ObjectTypeId) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (valueCase_ == ValueOneofCase.IntValue) hash ^= IntValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.LongIntValue) hash ^= LongIntValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.BoolValue) hash ^= BoolValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.StringValue) hash ^= StringValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.BytesValue) hash ^= BytesValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.FloatValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
      if (valueCase_ == ValueOneofCase.DoubleValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleValue);
      if (ObjectTypeId != 0) hash ^= ObjectTypeId.GetHashCode();
      hash ^= (int) valueCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (valueCase_ == ValueOneofCase.IntValue) {
        output.WriteRawTag(16);
        output.WriteInt32(IntValue);
      }
      if (valueCase_ == ValueOneofCase.LongIntValue) {
        output.WriteRawTag(24);
        output.WriteInt64(LongIntValue);
      }
      if (valueCase_ == ValueOneofCase.BoolValue) {
        output.WriteRawTag(32);
        output.WriteBool(BoolValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(42);
        output.WriteString(StringValue);
      }
      if (valueCase_ == ValueOneofCase.BytesValue) {
        output.WriteRawTag(50);
        output.WriteBytes(BytesValue);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        output.WriteRawTag(61);
        output.WriteFloat(FloatValue);
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        output.WriteRawTag(65);
        output.WriteDouble(DoubleValue);
      }
      if (ObjectTypeId != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ObjectTypeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (valueCase_ == ValueOneofCase.IntValue) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntValue);
      }
      if (valueCase_ == ValueOneofCase.LongIntValue) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LongIntValue);
      }
      if (valueCase_ == ValueOneofCase.BoolValue) {
        size += 1 + 1;
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (valueCase_ == ValueOneofCase.BytesValue) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(BytesValue);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        size += 1 + 4;
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        size += 1 + 8;
      }
      if (ObjectTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObjectTypeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GenericCollectionValue other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.ObjectTypeId != 0) {
        ObjectTypeId = other.ObjectTypeId;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.IntValue:
          IntValue = other.IntValue;
          break;
        case ValueOneofCase.LongIntValue:
          LongIntValue = other.LongIntValue;
          break;
        case ValueOneofCase.BoolValue:
          BoolValue = other.BoolValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
        case ValueOneofCase.BytesValue:
          BytesValue = other.BytesValue;
          break;
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
        case ValueOneofCase.DoubleValue:
          DoubleValue = other.DoubleValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::LeanCloud.Play.Protocol.GenericCollectionValue.Types.Type) input.ReadEnum();
            break;
          }
          case 16: {
            IntValue = input.ReadInt32();
            break;
          }
          case 24: {
            LongIntValue = input.ReadInt64();
            break;
          }
          case 32: {
            BoolValue = input.ReadBool();
            break;
          }
          case 42: {
            StringValue = input.ReadString();
            break;
          }
          case 50: {
            BytesValue = input.ReadBytes();
            break;
          }
          case 61: {
            FloatValue = input.ReadFloat();
            break;
          }
          case 65: {
            DoubleValue = input.ReadDouble();
            break;
          }
          case 72: {
            ObjectTypeId = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GenericCollectionValue message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Type {
        [pbr::OriginalName("NULL")] Null = 0,
        [pbr::OriginalName("BYTES")] Bytes = 1,
        [pbr::OriginalName("BYTE")] Byte = 2,
        [pbr::OriginalName("SHORT")] Short = 3,
        [pbr::OriginalName("INT")] Int = 4,
        [pbr::OriginalName("LONG")] Long = 5,
        [pbr::OriginalName("BOOL")] Bool = 6,
        [pbr::OriginalName("FLOAT")] Float = 7,
        [pbr::OriginalName("DOUBLE")] Double = 8,
        [pbr::OriginalName("OBJECT")] Object = 9,
        [pbr::OriginalName("STRING")] String = 10,
        [pbr::OriginalName("MAP")] Map = 11,
        [pbr::OriginalName("ARRAY")] Array = 12,
      }

    }
    #endregion

  }

  public sealed partial class GenericCollection : pb::IMessage<GenericCollection> {
    private static readonly pb::MessageParser<GenericCollection> _parser = new pb::MessageParser<GenericCollection>(() => new GenericCollection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GenericCollection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LeanCloud.Play.Protocol.GenericCollectionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericCollection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericCollection(GenericCollection other) : this() {
      listValue_ = other.listValue_.Clone();
      mapEntryValue_ = other.mapEntryValue_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericCollection Clone() {
      return new GenericCollection(this);
    }

    /// <summary>Field number for the "listValue" field.</summary>
    public const int ListValueFieldNumber = 1;
    private static readonly pb::FieldCodec<global::LeanCloud.Play.Protocol.GenericCollectionValue> _repeated_listValue_codec
        = pb::FieldCodec.ForMessage(10, global::LeanCloud.Play.Protocol.GenericCollectionValue.Parser);
    private readonly pbc::RepeatedField<global::LeanCloud.Play.Protocol.GenericCollectionValue> listValue_ = new pbc::RepeatedField<global::LeanCloud.Play.Protocol.GenericCollectionValue>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::LeanCloud.Play.Protocol.GenericCollectionValue> ListValue {
      get { return listValue_; }
    }

    /// <summary>Field number for the "mapEntryValue" field.</summary>
    public const int MapEntryValueFieldNumber = 2;
    private static readonly pb::FieldCodec<global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry> _repeated_mapEntryValue_codec
        = pb::FieldCodec.ForMessage(18, global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry.Parser);
    private readonly pbc::RepeatedField<global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry> mapEntryValue_ = new pbc::RepeatedField<global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::LeanCloud.Play.Protocol.GenericCollection.Types.MapEntry> MapEntryValue {
      get { return mapEntryValue_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GenericCollection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GenericCollection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!listValue_.Equals(other.listValue_)) return false;
      if(!mapEntryValue_.Equals(other.mapEntryValue_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= listValue_.GetHashCode();
      hash ^= mapEntryValue_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      listValue_.WriteTo(output, _repeated_listValue_codec);
      mapEntryValue_.WriteTo(output, _repeated_mapEntryValue_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += listValue_.CalculateSize(_repeated_listValue_codec);
      size += mapEntryValue_.CalculateSize(_repeated_mapEntryValue_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GenericCollection other) {
      if (other == null) {
        return;
      }
      listValue_.Add(other.listValue_);
      mapEntryValue_.Add(other.mapEntryValue_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            listValue_.AddEntriesFrom(input, _repeated_listValue_codec);
            break;
          }
          case 18: {
            mapEntryValue_.AddEntriesFrom(input, _repeated_mapEntryValue_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GenericCollection message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class MapEntry : pb::IMessage<MapEntry> {
        private static readonly pb::MessageParser<MapEntry> _parser = new pb::MessageParser<MapEntry>(() => new MapEntry());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MapEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::LeanCloud.Play.Protocol.GenericCollection.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MapEntry() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MapEntry(MapEntry other) : this() {
          key_ = other.key_;
          val_ = other.val_ != null ? other.val_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MapEntry Clone() {
          return new MapEntry(this);
        }

        /// <summary>Field number for the "key" field.</summary>
        public const int KeyFieldNumber = 1;
        private string key_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Key {
          get { return key_; }
          set {
            key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "val" field.</summary>
        public const int ValFieldNumber = 2;
        private global::LeanCloud.Play.Protocol.GenericCollectionValue val_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::LeanCloud.Play.Protocol.GenericCollectionValue Val {
          get { return val_; }
          set {
            val_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as MapEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MapEntry other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (!object.Equals(Val, other.Val)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Key.Length != 0) hash ^= Key.GetHashCode();
          if (val_ != null) hash ^= Val.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Key.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Key);
          }
          if (val_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Val);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Key.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (val_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Val);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MapEntry other) {
          if (other == null) {
            return;
          }
          if (other.Key.Length != 0) {
            Key = other.Key;
          }
          if (other.val_ != null) {
            if (val_ == null) {
              Val = new global::LeanCloud.Play.Protocol.GenericCollectionValue();
            }
            Val.MergeFrom(other.Val);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Key = input.ReadString();
                break;
              }
              case 18: {
                if (val_ == null) {
                  Val = new global::LeanCloud.Play.Protocol.GenericCollectionValue();
                }
                input.ReadMessage(Val);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
