
namespace WolvenKit.RED4.Types
{
	public partial class cpConveyorComponent : entIVisualComponent
	{
		public cpConveyorComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
