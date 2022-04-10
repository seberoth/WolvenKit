using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class Vector2 : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("X")] 
		public CFloat X
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public CFloat Y
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Vector2()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
