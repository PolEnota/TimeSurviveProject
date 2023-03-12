using UnityEngine;

namespace HSProject
{
    public static class Extensions
    {
        public static Vector2 Vector3ToVector2(this Vector3 vector3)
        {
            return new Vector2(vector3.x, vector3.y);
        }

        public static Vector3 Vector2ToVector3(this Vector2 vector2, float z = 0)
        {
            return new Vector3(vector2.x, vector2.y, z);
        }
    }
}

