#if UNITY_EDITOR
using UnityEditor;

namespace Unity.Vfx.Cameras
{
	public class PhysicalCameraPackaging
	{
		[MenuItem("Assets/VFx/Cameras/Make Package")]
		public static void MakePackage()
		{
			string[] files = new string[]
			{
				"Assets/VFx-Camera/Scripts/PhysicalCamera.cs",

				"Assets/VFx-Camera/Scripts/Model/MathematicalModel.cs",
				"Assets/VFx-Camera/Scripts/Model/PhysicalCameraBodyModel.cs",
				"Assets/VFx-Camera/Scripts/Model/PhysicalCameraLensModel.cs",
				"Assets/VFx-Camera/Scripts/Model/PhysicalCameraModel.cs",

				"Assets/VFx-Camera/Scripts/Editor/PhysicalCameraEditor.cs",
				"Assets/VFx-Camera/Scripts/Editor/SerializableObjHelper.cs",
				"Assets/Vfx-Camera/Scripts/Editor/PhysicalCameraPostprocessor.cs",

				"Assets/VFx-Camera/Cameras/Full Frame - 24mm (default).prefab"
			};
			AssetDatabase.ExportPackage(files, "VFX-PhysicalCameras.unitypackage", ExportPackageOptions.Recurse);
		}
	}
}
#endif // UNITY_EDITOR
