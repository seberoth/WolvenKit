
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAINodeMap_Record
	{
		[RED("map")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Map
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
