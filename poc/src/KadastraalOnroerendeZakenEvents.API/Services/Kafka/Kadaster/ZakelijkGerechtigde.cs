// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.5
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Kadaster
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class ZakelijkGerechtigde : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse(@"{""type"":""record"",""name"":""ZakelijkGerechtigde"",""namespace"":""Kadaster"",""fields"":[{""name"":""Id"",""type"":""long""},{""name"":""Type"",""type"":{""type"":""enum"",""name"":""ZakelijkGerechtigdeType"",""namespace"":""Kadaster"",""symbols"":[""Beklemrechthouder"",""Eigenaar"",""Erfpachter"",""GebruikBewoning"",""Grondrente"",""Opstalhouder"",""Vaderlandsrecht"",""Stadsmeierrecht"",""Vruchtgebruiker"",""ErfpachterOpstalhouder"",""Nutsvoorzieningen"",""TweeBelastingen"",""BelastingDerde"",""Bprecht"",""NutsvoorzieningenGedeelte"",""Artikel5_3b""]}},{""name"":""Aanvangsdatum"",""type"":""long"",""logicalType"":""date""}]}");
		private long _Id;
		private Kadaster.ZakelijkGerechtigdeType _Type;
		private long _Aanvangsdatum;
		public virtual Schema Schema
		{
			get
			{
				return ZakelijkGerechtigde._SCHEMA;
			}
		}
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}
		public Kadaster.ZakelijkGerechtigdeType Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}
		public long Aanvangsdatum
		{
			get
			{
				return this._Aanvangsdatum;
			}
			set
			{
				this._Aanvangsdatum = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Id;
			case 1: return this.Type;
			case 2: return this.Aanvangsdatum;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Id = (System.Int64)fieldValue; break;
			case 1: this.Type = (Kadaster.ZakelijkGerechtigdeType)fieldValue; break;
			case 2: this.Aanvangsdatum = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
