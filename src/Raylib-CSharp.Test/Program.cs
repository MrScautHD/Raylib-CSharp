using System.Numerics;
using Raylib_CSharp.CSharp;
using Raylib_CSharp.CSharp.Windowing;

Console.WriteLine("Hello, World!");
Window.Init(1, 1, "Test");

while (!Window.ShouldClose()) {
   Quaternion quaternion = Quaternion.CreateFromYawPitchRoll(10, 10, 10);

   RayMath.QuaternionToAxisAngle(quaternion, out Vector3 axis, out float angle);
   
   Console.WriteLine("Axis: " + axis + "Angle: " + angle  * RayMath.Rad2Deg);


   Vector3 vector3 = new Vector3(1, 1, 1);
   Vector3 vector32 = new Vector3(2, 2, 2);

   unsafe {
      RayMath.Vector3OrthoNormalize(ref vector3, ref vector32);
   }

   Console.WriteLine("Vector 1: " + vector3);
   Console.WriteLine("Vector 2: " + vector32);
}