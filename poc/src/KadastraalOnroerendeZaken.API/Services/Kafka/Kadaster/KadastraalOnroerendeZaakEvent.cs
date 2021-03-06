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
	
	public partial class KadastraalOnroerendeZaakEvent : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse("{\"type\":\"record\",\"name\":\"KadastraalOnroerendeZaakEvent\",\"namespace\":\"Kadaster\",\"f" +
				"ields\":[{\"name\":\"IndicatieStukCompleet\",\"type\":\"boolean\"},{\"name\":\"VorigEventIde" +
				"ntificatie\",\"type\":[\"null\",\"string\"]},{\"name\":\"NieuweToestand\",\"type\":{\"type\":\"r" +
				"ecord\",\"name\":\"KadastraalOnroerendeZaak\",\"namespace\":\"Kadaster\",\"fields\":[{\"name" +
				"\":\"Id\",\"type\":\"long\"},{\"name\":\"Type\",\"type\":{\"type\":\"enum\",\"name\":\"KadastraalOnr" +
				"oerendeZaakType\",\"namespace\":\"Kadaster\",\"symbols\":[\"Apartementsrecht\",\"Perceel\"]" +
				"}},{\"name\":\"KadastraleAanduiding\",\"type\":{\"type\":\"record\",\"name\":\"KadastraleAand" +
				"uiding\",\"namespace\":\"Kadaster\",\"fields\":[{\"name\":\"AppartementsrechtVolgnummer\",\"" +
				"type\":[\"null\",\"int\"]},{\"name\":\"KadastraleGemeenteCode\",\"type\":\"int\"},{\"name\":\"Pe" +
				"rceelnummer\",\"type\":\"int\"},{\"name\":\"Sectie\",\"type\":\"string\"}]}},{\"name\":\"Koopsom" +
				"\",\"type\":{\"type\":\"record\",\"name\":\"Koopsom\",\"namespace\":\"Kadaster\",\"fields\":[{\"na" +
				"me\":\"Bedrag\",\"type\":\"long\"},{\"name\":\"Koopjaar\",\"type\":\"int\"},{\"name\":\"IndicatieM" +
				"etMeerObjectenVerkregen\",\"type\":\"boolean\"}]}},{\"name\":\"ZakelijkGerechtigden\",\"ty" +
				"pe\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"ZakelijkGerechtigde\",\"names" +
				"pace\":\"Kadaster\",\"fields\":[{\"name\":\"Id\",\"type\":\"long\"},{\"name\":\"Type\",\"type\":{\"t" +
				"ype\":\"enum\",\"name\":\"ZakelijkGerechtigdeType\",\"namespace\":\"Kadaster\",\"symbols\":[\"" +
				"Beklemrechthouder\",\"Eigenaar\",\"Erfpachter\",\"GebruikBewoning\",\"Grondrente\",\"Opsta" +
				"lhouder\",\"Vaderlandsrecht\",\"Stadsmeierrecht\",\"Vruchtgebruiker\",\"ErfpachterOpstal" +
				"houder\",\"Nutsvoorzieningen\",\"TweeBelastingen\",\"BelastingDerde\",\"Bprecht\",\"Nutsvo" +
				"orzieningenGedeelte\",\"Artikel5_3b\"]}},{\"name\":\"Aanvangsdatum\",\"type\":\"long\",\"log" +
				"icalType\":\"date\"}]}}}]}}]}");
		private bool _IndicatieStukCompleet;
		private string _VorigEventIdentificatie;
		private Kadaster.KadastraalOnroerendeZaak _NieuweToestand;
		public virtual Schema Schema
		{
			get
			{
				return KadastraalOnroerendeZaakEvent._SCHEMA;
			}
		}
		public bool IndicatieStukCompleet
		{
			get
			{
				return this._IndicatieStukCompleet;
			}
			set
			{
				this._IndicatieStukCompleet = value;
			}
		}
		public string VorigEventIdentificatie
		{
			get
			{
				return this._VorigEventIdentificatie;
			}
			set
			{
				this._VorigEventIdentificatie = value;
			}
		}
		public Kadaster.KadastraalOnroerendeZaak NieuweToestand
		{
			get
			{
				return this._NieuweToestand;
			}
			set
			{
				this._NieuweToestand = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.IndicatieStukCompleet;
			case 1: return this.VorigEventIdentificatie;
			case 2: return this.NieuweToestand;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.IndicatieStukCompleet = (System.Boolean)fieldValue; break;
			case 1: this.VorigEventIdentificatie = (System.String)fieldValue; break;
			case 2: this.NieuweToestand = (Kadaster.KadastraalOnroerendeZaak)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
